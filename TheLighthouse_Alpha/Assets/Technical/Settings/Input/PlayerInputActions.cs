// GENERATED AUTOMATICALLY FROM 'Assets/Technical/Settings/Input/PlayerInputActions.inputactions'

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
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Button"",
                    ""id"": ""1bb32f04-4b36-4656-8085-86daf6ed6f29"",
                    ""expectedControlType"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD [Keyboard]"",
                    ""id"": ""7b5c1060-716a-4ec9-974f-45db3f276629"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
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
                    ""id"": ""23dfdf8d-ab78-4df0-bb8f-092be0b4f987"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c34bec0b-d3a5-4f0a-bc92-40dcee9f0e4f"",
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
                    ""id"": ""e70264d2-3025-4650-a117-56dacdeed897"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
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
                    ""id"": ""5746f7e7-a9c7-41e0-8079-4ae74d82648b"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
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
                    ""id"": ""0e9d781e-7361-4eb9-af64-1f7873bea071"",
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
                    ""id"": ""bfc5adab-bba0-46de-a081-b52c62ec1b89"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f87e3d7e-41ed-4517-8934-4d88e5c9b39d"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ee62315-4901-4d76-8840-e7d9267eb1ae"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d8b9d22-6e3c-414b-a088-52bc92f68979"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81e426f5-87c1-4cd1-a6e9-cc5e11136880"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrows [Keyboard]"",
                    ""id"": ""5be70b87-e31f-4a08-a598-275209d0c29f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f674501c-c278-4d17-a4f3-16a66f348ffa"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0d6f8bc9-0d17-4846-9b14-48e338fbdc74"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bf27d34e-c3b5-45fa-94e5-ed7ae7cb2050"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0fc14c0f-c3ad-4813-9699-42136ae47fb5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c63f28f1-60fa-4118-aa9b-c64e3e305124"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
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
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Button"",
                    ""id"": ""37911edc-dab9-4915-8db3-fefe1b3c2359"",
                    ""expectedControlType"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""95a21f86-6f2d-468a-9e4c-3cde54db413d"",
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
                    ""id"": ""95f2e1dc-5109-4b3b-87e3-6351e2173af6"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
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
                    ""id"": ""0175528c-2978-403a-8fda-73a31436f075"",
                    ""path"": ""<DualShockGamepad>/start"",
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
                    ""id"": ""67dbd8d2-be12-49ed-85fc-8d7b3f2d2708"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
                },
                {
                    ""name"": """",
                    ""id"": ""5aa829c3-4f4e-4c0d-909d-feb3d9511325"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f480c526-8d2f-47d3-afe1-db92196eebf1"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0a4988e-09b5-450c-a136-6c07df13f6ea"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe8d8956-81a5-4184-81de-ddf46093d1e9"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
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
            ""bindings"": []
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
                    ""id"": ""478a939b-1a9a-4b7a-b0f8-61abb9780b0f"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""92aedd09-8938-4ce7-8444-9a0fd0b3dc65"",
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
                    ""id"": ""d3265c83-8bbf-432b-9c1b-1b3d571c8f55"",
                    ""path"": ""<DualShockGamepad>/start"",
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
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""946fc497-ce04-4e71-9cc6-fb2399fe004c"",
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
                    ""id"": ""7b5499ad-4629-40a1-82d5-84bedb61bd98"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
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
                    ""id"": ""e7bf8b6d-c5fe-4db3-a7ed-b0d5e6e0f3da"",
                    ""path"": ""<DualShockGamepad>/dpad/up"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""57bba86a-6053-4519-9367-c19d1af66c9d"",
                    ""path"": ""<DualShockGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""621008aa-dfb1-4b05-9e72-60aceb54abf7"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64189085-4f1d-4edd-99d8-92f12a3efd26"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1de4f93a-bfc4-45bb-b920-f01d9094b88e"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
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
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryAxis"",
                    ""type"": ""Button"",
                    ""id"": ""f2abc25e-71cd-4b14-9f54-2c76e4c745d5"",
                    ""expectedControlType"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftGrab"",
                    ""type"": ""Button"",
                    ""id"": ""9c9285d3-a226-4eff-a90f-f8f3d3e8750e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightGrab"",
                    ""type"": ""Button"",
                    ""id"": ""771d6ae9-0ac5-453d-bd1c-b1b3124f2456"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightToggle"",
                    ""type"": ""Button"",
                    ""id"": ""b5102d3d-c869-425b-8bfa-f8712fdf4f17"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftToggle"",
                    ""type"": ""Button"",
                    ""id"": ""75789c5a-cfbc-4857-a943-684e9281a8b1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DigitUp"",
                    ""type"": ""Button"",
                    ""id"": ""f6fddd70-e84a-4e73-8c28-a2b95a7a7789"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DigitDown"",
                    ""type"": ""Button"",
                    ""id"": ""19c844cf-56a6-4133-ad15-b308d099f195"",
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
                    ""id"": ""2e988738-37da-4be0-bf28-2668c741d3f8"",
                    ""path"": ""<DualShockGamepad>/touchpadButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20fc51e1-cc01-4f1e-992c-69abcf3bee30"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
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
                    ""id"": ""41032272-9c8e-4a8e-9f7a-965c91fdb261"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
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
                    ""id"": ""15068f79-9ba2-4e7a-928c-beac2da10276"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
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
                    ""id"": ""6574238a-b384-486e-bf0c-f638d4b5e3db"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
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
                    ""id"": ""6b07d46a-8d35-4ca0-b943-3095de28538b"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
                },
                {
                    ""name"": """",
                    ""id"": ""71c424a6-e56f-45b0-bcc1-df8a5ce29543"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af0a3951-bf35-4229-81a9-7860f93ac068"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftGrab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7e44a59-f166-4b2e-9a1a-95af4f98420f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftGrab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6270f18f-9a8c-47b0-a41d-1060d0a3ee34"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftGrab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32a849c6-1e45-48f7-a2b7-2574432c4487"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftGrab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6fa2e86-2fd0-4991-a84d-da8553b189e6"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightGrab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a74db87-248f-4512-b46e-504d32288a62"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightGrab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa99ce49-e629-4f16-8dde-66ee3e53930b"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightGrab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0258ed68-e815-4ddf-81e4-76499ac77b95"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightGrab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f5fe618-f090-43d8-a00f-59eac6aef16e"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84091917-2451-4311-98f4-52916700d790"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adceb1f2-74ca-44c7-8186-71a2ad8f9555"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1075d479-ee84-4957-9455-79cd00b9c388"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""180419d2-7ad6-4ed3-abee-fc3c26842f4f"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1a6891b-9e1e-4708-a1bf-7a4c53d62e06"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8368a373-975d-4897-ac31-009f37e62f46"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80c67415-5688-497b-8cb9-d75951f70be2"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46a71efe-5b97-425a-9bc8-cdb7014e9c14"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DigitUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""025083d1-8519-451f-b6e3-6890de37fa2c"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DigitUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3aa67cf3-07e7-49b5-b3a7-a3ad7dd8e651"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DigitUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03c1f1a7-67d1-4b0b-889d-f8e8a256e337"",
                    ""path"": ""<DualShockGamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DigitUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""898ff5e7-2e47-4f77-8ba9-2c98be441e8f"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DigitDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7410615-bf26-4eef-8add-4d04925d6d2d"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DigitDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce748143-0c11-4672-ac5d-1b9ce057809d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DigitDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef018f07-ad58-4c0e-aa86-0f061d207664"",
                    ""path"": ""<DualShockGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DigitDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""OptionsMenu"",
            ""id"": ""bf07648f-b30c-4a83-8d0a-3fc2652577b0"",
            ""actions"": [
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""572f3be0-9f4b-4e0d-8844-6b45d44da26f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Close"",
                    ""type"": ""Button"",
                    ""id"": ""db152b17-8896-44be-a77f-cc2a65358979"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""f45f804e-9395-460c-a121-a76cc583ac0e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""0495e77d-fa09-4e9f-bfc6-35b029234128"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""b9cfc037-5384-49d4-8701-4c124ce63b8c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""5af45a3d-3412-40b2-9d7d-6b41c8afc02f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Save"",
                    ""type"": ""Button"",
                    ""id"": ""75138636-0617-4876-ba4a-adc65aec64c7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Defaults"",
                    ""type"": ""Button"",
                    ""id"": ""71b4b406-f91d-4d1c-8730-d3be4c03ab39"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Next"",
                    ""type"": ""Button"",
                    ""id"": ""9cd8d93a-1a5c-4bc5-8467-623bb4f0dc87"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Previous"",
                    ""type"": ""Button"",
                    ""id"": ""f4f6ec55-0f8d-42b8-b1fc-1d565d8ece39"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eca27435-6f58-4a33-ad13-c344ba9eaa0e"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""371ac93d-c426-4733-8a66-02cbc6c814fa"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45491fe7-5892-4ec5-b7d1-03e850aca378"",
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
                    ""id"": ""8be71448-2149-4770-bf44-f24b8b95b47b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51d60626-2244-49bb-87b4-2a895f5f0cf1"",
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
                    ""id"": ""9821a1e9-5402-4e9c-b0b0-905aec7dfd50"",
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
                    ""id"": ""554302b8-4dae-4c96-909e-292196a1ef36"",
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
                    ""id"": ""ccbe21e4-9979-429a-895e-293dc5037460"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0fcf8b95-d1c9-4035-9fdd-68ab4ad4d5d4"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ad085a0-db36-4716-b402-fe7b8f606344"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d410bbe-4868-438f-8922-1b33a159b04f"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4541c008-8dd2-4c76-804c-a15b2b61572a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc2ae0fb-408c-4bc0-b93c-e4ec1cae8efa"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Save"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9cb9f8a-c5be-4692-8c06-6922895736b4"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Save"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2e4dada-a53b-4ec5-a71d-8ba9e51a6af2"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Defaults"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1061aec6-fa3c-4919-b7f2-1e3ee9199123"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Defaults"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""371eec9c-0557-4829-a1c2-2e207e5470ca"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab386f32-0a9b-42b6-9ac6-5b46ef5adebb"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af6484e2-881f-4a1f-967d-e8cf37bd0175"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3611e890-26f5-4522-a4c2-905bd4a7f574"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        m_Movement_Look = m_Movement.GetAction("Look");
        // Examining
        m_Examining = asset.GetActionMap("Examining");
        m_Examining_Exit = m_Examining.GetAction("Exit");
        m_Examining_Pause = m_Examining.GetAction("Pause");
        m_Examining_Rotate = m_Examining.GetAction("Rotate");
        m_Examining_Zoom = m_Examining.GetAction("Zoom");
        m_Examining_Reset = m_Examining.GetAction("Reset");
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
        m_UINavigation_Cancel = m_UINavigation.GetAction("Cancel");
        // PuzzleControls
        m_PuzzleControls = asset.GetActionMap("PuzzleControls");
        m_PuzzleControls_Close = m_PuzzleControls.GetAction("Close");
        m_PuzzleControls_PrimaryButton = m_PuzzleControls.GetAction("PrimaryButton");
        m_PuzzleControls_SecondaryButton = m_PuzzleControls.GetAction("SecondaryButton");
        m_PuzzleControls_TertiaryButton = m_PuzzleControls.GetAction("TertiaryButton");
        m_PuzzleControls_PrimaryAxis = m_PuzzleControls.GetAction("PrimaryAxis");
        m_PuzzleControls_SecondaryAxis = m_PuzzleControls.GetAction("SecondaryAxis");
        m_PuzzleControls_LeftGrab = m_PuzzleControls.GetAction("LeftGrab");
        m_PuzzleControls_RightGrab = m_PuzzleControls.GetAction("RightGrab");
        m_PuzzleControls_RightToggle = m_PuzzleControls.GetAction("RightToggle");
        m_PuzzleControls_LeftToggle = m_PuzzleControls.GetAction("LeftToggle");
        m_PuzzleControls_DigitUp = m_PuzzleControls.GetAction("DigitUp");
        m_PuzzleControls_DigitDown = m_PuzzleControls.GetAction("DigitDown");
        // OptionsMenu
        m_OptionsMenu = asset.GetActionMap("OptionsMenu");
        m_OptionsMenu_Back = m_OptionsMenu.GetAction("Back");
        m_OptionsMenu_Close = m_OptionsMenu.GetAction("Close");
        m_OptionsMenu_Up = m_OptionsMenu.GetAction("Up");
        m_OptionsMenu_Down = m_OptionsMenu.GetAction("Down");
        m_OptionsMenu_Right = m_OptionsMenu.GetAction("Right");
        m_OptionsMenu_Left = m_OptionsMenu.GetAction("Left");
        m_OptionsMenu_Save = m_OptionsMenu.GetAction("Save");
        m_OptionsMenu_Defaults = m_OptionsMenu.GetAction("Defaults");
        m_OptionsMenu_Next = m_OptionsMenu.GetAction("Next");
        m_OptionsMenu_Previous = m_OptionsMenu.GetAction("Previous");
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
    private readonly InputAction m_Movement_Look;
    public struct MovementActions
    {
        private PlayerInputActions m_Wrapper;
        public MovementActions(PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Movement_Walk;
        public InputAction @Examine => m_Wrapper.m_Movement_Examine;
        public InputAction @Interact => m_Wrapper.m_Movement_Interact;
        public InputAction @Inventory => m_Wrapper.m_Movement_Inventory;
        public InputAction @Menu => m_Wrapper.m_Movement_Menu;
        public InputAction @Look => m_Wrapper.m_Movement_Look;
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
                Look.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnLook;
                Look.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnLook;
                Look.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnLook;
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
                Look.started += instance.OnLook;
                Look.performed += instance.OnLook;
                Look.canceled += instance.OnLook;
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
    private readonly InputAction m_Examining_Reset;
    public struct ExaminingActions
    {
        private PlayerInputActions m_Wrapper;
        public ExaminingActions(PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Exit => m_Wrapper.m_Examining_Exit;
        public InputAction @Pause => m_Wrapper.m_Examining_Pause;
        public InputAction @Rotate => m_Wrapper.m_Examining_Rotate;
        public InputAction @Zoom => m_Wrapper.m_Examining_Zoom;
        public InputAction @Reset => m_Wrapper.m_Examining_Reset;
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
                Reset.started -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnReset;
                Reset.performed -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnReset;
                Reset.canceled -= m_Wrapper.m_ExaminingActionsCallbackInterface.OnReset;
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
                Reset.started += instance.OnReset;
                Reset.performed += instance.OnReset;
                Reset.canceled += instance.OnReset;
            }
        }
    }
    public ExaminingActions @Examining => new ExaminingActions(this);

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
    private readonly InputAction m_UINavigation_Cancel;
    public struct UINavigationActions
    {
        private PlayerInputActions m_Wrapper;
        public UINavigationActions(PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_UINavigation_Select;
        public InputAction @Down => m_Wrapper.m_UINavigation_Down;
        public InputAction @Up => m_Wrapper.m_UINavigation_Up;
        public InputAction @Cancel => m_Wrapper.m_UINavigation_Cancel;
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
                Cancel.started -= m_Wrapper.m_UINavigationActionsCallbackInterface.OnCancel;
                Cancel.performed -= m_Wrapper.m_UINavigationActionsCallbackInterface.OnCancel;
                Cancel.canceled -= m_Wrapper.m_UINavigationActionsCallbackInterface.OnCancel;
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
                Cancel.started += instance.OnCancel;
                Cancel.performed += instance.OnCancel;
                Cancel.canceled += instance.OnCancel;
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
    private readonly InputAction m_PuzzleControls_LeftGrab;
    private readonly InputAction m_PuzzleControls_RightGrab;
    private readonly InputAction m_PuzzleControls_RightToggle;
    private readonly InputAction m_PuzzleControls_LeftToggle;
    private readonly InputAction m_PuzzleControls_DigitUp;
    private readonly InputAction m_PuzzleControls_DigitDown;
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
        public InputAction @LeftGrab => m_Wrapper.m_PuzzleControls_LeftGrab;
        public InputAction @RightGrab => m_Wrapper.m_PuzzleControls_RightGrab;
        public InputAction @RightToggle => m_Wrapper.m_PuzzleControls_RightToggle;
        public InputAction @LeftToggle => m_Wrapper.m_PuzzleControls_LeftToggle;
        public InputAction @DigitUp => m_Wrapper.m_PuzzleControls_DigitUp;
        public InputAction @DigitDown => m_Wrapper.m_PuzzleControls_DigitDown;
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
                LeftGrab.started -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnLeftGrab;
                LeftGrab.performed -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnLeftGrab;
                LeftGrab.canceled -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnLeftGrab;
                RightGrab.started -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnRightGrab;
                RightGrab.performed -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnRightGrab;
                RightGrab.canceled -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnRightGrab;
                RightToggle.started -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnRightToggle;
                RightToggle.performed -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnRightToggle;
                RightToggle.canceled -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnRightToggle;
                LeftToggle.started -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnLeftToggle;
                LeftToggle.performed -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnLeftToggle;
                LeftToggle.canceled -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnLeftToggle;
                DigitUp.started -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnDigitUp;
                DigitUp.performed -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnDigitUp;
                DigitUp.canceled -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnDigitUp;
                DigitDown.started -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnDigitDown;
                DigitDown.performed -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnDigitDown;
                DigitDown.canceled -= m_Wrapper.m_PuzzleControlsActionsCallbackInterface.OnDigitDown;
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
                LeftGrab.started += instance.OnLeftGrab;
                LeftGrab.performed += instance.OnLeftGrab;
                LeftGrab.canceled += instance.OnLeftGrab;
                RightGrab.started += instance.OnRightGrab;
                RightGrab.performed += instance.OnRightGrab;
                RightGrab.canceled += instance.OnRightGrab;
                RightToggle.started += instance.OnRightToggle;
                RightToggle.performed += instance.OnRightToggle;
                RightToggle.canceled += instance.OnRightToggle;
                LeftToggle.started += instance.OnLeftToggle;
                LeftToggle.performed += instance.OnLeftToggle;
                LeftToggle.canceled += instance.OnLeftToggle;
                DigitUp.started += instance.OnDigitUp;
                DigitUp.performed += instance.OnDigitUp;
                DigitUp.canceled += instance.OnDigitUp;
                DigitDown.started += instance.OnDigitDown;
                DigitDown.performed += instance.OnDigitDown;
                DigitDown.canceled += instance.OnDigitDown;
            }
        }
    }
    public PuzzleControlsActions @PuzzleControls => new PuzzleControlsActions(this);

    // OptionsMenu
    private readonly InputActionMap m_OptionsMenu;
    private IOptionsMenuActions m_OptionsMenuActionsCallbackInterface;
    private readonly InputAction m_OptionsMenu_Back;
    private readonly InputAction m_OptionsMenu_Close;
    private readonly InputAction m_OptionsMenu_Up;
    private readonly InputAction m_OptionsMenu_Down;
    private readonly InputAction m_OptionsMenu_Right;
    private readonly InputAction m_OptionsMenu_Left;
    private readonly InputAction m_OptionsMenu_Save;
    private readonly InputAction m_OptionsMenu_Defaults;
    private readonly InputAction m_OptionsMenu_Next;
    private readonly InputAction m_OptionsMenu_Previous;
    public struct OptionsMenuActions
    {
        private PlayerInputActions m_Wrapper;
        public OptionsMenuActions(PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Back => m_Wrapper.m_OptionsMenu_Back;
        public InputAction @Close => m_Wrapper.m_OptionsMenu_Close;
        public InputAction @Up => m_Wrapper.m_OptionsMenu_Up;
        public InputAction @Down => m_Wrapper.m_OptionsMenu_Down;
        public InputAction @Right => m_Wrapper.m_OptionsMenu_Right;
        public InputAction @Left => m_Wrapper.m_OptionsMenu_Left;
        public InputAction @Save => m_Wrapper.m_OptionsMenu_Save;
        public InputAction @Defaults => m_Wrapper.m_OptionsMenu_Defaults;
        public InputAction @Next => m_Wrapper.m_OptionsMenu_Next;
        public InputAction @Previous => m_Wrapper.m_OptionsMenu_Previous;
        public InputActionMap Get() { return m_Wrapper.m_OptionsMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OptionsMenuActions set) { return set.Get(); }
        public void SetCallbacks(IOptionsMenuActions instance)
        {
            if (m_Wrapper.m_OptionsMenuActionsCallbackInterface != null)
            {
                Back.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnBack;
                Back.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnBack;
                Back.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnBack;
                Close.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnClose;
                Close.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnClose;
                Close.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnClose;
                Up.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnUp;
                Up.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnUp;
                Up.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnUp;
                Down.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnDown;
                Down.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnDown;
                Down.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnDown;
                Right.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnRight;
                Right.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnRight;
                Right.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnRight;
                Left.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnLeft;
                Left.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnLeft;
                Left.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnLeft;
                Save.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnSave;
                Save.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnSave;
                Save.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnSave;
                Defaults.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnDefaults;
                Defaults.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnDefaults;
                Defaults.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnDefaults;
                Next.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNext;
                Next.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNext;
                Next.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNext;
                Previous.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnPrevious;
                Previous.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnPrevious;
                Previous.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnPrevious;
            }
            m_Wrapper.m_OptionsMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                Back.started += instance.OnBack;
                Back.performed += instance.OnBack;
                Back.canceled += instance.OnBack;
                Close.started += instance.OnClose;
                Close.performed += instance.OnClose;
                Close.canceled += instance.OnClose;
                Up.started += instance.OnUp;
                Up.performed += instance.OnUp;
                Up.canceled += instance.OnUp;
                Down.started += instance.OnDown;
                Down.performed += instance.OnDown;
                Down.canceled += instance.OnDown;
                Right.started += instance.OnRight;
                Right.performed += instance.OnRight;
                Right.canceled += instance.OnRight;
                Left.started += instance.OnLeft;
                Left.performed += instance.OnLeft;
                Left.canceled += instance.OnLeft;
                Save.started += instance.OnSave;
                Save.performed += instance.OnSave;
                Save.canceled += instance.OnSave;
                Defaults.started += instance.OnDefaults;
                Defaults.performed += instance.OnDefaults;
                Defaults.canceled += instance.OnDefaults;
                Next.started += instance.OnNext;
                Next.performed += instance.OnNext;
                Next.canceled += instance.OnNext;
                Previous.started += instance.OnPrevious;
                Previous.performed += instance.OnPrevious;
                Previous.canceled += instance.OnPrevious;
            }
        }
    }
    public OptionsMenuActions @OptionsMenu => new OptionsMenuActions(this);
    public interface IMovementActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnExamine(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IExaminingActions
    {
        void OnExit(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
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
        void OnCancel(InputAction.CallbackContext context);
    }
    public interface IPuzzleControlsActions
    {
        void OnClose(InputAction.CallbackContext context);
        void OnPrimaryButton(InputAction.CallbackContext context);
        void OnSecondaryButton(InputAction.CallbackContext context);
        void OnTertiaryButton(InputAction.CallbackContext context);
        void OnPrimaryAxis(InputAction.CallbackContext context);
        void OnSecondaryAxis(InputAction.CallbackContext context);
        void OnLeftGrab(InputAction.CallbackContext context);
        void OnRightGrab(InputAction.CallbackContext context);
        void OnRightToggle(InputAction.CallbackContext context);
        void OnLeftToggle(InputAction.CallbackContext context);
        void OnDigitUp(InputAction.CallbackContext context);
        void OnDigitDown(InputAction.CallbackContext context);
    }
    public interface IOptionsMenuActions
    {
        void OnBack(InputAction.CallbackContext context);
        void OnClose(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnSave(InputAction.CallbackContext context);
        void OnDefaults(InputAction.CallbackContext context);
        void OnNext(InputAction.CallbackContext context);
        void OnPrevious(InputAction.CallbackContext context);
    }
}
