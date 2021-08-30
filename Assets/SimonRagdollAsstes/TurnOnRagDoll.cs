using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnRagDoll : MonoBehaviour
{
    public List<Collider> RagdollParts = new List<Collider>();
    private Rigidbody rigid;
    public Animator animator;
    public Rigidbody RIGID_BODY
    {
        get
        {
            if (rigid == null)
            {
                rigid = GetComponent<Rigidbody>();
            }
            return rigid;
        }
    }
    public void Awake()
    {
        SetRagdollParts();


    }

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.delayedCall(1f, () => { TurnsOnRagdoll(); });
    }


    private void SetRagdollParts()
    {
        Collider[] colliders = this.gameObject.GetComponentsInChildren<Collider>();

        foreach (Collider c in colliders)
        {
            if (c.gameObject != this.gameObject)
            {
                c.isTrigger = true;
                RagdollParts.Add(c);
            }
        }
    }

    public void TurnsOnRagdoll()
    {
        Debug.Log("working");
        RIGID_BODY.useGravity = false;
        RIGID_BODY.velocity = Vector3.zero;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
         animator.enabled = false;
        animator.avatar = null;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        foreach (Collider c in RagdollParts)
        {
            c.isTrigger = false;
            c.attachedRigidbody.velocity = Vector3.zero;
        }
    }
}
