using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIalogueTest : MonoBehaviour
{
    public VIDE_Assign dialoge;
    public GameObject dialogeCineCam;

    private void Start()
    {
        LeanTween.delayedCall(2f, () => {
            DialogueManager.Instance.Begin(dialoge, dialogeCineCam);
        });
    }
}
