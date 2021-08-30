using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionRagdoll : MonoBehaviour
{
    public Rigidbody Ragman;
    public TurnOnRagDoll RagDoll;
    public ParticleSystem particleSystemCollision;
    // Start is called before the first frame update
    void Start()
    {
        Ragman = GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("AddMinusForce"))
        {
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, 5f);
            foreach (var item in hitColliders)
            {
                TurnOnRagDoll turnOnRagDoll;
                if (item.TryGetComponent(out turnOnRagDoll))
                {
                    Debug.Log("Boom");
                    
                    turnOnRagDoll.TurnsOnRagdoll();
                    turnOnRagDoll.GetComponent<Rigidbody>().AddExplosionForce(10000, collision.gameObject.transform.position, 10000);
                    GameObject newGo = Instantiate(particleSystemCollision, collision.gameObject.transform.position, Quaternion.identity).gameObject;
                    newGo.transform.localScale = new Vector3(.7f, .7f, .7f);
                }
            }
            /*RagDoll.TurnsOnRagdoll();
            Debug.Log("Boom");
            Ragman.AddExplosionForce(10000, Block.position, 10000);*/
        }
    }
}
