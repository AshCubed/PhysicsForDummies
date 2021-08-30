using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticField : MonoBehaviour
{
    public enum Polatiry { North, South }
    public Polatiry objectsPolatiry;
    //public GameObject point;
    public Material north;
    public Material south;
    public float forceFactor;
    private Rigidbody rb;
    private List<Rigidbody> metalObjects;
    [SerializeField] private StorePolarity north1, south1;
    [SerializeField] private float forceMultiplier;
    private bool isPlayerOn;
    private GameObject player;
    [SerializeField] ParticleSystem particleSystemNorth;
    [SerializeField] ParticleSystem particleSystemSouth;

    // Start is called before the first frame update
    void Start()
    {
        isPlayerOn = false;
        player = MainManager.instance.GetPlayer();
        metalObjects = new List<Rigidbody>();
        rb = GetComponent<Rigidbody>();
        particleSystemNorth.Stop();
        particleSystemSouth.Stop();

        ParticleSystem.MainModule psMain = particleSystemNorth.GetComponent<ParticleSystem>().main;
        ParticleSystem.MainModule psMainChild = particleSystemNorth.GetComponentInChildren<ParticleSystem>().main;
        psMain.startColor = north.color;
        psMainChild.startColor = north.color;

        ParticleSystem.MainModule psMain2 = particleSystemSouth.GetComponent<ParticleSystem>().main;
        ParticleSystem.MainModule psMain2Child = particleSystemSouth.GetComponentInChildren<ParticleSystem>().main;
        psMain2.startColor = south.color;
        psMain2Child.startColor = south.color;

        SwitchColors();

        /*RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(-Vector3.right), out hit, Mathf.Infinity))
        {
            //Debug.Log(hit.collider.name, hit.collider.gameObject);
            StorePolarity objectPolatiry;
            if (hit.collider.gameObject.TryGetComponent(out objectPolatiry))
            {
                if (objectPolatiry.GetCurrentPolatiry() == Polatiry.North)
                {
                    north1 = objectPolatiry;
                }
                else
                {
                    south1 = objectPolatiry;
                }
            }
        }

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, Mathf.Infinity))
        {
            //Debug.Log(hit.collider.name, hit.collider.gameObject);
            StorePolarity objectPolatiry;
            if (hit.collider.gameObject.TryGetComponent(out objectPolatiry))
            {
                if (objectPolatiry.GetCurrentPolatiry() == Polatiry.North)
                {
                    north1 = objectPolatiry;
                }
                else
                {
                    south1 = objectPolatiry;
                }
            }
        }*/
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Q))
        {
            switch (objectsPolatiry)
            {
                case Polatiry.North:
                    ChangePolatiry(Polatiry.South);
                    break;
                case Polatiry.South:
                    ChangePolatiry(Polatiry.North);
                    break;
                default:
                    break;
            }
        }*/
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*if (metalObjects.Count > 0)
        {
            foreach (var item in metalObjects)
            {
                Vector3 direction = transform.position - item.transform.position;
                switch (objectsPolatiry)
                {
                    case Polatiry.North:
                        
                        item.AddForce(direction * forceFactor, ForceMode.Force);
                        break;
                    case Polatiry.South:
                        item.AddForce(-direction * forceFactor, ForceMode.Force);
                        break;
                    default:
                        break;
                }
            }
        }*/

        //Debug.DrawRay(transform.position, transform.TransformDirection(-Vector3.right) * 10f, Color.green);
        /*
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(-Vector3.right), out hit, Mathf.Infinity))
                {
                    //Debug.Log(hit.collider.name, hit.collider.gameObject);
                    StorePolarity objectPolatiry;
                    if (hit.collider.gameObject.TryGetComponent(out objectPolatiry) && objectPolatiry.GetCurrentPolatiry() == Polatiry.North)
                    {
                        transform.LeanMoveX(hit.collider.transform.position.x + offset, .1f);
                    }
                }*/

        /*if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, Mathf.Infinity))
        {
            //Debug.Log(hit.collider.name, hit.collider.gameObject);

        }*/

        //Vector3 direction = Vector3.zero;
        switch (objectsPolatiry)
        {
            case Polatiry.North:
                rb.AddForce((north1.GetMoveToPoint() - transform.position) * forceMultiplier);
               /* if (isPlayerOn)
                {
                    player.GetComponent<Rigidbody>().AddForce((north1.GetMoveToPoint() - transform.position) * forceMultiplier);
                }*/
                //rb.MovePosition(north1.GetMoveToPoint());
                break;
            case Polatiry.South:
                rb.AddForce((south1.GetMoveToPoint() - transform.position) * forceMultiplier);
                /*if (isPlayerOn)
                {
                    player.GetComponent<Rigidbody>().AddForce((south1.GetMoveToPoint() - transform.position) * forceMultiplier);
                }*/
                //rb.MovePosition(south1.GetMoveToPoint());
                break;
            default:
                break;
        }
        

        /*Vector3 force = direction.normalized * 2f;

        rb.AddForce(force);*/

    }

    void SwitchColors()
    {
        switch (objectsPolatiry)
        {
            case Polatiry.North:
                particleSystemSouth.Stop();

                particleSystemNorth.Play();
                break;
            case Polatiry.South:
                particleSystemNorth.Stop();

                particleSystemSouth.Play();
                break;
            default:
                break;
        }
    }
    
    public void ChangePolatiry(Polatiry newPolarity)
    {
        objectsPolatiry = newPolarity;
        if (isPlayerOn)
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            GetComponent<BoxCollider>().enabled = false;
        }
        switch (objectsPolatiry)
        {
            case Polatiry.North:
                //objectsPolatiry = MagneticField.Polatiry.South;
                //LeanTweenExt.LeanMove(gameObject, north1.GetMoveToPoint(), 2f);
                break;
            case Polatiry.South:
                //objectsPolatiry = MagneticField.Polatiry.North;
                //LeanTweenExt.LeanMove(gameObject, south1.GetMoveToPoint(), 2f);
                break;
            default:
                break;
        }
        SwitchColors();
    }


    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Metal"))
        {
            metalObjects.Add(other.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (metalObjects.Find(x => x.gameObject == other.gameObject))
        {
            metalObjects.Remove(other.GetComponent<Rigidbody>());
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(MainManager.instance.GetPlayerTag()))
        {
            other.transform.SetParent(transform);
            isPlayerOn = true;
            //player.GetComponent<Rigidbody>().isKinematic = true;
            //xmotion, zmotion, angulary
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(MainManager.instance.GetPlayerTag()))
        {
            other.transform.SetParent(null);
            //player.GetComponent<Rigidbody>().isKinematic = false;
            isPlayerOn = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isPlayerOn)
        {
            switch (objectsPolatiry)
            {
                case Polatiry.North:
                    if (collision.collider.gameObject == north1.gameObject)
                    {
                        player.GetComponent<CharacterController>().enabled = true;
                        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                        GetComponent<BoxCollider>().enabled = true;
                    }
                    break;
                case Polatiry.South:
                    if (collision.collider.gameObject == south1.gameObject)
                    {
                        player.GetComponent<CharacterController>().enabled = true;
                        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                        GetComponent<BoxCollider>().enabled = true;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
