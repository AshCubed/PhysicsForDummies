// GENERATED AUTOMATICALLY FROM 'Assets/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""f4fe566d-180c-4378-8330-06ffc954ec0d"",
            ""actions"": [
                {
                    ""name"": ""Add"",
                    ""type"": ""Value"",
                    ""id"": ""cca874aa-4924-46da-8a38-5b5b3ef7d40a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Minus"",
                    ""type"": ""Value"",
                    ""id"": ""9c040f09-0ec1-4b8e-9d92-6ddbab61b73d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""51dda0e1-1642-40d0-94a7-27d891053675"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera Movement"",
                    ""type"": ""Value"",
                    ""id"": ""c2236a9d-2c4f-47cc-8379-bbfb24dccd7a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""4fc88a51-79c5-47cb-8b1b-f7c8ad47a79a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Value"",
                    ""id"": ""4312f4b0-1dc2-40e1-baab-9cc9bd8d7618"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CursorControl"",
                    ""type"": ""Value"",
                    ""id"": ""158d5330-c035-4e85-a7af-304d3e388c15"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Value"",
                    ""id"": ""d1081404-4932-4457-af49-098b35b81c23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DialogueNext"",
                    ""type"": ""Value"",
                    ""id"": ""b0304c0d-380b-44a7-922d-fe97384348b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerCinematic"",
                    ""type"": ""Value"",
                    ""id"": ""ea453fc1-2ae3-4152-9902-fd7b60a07bad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4f2aab78-ec94-407f-bd6c-5c53e12b839b"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Add"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""965e041a-09a6-4c79-a639-df7b916e82ea"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Add"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD Keys"",
                    ""id"": ""5f287779-1e89-4790-aea2-c069184c85e9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f1778616-1f07-461e-8143-a9ce9c39fc2e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4026a753-a034-48aa-84ac-c2e47b227483"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f88f0b01-df07-464a-a9f4-2017f7423871"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ff96863a-c799-4295-a83b-af5f833e6dc2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""46bb0be8-e594-4f61-8d00-d5a0759e8565"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7473403-39a8-40bd-9074-6ec539010874"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbcec784-395d-425f-8b1f-a98c5acaf12a"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Camera Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""119e4e67-62e9-46e8-a6b0-94d2dfb55cb6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab790c61-28cf-4f72-b103-8704c3962d4c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a5c3aa2-d024-479b-9141-d38fa5408816"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5bebc3e2-8762-4bcf-813a-1baa4fb4d1a7"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fafbf8e7-2bff-4f78-8066-90c62102ae5a"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Minus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0e629d7-882a-4086-bf98-f3f48eed616f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Minus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23f0da9a-90c6-4a0a-b4c5-220b0e0f600f"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""CursorControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0accdb1-56d9-4eae-8e1b-d41b60f98511"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""747510f5-1207-4c0c-b531-a8ed9aee8c5b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad1ec96b-fcb7-48a3-8188-bead4aeaff1e"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""DialogueNext"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6eb69f9c-9692-479d-a1ef-2dc68a282934"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DialogueNext"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""389018a6-870b-4fda-a2a2-c765f194b918"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""TriggerCinematic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""996facb9-5e74-4f39-b8a2-167c17c09d61"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TriggerCinematic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu Controls"",
            ""id"": ""e89ad0ce-8c0e-4721-a452-d1ff30268153"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""fd00a6bd-1f06-4e94-b24f-f58b87e5058c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f85bb4c9-ba39-40eb-b4c8-8be77b89eb17"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""db043c4f-f6ba-40fd-8985-db4a951f8859"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""00dec310-8e79-44c7-97f4-349f83dccfe1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""201a5934-54d9-498f-9901-14d206083caa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""38836efe-e915-4292-aedf-1be8a1053aa7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2bb78aa9-e1bc-46fc-b99c-1b2fcc6b0ddb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""36e36902-da59-41d2-8e8d-f1f558452eb7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d067842a-3dc4-4f31-b515-ad9067418644"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""d4c7f95c-b73d-422f-b143-13bea21b2a0e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""5b88947a-4416-421e-ae4f-ae02d0d880e6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5a6b9b85-f5fc-4a73-9d6e-cd591cadee06"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""246fc873-7314-4d33-93a5-c147d079ca21"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""910b2d6c-f92f-4014-bf6a-ae47020f2cc2"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f93a1fe0-8cc2-4ba2-91e3-99fb710451d1"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1e28d6f5-775f-4b5a-bbd9-6b051f166602"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5ca9cb3b-05c8-465a-b83e-df48881c785c"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""908b91d3-40ec-4c80-9169-21bfa77fcf3d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1648d38d-6503-40e1-8d93-8e985f82537d"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3f457cd5-8b76-497c-9932-888abefa998a"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""b717f4b5-b96d-4ae3-8c03-26bb2ebc1ca9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0b42c4c5-9215-4ce0-864a-9296a81051d5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cd19c2a3-f730-493c-9a0d-aab96feca464"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8da046db-44c8-4072-9479-c644b1ccf309"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a656ba12-456c-4694-bbc0-301936bc8f5e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""11e54851-2535-4a5b-aca8-bf01e80e7ea4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""eb59e149-02b2-4183-a369-eef3eaf60366"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a2bd6471-5166-4450-9143-067b6f4557f3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7c0a3a07-63ad-4735-bb84-ad8f1b862e5b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9505b8e7-e0a0-49e1-ad1f-df85c83380ac"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e060c10-1ee0-4a4e-a013-8fa3c204e2ec"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""263db442-a373-4253-ac73-cc8a2db542df"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdb4b0b1-149c-453c-8f26-503a489bb1ff"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab602e0a-6d83-43bd-94bf-46119558ea4c"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c7463aa-8408-4172-9d00-a2aeb4cd6f77"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e09101ef-920a-485a-a435-e3fa6dee8638"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56ef1d22-fdd8-4c2b-9434-4b9836f56a12"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6eba6fd7-c7df-456d-880b-a06a13ce4db4"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdf536a4-8f7f-4850-9a0f-f418e2eb2cbc"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""939bb5e0-6779-49d9-b109-e8a139a70133"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79b1d7bb-a1f2-4c8a-9ff7-58e5df715d3f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aef0ea87-9098-45ce-ae4e-16c2054226ff"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67ae8851-4fdf-401d-9a63-c0378e368536"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_Add = m_Land.FindAction("Add", throwIfNotFound: true);
        m_Land_Minus = m_Land.FindAction("Minus", throwIfNotFound: true);
        m_Land_Movement = m_Land.FindAction("Movement", throwIfNotFound: true);
        m_Land_CameraMovement = m_Land.FindAction("Camera Movement", throwIfNotFound: true);
        m_Land_Jump = m_Land.FindAction("Jump", throwIfNotFound: true);
        m_Land_Run = m_Land.FindAction("Run", throwIfNotFound: true);
        m_Land_CursorControl = m_Land.FindAction("CursorControl", throwIfNotFound: true);
        m_Land_Pause = m_Land.FindAction("Pause", throwIfNotFound: true);
        m_Land_DialogueNext = m_Land.FindAction("DialogueNext", throwIfNotFound: true);
        m_Land_TriggerCinematic = m_Land.FindAction("TriggerCinematic", throwIfNotFound: true);
        // Menu Controls
        m_MenuControls = asset.FindActionMap("Menu Controls", throwIfNotFound: true);
        m_MenuControls_Navigate = m_MenuControls.FindAction("Navigate", throwIfNotFound: true);
        m_MenuControls_TrackedDevicePosition = m_MenuControls.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_MenuControls_TrackedDeviceOrientation = m_MenuControls.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
        m_MenuControls_Point = m_MenuControls.FindAction("Point", throwIfNotFound: true);
        m_MenuControls_Click = m_MenuControls.FindAction("Click", throwIfNotFound: true);
        m_MenuControls_Cancel = m_MenuControls.FindAction("Cancel", throwIfNotFound: true);
        m_MenuControls_MiddleClick = m_MenuControls.FindAction("MiddleClick", throwIfNotFound: true);
        m_MenuControls_RightClick = m_MenuControls.FindAction("RightClick", throwIfNotFound: true);
        m_MenuControls_ScrollWheel = m_MenuControls.FindAction("ScrollWheel", throwIfNotFound: true);
        m_MenuControls_Submit = m_MenuControls.FindAction("Submit", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Land
    private readonly InputActionMap m_Land;
    private ILandActions m_LandActionsCallbackInterface;
    private readonly InputAction m_Land_Add;
    private readonly InputAction m_Land_Minus;
    private readonly InputAction m_Land_Movement;
    private readonly InputAction m_Land_CameraMovement;
    private readonly InputAction m_Land_Jump;
    private readonly InputAction m_Land_Run;
    private readonly InputAction m_Land_CursorControl;
    private readonly InputAction m_Land_Pause;
    private readonly InputAction m_Land_DialogueNext;
    private readonly InputAction m_Land_TriggerCinematic;
    public struct LandActions
    {
        private @PlayerActions m_Wrapper;
        public LandActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Add => m_Wrapper.m_Land_Add;
        public InputAction @Minus => m_Wrapper.m_Land_Minus;
        public InputAction @Movement => m_Wrapper.m_Land_Movement;
        public InputAction @CameraMovement => m_Wrapper.m_Land_CameraMovement;
        public InputAction @Jump => m_Wrapper.m_Land_Jump;
        public InputAction @Run => m_Wrapper.m_Land_Run;
        public InputAction @CursorControl => m_Wrapper.m_Land_CursorControl;
        public InputAction @Pause => m_Wrapper.m_Land_Pause;
        public InputAction @DialogueNext => m_Wrapper.m_Land_DialogueNext;
        public InputAction @TriggerCinematic => m_Wrapper.m_Land_TriggerCinematic;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void SetCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterface != null)
            {
                @Add.started -= m_Wrapper.m_LandActionsCallbackInterface.OnAdd;
                @Add.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnAdd;
                @Add.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnAdd;
                @Minus.started -= m_Wrapper.m_LandActionsCallbackInterface.OnMinus;
                @Minus.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnMinus;
                @Minus.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnMinus;
                @Movement.started -= m_Wrapper.m_LandActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnMovement;
                @CameraMovement.started -= m_Wrapper.m_LandActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnCameraMovement;
                @Jump.started -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Run.started -= m_Wrapper.m_LandActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnRun;
                @CursorControl.started -= m_Wrapper.m_LandActionsCallbackInterface.OnCursorControl;
                @CursorControl.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnCursorControl;
                @CursorControl.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnCursorControl;
                @Pause.started -= m_Wrapper.m_LandActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnPause;
                @DialogueNext.started -= m_Wrapper.m_LandActionsCallbackInterface.OnDialogueNext;
                @DialogueNext.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnDialogueNext;
                @DialogueNext.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnDialogueNext;
                @TriggerCinematic.started -= m_Wrapper.m_LandActionsCallbackInterface.OnTriggerCinematic;
                @TriggerCinematic.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnTriggerCinematic;
                @TriggerCinematic.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnTriggerCinematic;
            }
            m_Wrapper.m_LandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Add.started += instance.OnAdd;
                @Add.performed += instance.OnAdd;
                @Add.canceled += instance.OnAdd;
                @Minus.started += instance.OnMinus;
                @Minus.performed += instance.OnMinus;
                @Minus.canceled += instance.OnMinus;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @CameraMovement.started += instance.OnCameraMovement;
                @CameraMovement.performed += instance.OnCameraMovement;
                @CameraMovement.canceled += instance.OnCameraMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @CursorControl.started += instance.OnCursorControl;
                @CursorControl.performed += instance.OnCursorControl;
                @CursorControl.canceled += instance.OnCursorControl;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @DialogueNext.started += instance.OnDialogueNext;
                @DialogueNext.performed += instance.OnDialogueNext;
                @DialogueNext.canceled += instance.OnDialogueNext;
                @TriggerCinematic.started += instance.OnTriggerCinematic;
                @TriggerCinematic.performed += instance.OnTriggerCinematic;
                @TriggerCinematic.canceled += instance.OnTriggerCinematic;
            }
        }
    }
    public LandActions @Land => new LandActions(this);

    // Menu Controls
    private readonly InputActionMap m_MenuControls;
    private IMenuControlsActions m_MenuControlsActionsCallbackInterface;
    private readonly InputAction m_MenuControls_Navigate;
    private readonly InputAction m_MenuControls_TrackedDevicePosition;
    private readonly InputAction m_MenuControls_TrackedDeviceOrientation;
    private readonly InputAction m_MenuControls_Point;
    private readonly InputAction m_MenuControls_Click;
    private readonly InputAction m_MenuControls_Cancel;
    private readonly InputAction m_MenuControls_MiddleClick;
    private readonly InputAction m_MenuControls_RightClick;
    private readonly InputAction m_MenuControls_ScrollWheel;
    private readonly InputAction m_MenuControls_Submit;
    public struct MenuControlsActions
    {
        private @PlayerActions m_Wrapper;
        public MenuControlsActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_MenuControls_Navigate;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_MenuControls_TrackedDevicePosition;
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_MenuControls_TrackedDeviceOrientation;
        public InputAction @Point => m_Wrapper.m_MenuControls_Point;
        public InputAction @Click => m_Wrapper.m_MenuControls_Click;
        public InputAction @Cancel => m_Wrapper.m_MenuControls_Cancel;
        public InputAction @MiddleClick => m_Wrapper.m_MenuControls_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_MenuControls_RightClick;
        public InputAction @ScrollWheel => m_Wrapper.m_MenuControls_ScrollWheel;
        public InputAction @Submit => m_Wrapper.m_MenuControls_Submit;
        public InputActionMap Get() { return m_Wrapper.m_MenuControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuControlsActions instance)
        {
            if (m_Wrapper.m_MenuControlsActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnNavigate;
                @TrackedDevicePosition.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnTrackedDeviceOrientation;
                @Point.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnClick;
                @Cancel.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnCancel;
                @MiddleClick.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnRightClick;
                @ScrollWheel.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnScrollWheel;
                @Submit.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnSubmit;
            }
            m_Wrapper.m_MenuControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
            }
        }
    }
    public MenuControlsActions @MenuControls => new MenuControlsActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface ILandActions
    {
        void OnAdd(InputAction.CallbackContext context);
        void OnMinus(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnCameraMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnCursorControl(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnDialogueNext(InputAction.CallbackContext context);
        void OnTriggerCinematic(InputAction.CallbackContext context);
    }
    public interface IMenuControlsActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
    }
}
