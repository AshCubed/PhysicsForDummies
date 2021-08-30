using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOrbitalGravity : MonoBehaviour
{
	const float G = 667.4f;

	//private OribitalGrabityParents parent;
	public static List<OribitalGrabityParents> Attractors;

	//public Rigidbody rb;
	public Rigidbody[] rbArray;
	public bool shouldAttract;
	private bool canAttract;
	public float gravitationalOrbitRange;
	public float maxMass;

	public Vector3 axis = Vector3.up;
	public float radius = 2.0f;
	public float radiusSpeed = 0.5f;
	public float rotationSpeed = 80.0f;
	private float startingMass;
	public ParticleSystem effectWaves;
	private AudioSource audioSourceGravity;

	private void Start()
	{
		//rb = GetComponent<Rigidbody>();
		//canAttract = shouldAttract;
		audioSourceGravity = GetComponent<AudioSource>();
		canAttract = false;
		rbArray = transform.GetComponentsInChildren<Rigidbody>();
		startingMass = rbArray[0].mass;
	}

	void FixedUpdate()
	{
		if (shouldAttract)
		{
            //Randomizes what is attracted
            foreach (OribitalGrabityParents attractor in Attractors)
            {
                if (canAttract)
                {
					if (!audioSourceGravity.isPlaying) audioSourceGravity.Play();
					if (Vector3.Distance(attractor.parent.transform.position, transform.position) > gravitationalOrbitRange)
					{
						/*int num = Random.Range(0, 2);
						if (num % 2 == 0)
						{
							if (attractor.parent != this)
							{
								foreach (var item in attractor.rgChildren)
								{
									Attract(item);
								}
							}
						}*/

						foreach (var item in attractor.rgChildren)
						{
							if (Vector3.Distance(item.transform.position, transform.position) > gravitationalOrbitRange)
							{
								int num = Random.Range(0, 2);
								if (num % 2 == 0)
								{
									if (attractor.parent != this)
									{
										Attract(item);
									}
								}
							}
						}
					}

					if (Vector3.Distance(attractor.parent.transform.position, transform.position) <= gravitationalOrbitRange)
					{
						/*              foreach (var item in attractor.rgChildren)
										{
											if (item.useGravity) item.useGravity = false;
										}
										Vector3 relativePos = (attractor.parent.transform.position + new Vector3(0, .001f, 0)) - transform.position;
										Quaternion rotation = Quaternion.LookRotation(relativePos);

										Quaternion current = attractor.parent.transform.localRotation;

										attractor.parent.transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
										attractor.parent.transform.Translate(0, 0, .001f * Time.deltaTime);*/
						foreach (var item in attractor.rgChildren)
						{
							if (item.useGravity)
							{
								item.useGravity = false;
								item.constraints = RigidbodyConstraints.FreezeAll;
								LeanTween.delayedCall(0.01f, () =>
								{
									item.constraints = RigidbodyConstraints.None;
								});
								//item.AddForce(-item.velocity, ForceMode.Impulse);
							}
							/*item.transform.RotateAround(transform.position, axis, rotationSpeed * Time.deltaTime);
							var desiredPosition = (item.transform.position - transform.position).normalized * radius + transform.position;
							item.transform.position = Vector3.MoveTowards(item.transform.transform.position, desiredPosition, Time.deltaTime * radiusSpeed);*/
							rotateRigidBodyAroundPointBy(item, transform.position, axis, 5f);
						}
						/*attractor.parent.transform.RotateAround(transform.position, axis, rotationSpeed * Time.deltaTime);
						var desiredPosition = (attractor.parent.transform.position - transform.position).normalized * radius + transform.position;
						attractor.parent.transform.position = Vector3.MoveTowards(attractor.parent.transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
					*/
					}
				}
				else
				{
					if (audioSourceGravity.isPlaying) audioSourceGravity.Stop();
					foreach (var item in attractor.rgChildren)
                    {
                        if (!item.useGravity) item.useGravity = true;
                        //item.AddForce(item.gameObject.transform.TransformDirection(Vector3.forward) * rotationSpeed);
                    }
                }
			}
        }
	}

	public void rotateRigidBodyAroundPointBy(Rigidbody rb, Vector3 origin, Vector3 axis, float angle)
	{
		Quaternion q = Quaternion.AngleAxis(angle, axis);
		rb.MovePosition(q * (rb.transform.position - origin) + origin);
		rb.MoveRotation(rb.transform.rotation * q);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="newMass">amount to add or subtract</param>
	/// <param name="subAdd">1 is add, -1 is subtract</param>
	public void AddSubtractMass(float newMass, float subAdd)
    {
        if (subAdd == 1)
        {
            if (rbArray[0].mass < maxMass)
            {
				rbArray[0].mass += newMass;
				canAttract = true;
				if (!effectWaves.isPlaying) effectWaves.Play();
			}
		}
        else if (subAdd == -1)
        {
            if (rbArray[0].mass > startingMass)
            {
				rbArray[0].mass -= newMass;
			}
            else
            {
				canAttract = false;
				if (effectWaves.isPlaying) effectWaves.Stop();
			}
		}
    }

	void OnEnable()
	{
		if (Attractors == null)
			Attractors = new List<OribitalGrabityParents>();

		if (!shouldAttract)
		{
			OribitalGrabityParents test = new OribitalGrabityParents();
			test.parent = this;
			rbArray = transform.GetComponentsInChildren<Rigidbody>();
			test.rgChildren = rbArray;
			test.shouldBeAttracting = true;
			Attractors.Add(test);
		}
	}

	void OnDisable()
	{
		Attractors.Remove(Attractors.Find(x => x.parent = this));
	}

	//Pulls items to objects with the should Attract bool true
	void Attract(Rigidbody objToAttract)
	{
		Rigidbody rbToAttract = objToAttract;//.rb;

		Vector3 direction = transform.position - rbToAttract.position;
		float distance = direction.magnitude;

		if (distance <= 0f)
			return;

		float forceMagnitude = G * (rbArray[0].mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
		Vector3 force = direction.normalized * (forceMagnitude);

		rbToAttract.AddForce(force);
	}

    private void OnDrawGizmos()
	{
		if (shouldAttract)
		{
			// Draw a yellow sphere at the transform's position
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(transform.position, gravitationalOrbitRange);
		}
	}

}

[System.Serializable]
public class OribitalGrabityParents
{
	public ObjectOrbitalGravity parent;
	public Rigidbody[] rgChildren;
	public bool shouldBeAttracting;
}
