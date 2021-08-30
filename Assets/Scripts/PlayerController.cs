using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using Cinemachine;
using UnityEngine;

[RequireComponent(typeof(CharacterController), typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement Vars")]
    [SerializeField] private float walkingSpeed = 7.5f;
    [SerializeField] private float runningSpeed = 11.5f;
    [SerializeField] private float jumpSpeed = 8.0f;
    [SerializeField] private float gravity = 20.0f;
    [Tooltip("Smaller this value is the faster animation transition is")]
    [SerializeField] private float animationSmoothTime = .1f;
    [SerializeField] private float animationPlayTransition = .15f;
    [SerializeField] private Transform aimTarget;
    [SerializeField] private float aimDistance = 1f;

    [SerializeField] private Animator playerAnim;
    private int jumpAnimation;
    private int moveXAnimationParamterId;
    private int moveZAnimationParamterId;
    private Vector2 currentAnimationBlendVector;
    private Vector2 animationVelocity;


    private PlayerActions inputActions;
    private PlayerInput playerInput;
    //Current Control Scheme
    private string currentControlScheme;
    Vector2 currentMovement;
    bool isRunning = false;
    bool isJumping = false;


    MainManager mainManager;
    Rigidbody rb;
    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;
    
    [Header("Camera Vars")]
    
    [SerializeField] private float rotationSpeed = .8f;
    [SerializeField] private GameObject playerModel;
    [SerializeField] private ParticleSystem particleSystem_Win;
    [SerializeField] private ParticleSystem particleSystem_Reset;
    private Transform cameraTransform;

    private void Awake()
    {
        moveXAnimationParamterId = Animator.StringToHash("MoveX");
        moveZAnimationParamterId = Animator.StringToHash("MoveZ");
        jumpAnimation = Animator.StringToHash("Jump");
        inputActions = new PlayerActions();
        playerInput = GetComponent<PlayerInput>();
    }

    public void PlayWinParticleEffect()
    {
        particleSystem_Win.Play();
    }

    public void PlayResetParticleEffect()
    {
        particleSystem_Reset.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        currentControlScheme = playerInput.currentControlScheme;
        cameraTransform = Camera.main.transform;
        characterController = GetComponent<CharacterController>();
        mainManager = MainManager.instance;
        rb = GetComponent<Rigidbody>();
        CursorController.instance.ControlCursor(CursorController.CursorState.Locked);
        
        //isRunning Event
        inputActions.Land.Run.performed += ctx => { isRunning = true; };
        inputActions.Land.Run.canceled += ctx => { isRunning = false; };
        //Movement XY Event
        inputActions.Land.Movement.performed += ctx => { if(MainManager.instance.canPlayerMove) currentMovement = ctx.ReadValue<Vector2>(); };
        inputActions.Land.Movement.canceled += ctx => { currentMovement = Vector2.zero; };
        //isJumping Event
        inputActions.Land.Jump.performed += ctx => { isJumping = ctx.ReadValue<float>() == 1 ? true : false; };
        inputActions.Land.Jump.canceled += ctx => { isJumping = ctx.ReadValue<float>() == 1 ? true : false; };
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        aimTarget.transform.position = cameraTransform.position + cameraTransform.forward * aimDistance;
    }

    void PlayerMovement()
    {
        //Basic Movement
        float currentSpeedX = (isRunning ? runningSpeed : walkingSpeed) * currentMovement.x;
        float currentSpeedY = (isRunning ? runningSpeed : walkingSpeed) * currentMovement.y ;
        float movementDirectionY = moveDirection.y;

        currentAnimationBlendVector = Vector2.SmoothDamp(currentAnimationBlendVector, currentMovement, ref animationVelocity, animationSmoothTime);

        moveDirection = new Vector3(currentSpeedX, 0, currentSpeedY);
        moveDirection = moveDirection.x * cameraTransform.right.normalized + moveDirection.z * cameraTransform.transform.forward.normalized;
        moveDirection.y = 0;


        //Jumping
        if (isJumping && characterController.isGrounded)
        {
            moveDirection.y = jumpSpeed;
            playerAnim.CrossFade(jumpAnimation, animationPlayTransition);
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        // Move the controller
        if(characterController.enabled) characterController.Move(moveDirection * Time.deltaTime);

        //Rotate player model to face camera forward
        Quaternion targetRotation = Quaternion.Euler(0, cameraTransform.eulerAngles.y, 0);
        playerModel.transform.rotation = Quaternion.Lerp(playerModel.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        //Set Anim floats
        playerAnim.SetFloat(moveXAnimationParamterId, currentAnimationBlendVector.x);
        playerAnim.SetFloat(moveZAnimationParamterId, currentAnimationBlendVector.y);
    }

    //INPUT SYSTEM AUTOMATIC CALLBACKS --------------
    //This is automatically called from PlayerInput, when the input device has changed
    //(IE: Keyboard -> Xbox Controller)
    public void OnControlsChanged()
    {
        if (playerInput.currentControlScheme != currentControlScheme)
        {
            currentControlScheme = playerInput.currentControlScheme;
            //Debug.Log(currentControlScheme);
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
