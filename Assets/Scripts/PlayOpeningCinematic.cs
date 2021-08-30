using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;

public class PlayOpeningCinematic : MonoBehaviour
{
    [SerializeField] private PlayableDirector timelinePlayable;
    private PlayerActions inputActions;
    private bool isPressing;

    private void Awake()
    {
        inputActions = new PlayerActions();
    }

    // Start is called before the first frame update
    void Start()
    {
        //isPressing Event
        inputActions.Land.TriggerCinematic.performed += ctx => { isPressing = true; };
        inputActions.Land.TriggerCinematic.canceled += ctx => { isPressing = false; };
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(MainManager.instance.GetPlayerTag()) && isPressing)
        {
            //FindObjectOfType<FadeCamera>().RedoFade(FadeCamera.Fade.FadeOut);
            if(timelinePlayable.state != PlayState.Playing) timelinePlayable.Play();
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
