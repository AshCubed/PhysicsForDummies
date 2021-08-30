using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorePolarity : MonoBehaviour
{
    [SerializeField] private MagneticField.Polatiry currentPolatiry;
    [SerializeField] private Material north;
    [SerializeField] private Material south;
    [SerializeField] private GameObject magnetMoveToPoint;
    [SerializeField] private ParticleSystem particleSystemMagnet;

    private void Start()
    {
        SwitchColors();
    }

    void SwitchColors()
    {
        switch (currentPolatiry)
        {
            case MagneticField.Polatiry.North:
                ParticleSystem.MainModule psMain = particleSystemMagnet.GetComponent<ParticleSystem>().main;
                ParticleSystem.MainModule psMainChild = particleSystemMagnet.GetComponentInChildren<ParticleSystem>().main;
                psMain.startColor = north.color;
                psMainChild.startColor = north.color;
                break;
            case MagneticField.Polatiry.South:
                ParticleSystem.MainModule psMain2 = particleSystemMagnet.GetComponent<ParticleSystem>().main;
                ParticleSystem.MainModule psMain2Child = particleSystemMagnet.GetComponentInChildren<ParticleSystem>().main;
                psMain2.startColor = south.color;
                psMain2Child.startColor = south.color;
                break;
            default:
                break;
        }
    }

    public MagneticField.Polatiry GetCurrentPolatiry()
    {
        return currentPolatiry;
    }

    public Vector3 GetMoveToPoint()
    {
        return magnetMoveToPoint.transform.position;
    }
}
