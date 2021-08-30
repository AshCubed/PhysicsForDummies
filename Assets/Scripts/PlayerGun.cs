using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] private GameObject crosshairs;
    [Header("Gun Image Info")]
    [SerializeField] private RawImage magnet;
    [SerializeField] private RawImage orbit;
    [SerializeField] private RawImage addMinusForce;
    [SerializeField] float addMinusForceApplied;
    [SerializeField] private RawImage generalGravity;
    [SerializeField] private Color normal, faded;
    [SerializeField] private LineRenderer lineRendererGun;
    [SerializeField] private Transform lineStayPos;

    private PlayerActions inputActions;
    private bool isAdding = false;
    private bool isMinusing = false;
    private Transform cameraTransform;

    private void Awake()
    {
        inputActions = new PlayerActions();
        cameraTransform = Camera.main.transform;
    }

    private void Start()
    {
        lineRendererGun.enabled = false;

        inputActions.Land.Add.performed += ctx => { isAdding = ctx.ReadValue<float>() == 1 ? true : false; };
        inputActions.Land.Add.canceled += ctx => { isAdding = ctx.ReadValue<float>() == 1 ? true : false; };

        inputActions.Land.Minus.performed += ctx => { isMinusing = ctx.ReadValue<float>() == 1 ? true : false; };
        inputActions.Land.Minus.canceled += ctx => { isMinusing = ctx.ReadValue<float>() == 1 ? true : false; };
    }


    private void LateUpdate()
    {
        if (lineRendererGun.enabled)
        {
            lineRendererGun.SetPosition(0, lineStayPos.position);
        }
    }

    private void LineRendererSetPos(int index, Vector3 pos, bool x)
    {
        lineRendererGun.enabled = x;
        lineRendererGun.SetPosition(1, pos);
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ViewportToWorldPoint(crosshairs.transform.position), Camera.main.transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.CompareTag("Magnet"))
            {
                magnet.color = normal;
                LineRendererSetPos(1, hit.point, true);
            }
            else if (hit.collider.CompareTag("Orbit"))
            {
                orbit.color = normal;
                LineRendererSetPos(1, hit.point, true);
            }
            else if (hit.collider.CompareTag("AddMinusForce"))
            {
                addMinusForce.color = normal;
                LineRendererSetPos(1, hit.point, true);
            }
            else if (hit.collider.CompareTag("GeneralGravity"))
            {
                generalGravity.color = normal;
                LineRendererSetPos(1, hit.point, true);
            }
            else
            {
                magnet.color = faded;
                orbit.color = faded;
                addMinusForce.color = faded;
                generalGravity.color = faded;
                LineRendererSetPos(1, lineStayPos.position, false);
            }

            //Debug.Log(hit.collider.name, hit.collider.gameObject);
            if (isAdding)
            {
                if (hit.collider.CompareTag("Magnet"))
                {
                    AudioManager.instance.PlaySounds("Gun_Magnet");
                    hit.collider.GetComponent<MagneticField>().ChangePolatiry(MagneticField.Polatiry.North);
                }
                else if (hit.collider.CompareTag("Orbit"))
                {
                    if (hit.collider.GetComponent<ObjectOrbitalGravity>().shouldAttract)
                        hit.collider.GetComponent<ObjectOrbitalGravity>().AddSubtractMass(1f, 1);
                }
                else if (hit.collider.CompareTag("AddMinusForce"))
                {
                    AudioManager.instance.PlaySounds("Gun_Velocity_SpeedUp");
                    Vector3 force = transform.TransformDirection(cameraTransform.forward) * addMinusForceApplied;
                    hit.collider.GetComponent<Rigidbody>().drag = 0f;
                    hit.collider.GetComponent<Rigidbody>().AddForce(force, ForceMode.Force);
                }
                else if (hit.collider.CompareTag("GeneralGravity"))
                {
                    hit.collider.GetComponent<Rigidbody>().useGravity = false;
                    Vector3 force = transform.TransformDirection(Vector3.up) * .1f;
                    Vector3 torque = Vector3.zero;
                    int rnd = Random.Range(1, 3);
                    if (rnd == 1)
                    {
                        torque = transform.TransformDirection(Vector3.right) * .1f;
                    }
                    else if (rnd == 2)
                    {
                        torque = transform.TransformDirection(-Vector3.right) * .1f;
                    }
                    hit.collider.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
                    hit.collider.GetComponent<Rigidbody>().AddTorque(torque, ForceMode.Impulse);
                }
            }
            else if (isMinusing)
            {
                if (hit.collider.CompareTag("Magnet"))
                {
                    AudioManager.instance.PlaySounds("Gun_Magnet");
                    hit.collider.GetComponent<MagneticField>().ChangePolatiry(MagneticField.Polatiry.South);
                }
                else if (hit.collider.CompareTag("Orbit"))
                {
                    hit.collider.GetComponent<ObjectOrbitalGravity>().AddSubtractMass(1f, -1);
                }
                else if (hit.collider.CompareTag("AddMinusForce"))
                {
                    AudioManager.instance.PlaySounds("Gun_Velocity_Slow");
                    Vector3 force = transform.TransformDirection(cameraTransform.forward) * -addMinusForceApplied;
                    //hit.collider.GetComponent<Rigidbody>().drag = 4f;
                    hit.collider.GetComponent<Rigidbody>().AddForce(force, ForceMode.Force);
                }
                else if (hit.collider.CompareTag("GeneralGravity"))
                {
                    hit.collider.GetComponent<Rigidbody>().useGravity = transform;
                    Vector3 force = transform.TransformDirection(-Vector3.up) * .1f;
                    hit.collider.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);

                }
            }
        }
    }
    private void OnEnable()
    {
        inputActions.Land.Enable();
    }

    private void OnDisable()
    {
        inputActions.Land.Disable();
    }
}
