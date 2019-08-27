// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Input/PlayerControls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""646b3f54-c703-46c8-84ec-f689250fc634"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""bb3d1441-3b21-4f0e-8de9-222c2fc81edc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Examine"",
                    ""type"": ""Button"",
                    ""id"": ""20f941e9-086d-45c6-8d56-500c87a54137"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Search"",
                    ""type"": ""Button"",
                    ""id"": ""56c8cd65-d34e-4a2d-aeac-c446b7a44cfd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""a7a4b9cf-a8e8-453c-aa47-8c507c78e002"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""26c5a989-72c2-417e-8396-52504dfcf679"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d2bce247-efff-48c2-ab13-caecaa4f2977"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bac6fba0-1bbe-4a14-8d04-725fe6f72a61"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f6a57e6-f69e-4448-b6e8-28904f9e8177"",
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
                    ""id"": ""b3adfa60-bf26-4db6-bbf1-04f6f6db4326"",
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
                    ""id"": ""b47b45f5-8e43-473c-85f9-6b7d17314100"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Search"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a97bdac-f79e-4fe2-870e-5eb8bdaf05f1"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Search"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60cd6cca-138b-4075-aa3e-14fd0ec2e452"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""KeyboardInput"",
                    ""id"": ""a8f2509f-836f-41b6-8629-972a3ef132d0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a1b34085-e02e-4555-b27e-29ea643cf47c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3bb99961-1c0a-488d-803b-e0d7ac66c760"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d415340b-808b-4b2a-b450-decad343b963"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d0205425-101e-4325-975e-7928f834d3ee"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bce8eeaf-23af-4a3f-a72a-ff4fd137155f"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""9636a8fe-96a3-4487-8ee1-89a3beacc025"",
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
                    ""id"": ""d156b46e-206e-43be-9940-e97c24b3433a"",
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
                    ""id"": ""da745dc2-7a33-40ad-9d34-5a13e9f7b50c"",
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
                    ""id"": ""5b96ad18-7f70-43a4-9a30-348e267da8cd"",
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
                    ""id"": ""e9700930-9c23-4f46-8870-2d14d525454e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Examine"",
            ""id"": ""c275b006-1151-4cdc-8930-619a065b4a86"",
            ""actions"": [
                {
                    ""name"": ""Close"",
                    ""type"": ""Button"",
                    ""id"": ""b1c4883d-454e-4084-8fbc-09917e8ea74a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Button"",
                    ""id"": ""6f6217f7-f581-44f3-9126-ab6071c03285"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""1cb66035-ff75-4db6-86d1-c0b2d03c4131"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ef8bfd5e-4327-4df4-a194-2b07c367b1b0"",
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
                    ""id"": ""a777ebeb-1f71-46d9-935e-0a4f07d88009"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Triggers"",
                    ""id"": ""cefe2803-83c6-404e-8b8a-6caec2745677"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8e00fe32-72ac-4ca3-91a8-176ad4df9d64"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1a0e8901-7360-478b-a61c-47e170ae0ce2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fd321b2a-0882-4ae6-ac24-8ac194411155"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4224dd1-7acd-45db-919c-26cd083c2450"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f380362d-cf67-4819-8459-ad8567e5b45d"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""0838e9bb-cd38-43ed-85aa-902a85011397"",
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
                    ""id"": ""afc51472-818a-4328-97d0-d327cbf67943"",
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
                    ""id"": ""8c183cad-9c03-42e1-b731-3d3189e08a27"",
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
                    ""id"": ""21f1cfa0-9f02-452e-b6c2-3fae34c686f3"",
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
                    ""id"": ""e08e566d-3d65-4256-b1ec-82b8ebeaa1ad"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Search"",
            ""id"": ""fbe40068-0660-4635-9c57-816a1dc820bd"",
            ""actions"": [
                {
                    ""name"": ""Close"",
                    ""type"": ""Button"",
                    ""id"": ""139ea58e-e041-4bf4-8248-6c1cf0b9abaa"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Button"",
                    ""id"": ""29750775-206d-45fa-8d7f-74f82406f49d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""702db2d9-a09e-45a5-b091-427f0051cab1"",
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
                    ""id"": ""42b23f4e-8f7a-4532-be8c-57b308057799"",
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
                    ""id"": ""494a1391-c255-4731-9896-19b5a904eab7"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2da05475-19ac-439a-ab75-eef7ae05e1ae"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""84c2a250-2c28-4779-ac36-e86e78730519"",
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
                    ""id"": ""088be43b-fd9c-45f0-8306-c803984d0c2d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""562b77fe-fdbe-4e6c-842b-e568850a0113"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d8978b6c-1fb1-4b06-b886-3f317cde53b5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b5160348-4f2b-46ee-a0e0-1326c30219f1"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""02f44d73-a37c-4f5f-8a81-928ba8a71d4a"",
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
                    ""id"": ""0762487e-8549-47f2-92a0-f104e2861737"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dc522e6a-58eb-44d9-9df5-b077bf59fd13"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""85fb4de8-33b6-4457-8c38-b93f29dc9536"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2d815a34-7457-42fb-bd1c-eabf85317f13"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
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
        m_Movement_Jump = m_Movement.GetAction("Jump");
        m_Movement_Examine = m_Movement.GetAction("Examine");
        m_Movement_Search = m_Movement.GetAction("Search");
        m_Movement_Move = m_Movement.GetAction("Move");
        m_Movement_Rotate = m_Movement.GetAction("Rotate");
        // Examine
        m_Examine = asset.GetActionMap("Examine");
        m_Examine_Close = m_Examine.GetAction("Close");
        m_Examine_Zoom = m_Examine.GetAction("Zoom");
        m_Examine_Rotate = m_Examine.GetAction("Rotate");
        // Search
        m_Search = asset.GetActionMap("Search");
        m_Search_Close = m_Search.GetAction("Close");
        m_Search_Navigate = m_Search.GetAction("Navigate");
    }

    ~PlayerControls()
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
    private readonly InputAction m_Movement_Jump;
    private readonly InputAction m_Movement_Examine;
    private readonly InputAction m_Movement_Search;
    private readonly InputAction m_Movement_Move;
    private readonly InputAction m_Movement_Rotate;
    public struct MovementActions
    {
        private PlayerControls m_Wrapper;
        public MovementActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Movement_Jump;
        public InputAction @Examine => m_Wrapper.m_Movement_Examine;
        public InputAction @Search => m_Wrapper.m_Movement_Search;
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputAction @Rotate => m_Wrapper.m_Movement_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                Jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                Examine.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnExamine;
                Examine.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnExamine;
                Examine.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnExamine;
                Search.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnSearch;
                Search.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnSearch;
                Search.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnSearch;
                Move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                Rotate.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnRotate;
                Rotate.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnRotate;
                Rotate.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
                Examine.started += instance.OnExamine;
                Examine.performed += instance.OnExamine;
                Examine.canceled += instance.OnExamine;
                Search.started += instance.OnSearch;
                Search.performed += instance.OnSearch;
                Search.canceled += instance.OnSearch;
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Rotate.started += instance.OnRotate;
                Rotate.performed += instance.OnRotate;
                Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Examine
    private readonly InputActionMap m_Examine;
    private IExamineActions m_ExamineActionsCallbackInterface;
    private readonly InputAction m_Examine_Close;
    private readonly InputAction m_Examine_Zoom;
    private readonly InputAction m_Examine_Rotate;
    public struct ExamineActions
    {
        private PlayerControls m_Wrapper;
        public ExamineActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Close => m_Wrapper.m_Examine_Close;
        public InputAction @Zoom => m_Wrapper.m_Examine_Zoom;
        public InputAction @Rotate => m_Wrapper.m_Examine_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Examine; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ExamineActions set) { return set.Get(); }
        public void SetCallbacks(IExamineActions instance)
        {
            if (m_Wrapper.m_ExamineActionsCallbackInterface != null)
            {
                Close.started -= m_Wrapper.m_ExamineActionsCallbackInterface.OnClose;
                Close.performed -= m_Wrapper.m_ExamineActionsCallbackInterface.OnClose;
                Close.canceled -= m_Wrapper.m_ExamineActionsCallbackInterface.OnClose;
                Zoom.started -= m_Wrapper.m_ExamineActionsCallbackInterface.OnZoom;
                Zoom.performed -= m_Wrapper.m_ExamineActionsCallbackInterface.OnZoom;
                Zoom.canceled -= m_Wrapper.m_ExamineActionsCallbackInterface.OnZoom;
                Rotate.started -= m_Wrapper.m_ExamineActionsCallbackInterface.OnRotate;
                Rotate.performed -= m_Wrapper.m_ExamineActionsCallbackInterface.OnRotate;
                Rotate.canceled -= m_Wrapper.m_ExamineActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_ExamineActionsCallbackInterface = instance;
            if (instance != null)
            {
                Close.started += instance.OnClose;
                Close.performed += instance.OnClose;
                Close.canceled += instance.OnClose;
                Zoom.started += instance.OnZoom;
                Zoom.performed += instance.OnZoom;
                Zoom.canceled += instance.OnZoom;
                Rotate.started += instance.OnRotate;
                Rotate.performed += instance.OnRotate;
                Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public ExamineActions @Examine => new ExamineActions(this);

    // Search
    private readonly InputActionMap m_Search;
    private ISearchActions m_SearchActionsCallbackInterface;
    private readonly InputAction m_Search_Close;
    private readonly InputAction m_Search_Navigate;
    public struct SearchActions
    {
        private PlayerControls m_Wrapper;
        public SearchActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Close => m_Wrapper.m_Search_Close;
        public InputAction @Navigate => m_Wrapper.m_Search_Navigate;
        public InputActionMap Get() { return m_Wrapper.m_Search; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SearchActions set) { return set.Get(); }
        public void SetCallbacks(ISearchActions instance)
        {
            if (m_Wrapper.m_SearchActionsCallbackInterface != null)
            {
                Close.started -= m_Wrapper.m_SearchActionsCallbackInterface.OnClose;
                Close.performed -= m_Wrapper.m_SearchActionsCallbackInterface.OnClose;
                Close.canceled -= m_Wrapper.m_SearchActionsCallbackInterface.OnClose;
                Navigate.started -= m_Wrapper.m_SearchActionsCallbackInterface.OnNavigate;
                Navigate.performed -= m_Wrapper.m_SearchActionsCallbackInterface.OnNavigate;
                Navigate.canceled -= m_Wrapper.m_SearchActionsCallbackInterface.OnNavigate;
            }
            m_Wrapper.m_SearchActionsCallbackInterface = instance;
            if (instance != null)
            {
                Close.started += instance.OnClose;
                Close.performed += instance.OnClose;
                Close.canceled += instance.OnClose;
                Navigate.started += instance.OnNavigate;
                Navigate.performed += instance.OnNavigate;
                Navigate.canceled += instance.OnNavigate;
            }
        }
    }
    public SearchActions @Search => new SearchActions(this);
    public interface IMovementActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnExamine(InputAction.CallbackContext context);
        void OnSearch(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
    public interface IExamineActions
    {
        void OnClose(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
    public interface ISearchActions
    {
        void OnClose(InputAction.CallbackContext context);
        void OnNavigate(InputAction.CallbackContext context);
    }
}
