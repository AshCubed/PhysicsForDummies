using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using VIDE_Data;
using Cinemachine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private GameObject containter_NPC;
    [SerializeField] private GameObject container_PLAYER;
    [SerializeField] private TextMeshProUGUI text_NPC;
    [SerializeField] private TextMeshProUGUI[] text_Choices;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private KeyCode NextDialogueKey;
    public static DialogueManager Instance;
    private PlayerActions inputActions;
    private GameObject playerUI;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        inputActions = new PlayerActions();
    }

    // Start is called before the first frame update
    void Start()
    {
        containter_NPC.SetActive(false);
        container_PLAYER.SetActive(false);
        playerUI = GameObject.FindGameObjectWithTag("PlayerUI");
        //Dialogue Next Event
        inputActions.Land.DialogueNext.performed += ctx => {
            if (VD.isActive)
            {
                VD.Next();
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(NextDialogueKey))
        {
            if (Input.GetKeyDown(NextDialogueKey))
            {
                if (VD.isActive)
                {
                    VD.Next();
                }
            }
        }*/
    }

    public void Begin(VIDE_Assign dialogueData, GameObject newCam = null)
    {
        if (newCam != null) CameraTransitions.instance.SetNewCam(newCam);
        playerUI.SetActive(false);
        VD.OnNodeChange += UpdateUi;
        VD.OnEnd += End;
        VD.EndDialogue();
        CursorController.instance.ControlCursor(CursorController.CursorState.Unlocked);
        VD.BeginDialogue(dialogueData);
    }

    void UpdateUi(VD.NodeData data)
    {
        audioSource.Stop();
        containter_NPC.SetActive(false);
        container_PLAYER.SetActive(false);
        if (data.isPlayer)
        {
            container_PLAYER.SetActive(true);

            for (int i = 0; i < text_Choices.Length; i++)
            {
                if (i < data.comments.Length)
                {
                    text_Choices[i].transform.parent.gameObject.SetActive(true);
                    text_Choices[i].text = data.comments[i];
                }
                else
                {
                    text_Choices[i].transform.parent.gameObject.SetActive(false);
                }
            }
        }
        else
        {
            if (!containter_NPC.activeSelf)
            {
                containter_NPC.SetActive(true);
                text_NPC.text = data.comments[data.commentIndex];
                PlayeAudioBite();
                
            }
            else
            {
                text_NPC.text = data.comments[data.commentIndex];
                PlayeAudioBite();
            }

            
        }

        void PlayeAudioBite()
        {
            if (data.audios[data.commentIndex] != null)
                audioSource.clip = data.audios[data.commentIndex];
                audioSource.Play();
        }
    }


    void End(VD.NodeData data)
    {
        VD.OnNodeChange -= UpdateUi;
        VD.OnEnd -= End;
        VD.EndDialogue();
        audioSource.Stop();
        containter_NPC.SetActive(false);
        container_PLAYER.SetActive(false);
        text_NPC.text = "";
        CameraTransitions.instance.SetToMainCam();
        if (playerUI)
            playerUI.SetActive(true);
        else
            Debug.Log("NO PLAYER UI IN " + this.name, gameObject);
        CursorController.instance.ControlCursor(CursorController.CursorState.Locked);
    }

    private void OnEnable()
    {
        inputActions.Land.Enable();
    }

    private void OnDisable()
    {
        inputActions.Land.Disable();
        if (containter_NPC != null)
        {
            End(null);
        }
    }

    public void SetPlayerChoice(int choice)
    {
        VD.nodeData.commentIndex = choice;
        if (Input.GetMouseButtonUp(0))
        {
            VD.Next();
        }
    }


}
