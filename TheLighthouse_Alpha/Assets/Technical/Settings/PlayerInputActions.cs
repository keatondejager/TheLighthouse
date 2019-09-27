// GENERATED AUTOMATICALLY FROM 'Assets/Technical/Settings/PlayerInputActions.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerInputActions : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""9cba90a1-2543-415e-8c3c-7b3433ca357d"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Button"",
                    ""id"": ""ff23544f-1758-463c-aa0a-edaca5fe2711"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Examine"",
                    ""type"": ""Button"",
                    ""id"": ""a2d45cda-0d7b-47e3-b932-0d2d9981eb4f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""d8d3946e-0a09-4d8f-a559-6fccece6f0b7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""946412a8-0ec3-415c-87c5-9797788b8004"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""9e43ce49-ecec-49a8-92ef-7ccb36a62c59"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD [Keyboard]"",
                    ""id"": ""7b5c1060-716a-4ec9-974f-45db3f276629"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4d471d45-70a1-4204-bb9b-9623ea88bf1a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d176923d-a713-4b4f-810b-c875007cede9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2b0fae24-7199-4cc0-94be-64147f3d8dee"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7d888345-6c89-454a-8abc-812e17664ae7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""46bf4dd3-27ff-4d92-9c0f-019d281bd434"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ed88e03-8731-4796-860e-450dc513de20"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Examine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30afa6df-1faa-4a31-b7e7-2eec7adc9d06"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Examine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""604a3b66-f2bb-4d1b-af0e-98a27d84f604"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a8eb5fd-3b82-479f-bdfb-763e33a908b7"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9bc8736-d685-4cc4-9c0a-38641c939dcb"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc3d1d9f-0093-4c74-92c4-699ef07decb7"",
                    ""path"": ""<DualShockGamepad>/touchpadButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""138fdfdd-8838-4fad-bf13-3528b76b85cd"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfc5adab-bba0-46de-a081-b52c62ec1b89"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Examining"",
            ""id"": ""bb15f039-a6fe-4aa0-a34a-2f39d6f528ce"",
            ""actions"": [
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""2f55a151-59d0-4fb6-b057-0703356e823c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""ed570922-5add-41d9-af77-93353d698946"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""c8b7a0b9-5b42-429a-991a-dceeb2de9d0a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Button"",
                    ""id"": ""37911edc-dab9-4915-8db3-fefe1b3c2359"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6b841411-973d-4e5f-b6de-446b55365903"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59b9f346-0997-468a-b1a4-b06f0a768914"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ede4221-b9fe-44ea-aafc-a0f5545fc841"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63f1a73c-4bc5-49e2-b161-35a27ac1f875"",
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
                    ""id"": ""2223c027-c792-483d-920b-c43d93dd252e"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrow Keys [Keyboard]"",
                    ""id"": ""00aef667-5fbb-43c8-959d-6e638b6af500"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""55f0f2b5-3cb3-4ab1-b5ad-5e4023703d6f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c676e58f-a26c-4555-894c-878e20f03bea"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""94d5e3c8-5052-4d7f-97d5-d0e63acdd351"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9a8ce6ba-e3a9-4e51-a40d-21ab50f144af"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""227faa15-5513-4b30-ba4a-ad9e46012f7c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Zoom [Keyboard]"",
                    ""id"": ""85611f0c-ce78-44bf-895b-bd816d582daf"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ed23bf58-13e6-4907-88f4-cd7ecd8702ef"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""931abea2-bfd1-4672-9dd8-75938efdfcbe"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bd583028-7eee-46e1-8909-0bffcca1c4cb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dfa0b59f-df25-4d0e-aa49-c09219690f57"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Inventory"",
            ""id"": ""5691c438-a571-4e20-9dab-0af0cadce322"",
            ""actions"": [
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""4d339c7c-2468-4080-9fac-a105c49b1e13"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""a24254cd-2396-420b-bd7f-01750f6f182a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d635cd8c-2b97-49cc-9783-cb7ed9b9bd43"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9770ab5-5cde-4409-9760-e4e69ba80420"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""324440d9-8ad6-403f-9461-ae6516f00808"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menus"",
            ""id"": ""e684fba5-927d-4ef8-a639-62dd1c282aed"",
            ""actions"": [
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""83877f8b-d329-4065-966c-3bf11b98f4eb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""79c5186d-8d12-4909-8da7-45779bddf3d9"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b23e34a-34a5-4e2c-b4ef-ae226ec78466"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interact"",
            ""id"": ""f43000fe-9e2d-48de-8e60-a6f108b69069"",
            ""actions"": [
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""99e38584-e144-4932-bf2f-3d2ac90e4f7c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""5dabb4c5-1abc-4b8f-90f3-40b309571b24"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f451f33d-7601-4da7-8fa7-94f46ba9e2de"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73c2a1ce-1052-48a1-8dfc-2c4ea77c8a85"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b17185c-4208-44d6-9a3f-283f37b86186"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UINavigation"",
            ""id"": ""b24691a8-80ea-4bc4-8c7f-8c61c5dcbfd8"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""42d67ef8-e82b-4cce-b096-4eda4ce3ca79"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""0e97b367-df3f-4b8d-ba31-4c630a24123e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""8c35345d-f2a6-46e8-973a-8a2935907271"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2e337c26-1fcd-49f0-8e92-49fafe6bb382"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e788a681-26d4-4112-b377-5f5aab5dcfa9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""993e8b1e-8399-4118-bb46-750c540530e7"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9df7b277-cfd5-4b0d-948e-dcc4b55ea351"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c0b1851-8b54-4404-bc8c-53c6c0c66f58"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d804cd90-a978-4ec1-8589-9b458980856d"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4045368-0b65-454f-b178-23cfea1d531b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41074891-535d-4f55-bf0e-afd41405beb7"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PuzzleControls"",
            ""id"": ""f21fb99d-233a-4810-b927-f5b1b392b013"",
            ""actions"": [
                {
                    ""name"": ""Close"",
                    ""type"": ""Button"",
                    ""id"": ""5e2948bd-6ac9-45d6-9486-8484ad95d5e3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""571faea0-6d7a-4221-887f-0144663f7960"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""370d67c8-8e4c-42e0-991f-3eb4bd1afd18"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TertiaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""b1024eda-bf49-4c07-8c73-6f8bac0ef4d6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryAxis"",
                    ""type"": ""Button"",
                    ""id"": ""24e97c30-dba1-446d-87b3-230e1fe59200"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryAxis"",
                    ""type"": ""Button"",
                    ""id"": ""f2abc25e-71cd-4b14-9f54-2c76e4c745d5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3c1350ed-cdcf-4ec9-9ccb-6e8bc14c2349"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1926ea5d-a7c8-45dc-8062-04767d52551f"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32337777-07f0-4ce3-a948-3330649b4307"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebab09ed-9066-48a9-9e03-50c52932e832"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""028111ad-4885-4412-acb9-bd8d6e75ca09"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c0907ae-c7b1-4830-a727-2c37f3591ca8"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82f003f8-19b1-40a9-8943-cdebd51c8fad"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a11f093-3c5e-4fa6-b3b3-1a456151d97b"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c42c9dc-07e7-4313-9a73-0ade3ffa7c7d"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TertiaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b58eeac-c4c5-4d1a-aca4-44ae5305f0a5"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TertiaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""645ad0f2-c937-4272-8b8d-f25197a7ec8d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD [Keyboard]"",
                    ""id"": ""ae4177bb-a646-4118-a37b-d3c37809997a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryAxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2c481133-cde1-4ccb-aef2-862b8df99b88"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""62dc86ca-45b7-4e75-ba0b-70187b4f7d03"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e9180051-ca74-4ccd-8669-d7acc94a8158"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""83335c3d-9c4c-4270-ae46-d543341d412f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""42fc8b16-57b2-421b-9444-497cc09f5840"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ArrowKeys [Keyboard]"",
                    ""id"": ""51fdf6c3-c742-4f68-8626-c9b6d00d320a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryAxis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9b60fa38-59a8-4772-8fcc-863aac57ef5f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1e24f544-e24e-4b20-b8a3-0ffae500027c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""35dfc5d1-f273-4472-8f1f-da301b74af51"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""080d6ceb-cfab-4b10-b744-bae1aa6555de"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.GetActionMap("Movement");
        m_Movement_Walk = m_Movement.GetAction("Walk");
        m_Movement_Examine = m_Movement.GetAction("Examine");
        m_Movement_Interact = m_Movement.GetAction("Interact");
        m_Movement_Inventory = m_Movement.GetAction("Inventory");
        m_Movement_Menu = m_Movement.GetAction("Menu");
        // Examining
        m_Examining = asset.GetActionMap("Examining");
        m_Examining_Exit = m_Examining.GetAction("Exit");
        m_Examining_Pause = m_Examining.GetAction("Pause");
        m_Examining_Rotate = m_Examining.GetAction("Rotate");
        m_Examining_Zoom = m_Examining.GetAction("Zoom");
        // Inventory
        m_Inventory = asset.GetActionMap("Inventory");
        m_Inventory_Exit = m_Inventory.GetAction("Exit");
        m_Inventory_Pause = m_Inventory.GetAction("Pause");
        // Menus
        m_Menus = asset.GetActionMap("Menus");
        m_Menus_Exit = m_Menus.GetAction("Exit");
        // Interact
        m_Interact = asset.GetActionMap("Interact");
        m_Interact_Exit = m_Interact.GetAction("Exit");
        m_Interact_Pause = m_Interact.GetAction("Pause");
        // UINavigation
        m_UINavigation = asset.GetActionMap("UINavigation");
        m_UINavigation_Select = m_UINavigation.GetAction("Select");
        m_UINavigation_Down = m_UINavigation.GetAction("Down");
        m_UINavigation_Up = m_UINavigation.GetAction("Up");
        // PuzzleControls
        m_PuzzleControls = asset.GetActionMap("PuzzleControls");
        m_PuzzleControls_Close = m_PuzzleControls.GetAction("Close");
        m_PuzzleControls_PrimaryButton = m_PuzzleControls.GetAction("PrimaryButton");
        m_PuzzleControls_SecondaryButton = m_PuzzleControls.GetAction("SecondaryButton");
        m_PuzzleControls_TertiaryButton = m_PuzzleControls.GetAction("TertiaryButton");
        m_PuzzleControls_PrimaryAxis = m_PuzzleControls.GetAction("PrimaryAxis");
        m_PuzzleControls_SecondaryAxis = m_PuzzleControls.GetAction("SecondaryAxis");
    }

    ~PlayerInputActions()
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Walk;
    private readonly InputAction m_Movement_Examine;
    private readonly InputAction m_Movement_Interact;
    private readonly InputAction m_Movement_Inventory;
    private readonly InputAction m_Movement_Menu;
    public struct MovementActions
    {
        private PlayerInputActions m_Wrapper;
        public MovementActions(PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Movement_Walk;
        public InputAction @Examine => m_Wrapper.m_Movement_Examine;
        public InputAction @Interact => m_Wrapper.m_Movement_Interact;
        public InputAction @Inventory => m_Wrapper.m_Movement_Inventory;
        public InputAction @Menu => m_Wrapper.m_Movement_Menu;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                Walk.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                Walk.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                Walk.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnWalk;
                Examine.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnExamine;
                Examine.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnExamine;
                Examine.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnExamine;
                Interact.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnInteract;
                Interact.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnInteract;
                Interact.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnInteract;
                Inventory.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnInventory;
                Inventory.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnInventory;
                Inventory.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnInventory;
                Menu.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMenu;
                Menu.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMenu;
                Menu.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                Walk.started += instance.OnWalk;
                Walk.performed += instance.OnWalk;
                Walk.canceled += instance.OnWalk;
                Examine.started += instance.OnExamine;
                Examine.performed += instance.OnExamine;
                Examine.canceled += instance.OnExamine;
                Interact.started += instance.OnInteract;
                Interact.performed += instance.OnInteract;
                Interact.canceled += instance.OnInteract;
                Inventory.started += instance.OnInventory;
                Inventory.performed += instance.OnInventory;
                Inventory.canceled += instance.OnInventory;
                Menu.started += instance.OnMenu;
                Menu.performed += instance.OnMenu;
                Menu.canceled += instance.OnMenu;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Examining
    private readonly InputActionMap m_Examining;
    private IExaminingActions m_ExaminingActionsCallbackInterface;
    private readonly InputAction m_Examining_Exit;
    private readonly InputAction m_Examining_Pause;
    private readonly InputAction m_Examining_Rotate;
    private readonly InputAction m_Examining_Zoom;
    public struct ExaminingActions
    {
        private PlayerInputActions m_Wrapper;
        public ExaminingActions(PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Exit => m_Wrapper.m_Examining_Exit;
        public InputAction @Pause => m_Wrapper.m_Examining_Pause;
        public InputAction @Rotate => m_Wrapper.m_Examining_Rotate;
        public InputAction @Zoom => m_Wrapper.m_Examining_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_Examining; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ExaminingActions set) { return set.Get(); }
        public void SetCallbacks(IExaminingActions instance)
        {
            if (m_Wrapper.m_ExaminingActionsCallbackInterface != null)
            {
                Exit.started -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnExit;
                Exit.performed -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnExit;
                Exit.canceled -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnExit;
                Pause.started -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnPause;
                Pause.performed -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnPause;
                Pause.canceled -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnPause;
                Rotate.started -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnRotate;
                Rotate.performed -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnRotate;
                Rotate.canceled -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnRotate;
                Zoom.started -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnZoom;
                Zoom.performed -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnZoom;
                Zoom.canceled -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_ExaminingActionsCallbackInterface = instance;
            if (instance != null)
            {
                Exit.started += instance.OnExit;
                Exit.performed += instance.OnExit;
                Exit.canceled += instance.OnExit;
                Pause.started += instance.OnPause;
                Pause.performed += instance.OnPause;
                Pause.canceled += instance.OnPause;
                Rotate.started += instance.OnRotate;
                Rotate.performed += instance.OnRotate;
                Rotate.canceled += instance.OnRotate;
                Zoom.started += instance.OnZoom;
                Zoom.performed += instance.OnZoom;
                Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public ExaminingActions @Examining => new ExaminingActions(this);

    // Inventory
    private readonly InputActionMap m_Inventory;
    private IInventoryActions m_InventoryActionsCallbackInterface;
    private readonly InputAction m_Inventory_Exit;
    private readonly InputAction m_Inventory_Pause;
    public struct InventoryActions
    {
        private PlayerInputActions m_Wrapper;
        public InventoryActions(PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Exit => m_Wrapper.m_Inventory_Exit;
        public InputAction @Pause => m_Wrapper.m_Inventory_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Inventory; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryActions set) { return set.Get(); }
        public void SetCallbacks(IInventoryActions instance)
        {
            if (m_Wrapper.m_InventoryActionsCallbackInterface != null)
            {
                Exit.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnExit;
                Exit.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnExit;
                Exit.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnExit;
                Pause.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnPause;
                Pause.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnPause;
                Pause.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_InventoryActionsCallbackInterface = instance;
            if (instance != null)
            {
                Exit.started += instance.OnExit;
                Exit.performed += instance.OnExit;
                Exit.canceled += instance.OnExit;
                Pause.started += instance.OnPause;
                Pause.performed += instance.OnPause;
                Pause.canceled += instance.OnPause;
            }
        }
    }
    public InventoryActions @Inventory => new InventoryActions(this);

    // Menus
    private readonly InputActionMap m_Menus;
    private IMenusActions m_MenusActionsCallbackInterface;
    private readonly InputAction m_Menus_Exit;
    public struct MenusActions
    {
        private PlayerInputActions m_Wrapper;
        public MenusActions(PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Exit => m_Wrapper.m_Menus_Exit;
        public InputActionMap Get() { return m_Wrapper.m_Menus; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenusActions set) { return set.Get(); }
        public void SetCallbacks(IMenusActions instance)
        {
            if (m_Wrapper.m_MenusActionsCallbackInterface != null)
            {
                Exit.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnExit;
                Exit.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnExit;
                Exit.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_MenusActionsCallbackInterface = instance;
            if (instance != null)
            {
                Exit.started += instance.OnExit;
                Exit.performed += instance.OnExit;
                Exit.canceled += instance.OnExit;
            }
        }
    }
    public MenusActions @Menus => new MenusActions(this);

    // Interact
    private readonly InputActionMap m_Interact;
    private IInteractActions m_InteractActionsCallbackInterface;
    private readonly InputAction m_Interact_Exit;
    private readonly InputAction m_Interact_Pause;
    public struct InteractActions
    {
        private PlayerInputActions m_Wrapper;
        public InteractActions(PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Exit => m_Wrapper.m_Interact_Exit;
        public InputAction @Pause => m_Wrapper.m_Interact_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Interact; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractActions set) { return set.Get(); }
        public void SetCallbacks(IInteractActions instance)
        {
            if (m_Wrapper.m_InteractActionsCallbackInterface != null)
            {
                Exit.started -= m_Wrapper.m_InteractActionsCallbackInterface.OnExit;
                Exit.performed -= m_Wrapper.m_InteractActionsCallbackInterface.OnExit;
                Exit.canceled -= m_Wrapper.m_InteractActionsCallbackInterface.OnExit;
                Pause.started -= m_Wrapper.m_InteractActionsCallbackInterface.OnPause;
                Pause.performed -= m_Wrapper.m_InteractActionsCallbackInterface.OnPause;
                Pause.canceled -= m_Wrapper.m_InteractActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_InteractActionsCallbackInterface = instance;
            if (instance != null)
            {
                Exit.started += instance.OnExit;
                Exit.performed += instance.OnExit;
                Exit.canceled += instance.OnExit;
                Pause.started += instance.OnPause;
                Pause.performed += instance.OnPause;
                Pause.canceled += instance.OnPause;
            }
        }
    }
    public InteractActions @Interact => new InteractActions(this);

    // UINavigation
    private readonly InputActionMap m_UINavigation;
    private IUINavigationActions m_UINavigationActionsCallbackInterface;
    private readonly InputAction m_UINavigation_Select;
    private readonly InputAction m_UINavigation_Down;
    private readonly InputAction m_UINavigation_Up;
    public struct UINavigationActions
    {
        private PlayerInputActions m_Wrapper;
        public UINavigationActions(PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_UINavigation_Select;
        public InputAction @Down => m_Wrapper.m_UINavigation_Down;
        public InputAction @Up => m_Wrapper.m_UINavigation_Up;
        public InputActionMap Get() { return m_Wrapper.m_UINavigation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UINavigationActions set) { return set.Get(); }
        public void SetCallbacks(IUINavigationActions instance)
        {
            if (m_Wrapper.m_UINavigationActionsCallbackInterface != null)
            {
                Select.started -= m_Wrapper.m_UINavigationActionsCallbackInterface.OnSelect;
                Select.performed -= m_Wrapper.m_UINavigationActionsCallbackInterface.OnSelect;
                Select.canceled -= m_Wrapper.m_UINavigationActionsCallbackInterface.OnSelect;
                Down.started -= m_Wrapper.m_UINavigationActionsCallbackInterface.OnDown;
                Down.performed -= m_Wrapper.m_UINavigationActionsCallbackInterface.OnDown;
                Down.canceled -= m_Wrapper.m_UINavigationActionsCallbackInterface.OnDown;
                Up.started -= m_Wrapper.m_UINavigationActionsCallbackInterface.OnUp;
                Up.performed -= m_Wrapper.m_UINavigationActionsCallbackInterface.OnUp;
                Up.canceled -= m_Wrapper.m_UINavigationActionsCallbackInterface.OnUp;
            }
            m_Wrapper.m_UINavigationActionsCallbackInterface = instance;
            if (instance != null)
            {
                Select.started += instance.OnSelect;
                Select.performed += instance.OnSelect;
                Select.canceled += instance.OnSelect;
                Down.started += instance.OnDown;
                Down.performed += instance.OnDown;
                Down.canceled += instance.OnDown;
                Up.started += instance.OnUp;
                Up.performed += instance.OnUp;
                Up.canceled += instance.OnUp;
            }
        }
    }
    public UINavigationActions @UINavigation => new UINavigationActions(this);

    // PuzzleControls
    private readonly InputActionMap m_PuzzleControls;
    private IPuzzleControlsActions m_PuzzleControlsActionsCallbackInterface;
    private readonly InputAction m_PuzzleControls_Close;
    private readonly InputAction m_PuzzleControls_PrimaryButton;
    private readonly InputAction m_PuzzleControls_SecondaryButton;
    private readonly InputAction m_PuzzleControls_TertiaryButton;
    private readonly InputAction m_PuzzleControls_PrimaryAxis;
    private readonly InputAction m_PuzzleControls_SecondaryAxis;
    public struct PuzzleControlsActions
    {
        private PlayerInputActions m_Wrapper;
        public PuzzleControlsActions(PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Close => m_Wrapper.m_PuzzleControls_Close;
        public InputAction @PrimaryButton => m_Wrapper.m_PuzzleControls_PrimaryButton;
        public InputAction @SecondaryButton => m_Wrapper.m_PuzzleControls_SecondaryButton;
        public InputAction @TertiaryButton => m_Wrapper.m_PuzzleControls_TertiaryButton;
        public InputAction @PrimaryAxis => m_Wrapper.m_PuzzleControls_PrimaryAxis;
        public InputAction @SecondaryAxis => m_Wrapper.m_PuzzleControls_SecondaryAxis;
        public InputActionMap Get() { return m_Wrapper.m_PuzzleControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PuzzleControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPuzzleControlsActions instance)
        {
            if (m_Wrapper.m_PuzzleControlsActionsCallbackInterface != null)
            {
                Close.started -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnClose;
                Close.performed -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnClose;
                Close.canceled -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnClose;
                PrimaryButton.started -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnPrimaryButton;
                PrimaryButton.performed -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnPrimaryButton;
                PrimaryButton.canceled -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnPrimaryButton;
                SecondaryButton.started -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnSecondaryButton;
                SecondaryButton.performed -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnSecondaryButton;
                SecondaryButton.canceled -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnSecondaryButton;
                TertiaryButton.started -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnTertiaryButton;
                TertiaryButton.performed -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnTertiaryButton;
                TertiaryButton.canceled -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnTertiaryButton;
                PrimaryAxis.started -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnPrimaryAxis;
                PrimaryAxis.performed -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnPrimaryAxis;
                PrimaryAxis.canceled -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnPrimaryAxis;
                SecondaryAxis.started -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnSecondaryAxis;
                SecondaryAxis.performed -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnSecondaryAxis;
                SecondaryAxis.canceled -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnSecondaryAxis;
            }
            m_Wrapper.m_PuzzleControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                Close.started += instance.OnClose;
                Close.performed += instance.OnClose;
                Close.canceled += instance.OnClose;
                PrimaryButton.started += instance.OnPrimaryButton;
                PrimaryButton.performed += instance.OnPrimaryButton;
                PrimaryButton.canceled += instance.OnPrimaryButton;
                SecondaryButton.started += instance.OnSecondaryButton;
                SecondaryButton.performed += instance.OnSecondaryButton;
                SecondaryButton.canceled += instance.OnSecondaryButton;
                TertiaryButton.started += instance.OnTertiaryButton;
                TertiaryButton.performed += instance.OnTertiaryButton;
                TertiaryButton.canceled += instance.OnTertiaryButton;
                PrimaryAxis.started += instance.OnPrimaryAxis;
                PrimaryAxis.performed += instance.OnPrimaryAxis;
                PrimaryAxis.canceled += instance.OnPrimaryAxis;
                SecondaryAxis.started += instance.OnSecondaryAxis;
                SecondaryAxis.performed += instance.OnSecondaryAxis;
                SecondaryAxis.canceled += instance.OnSecondaryAxis;
            }
        }
    }
    public PuzzleControlsActions @PuzzleControls => new PuzzleControlsActions(this);
    public interface IMovementActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnExamine(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
    public interface IExaminingActions
    {
        void OnExit(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
    public interface IInventoryActions
    {
        void OnExit(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IMenusActions
    {
        void OnExit(InputAction.CallbackContext context);
    }
    public interface IInteractActions
    {
        void OnExit(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IUINavigationActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
    }
    public interface IPuzzleControlsActions
    {
        void OnClose(InputAction.CallbackContext context);
        void OnPrimaryButton(InputAction.CallbackContext context);
        void OnSecondaryButton(InputAction.CallbackContext context);
        void OnTertiaryButton(InputAction.CallbackContext context);
        void OnPrimaryAxis(InputAction.CallbackContext context);
        void OnSecondaryAxis(InputAction.CallbackContext context);
    }
}
