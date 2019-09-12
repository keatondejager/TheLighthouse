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
        // Inventory
        m_Inventory = asset.GetActionMap("Inventory");
        m_Inventory_Exit = m_Inventory.GetAction("Exit");
        // Menus
        m_Menus = asset.GetActionMap("Menus");
        m_Menus_Exit = m_Menus.GetAction("Exit");
        // Interact
        m_Interact = asset.GetActionMap("Interact");
        m_Interact_Exit = m_Interact.GetAction("Exit");
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
    public struct ExaminingActions
    {
        private PlayerInputActions m_Wrapper;
        public ExaminingActions(PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Exit => m_Wrapper.m_Examining_Exit;
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
            }
            m_Wrapper.m_ExaminingActionsCallbackInterface = instance;
            if (instance != null)
            {
                Exit.started += instance.OnExit;
                Exit.performed += instance.OnExit;
                Exit.canceled += instance.OnExit;
            }
        }
    }
    public ExaminingActions @Examining => new ExaminingActions(this);

    // Inventory
    private readonly InputActionMap m_Inventory;
    private IInventoryActions m_InventoryActionsCallbackInterface;
    private readonly InputAction m_Inventory_Exit;
    public struct InventoryActions
    {
        private PlayerInputActions m_Wrapper;
        public InventoryActions(PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Exit => m_Wrapper.m_Inventory_Exit;
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
            }
            m_Wrapper.m_InventoryActionsCallbackInterface = instance;
            if (instance != null)
            {
                Exit.started += instance.OnExit;
                Exit.performed += instance.OnExit;
                Exit.canceled += instance.OnExit;
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
    public struct InteractActions
    {
        private PlayerInputActions m_Wrapper;
        public InteractActions(PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Exit => m_Wrapper.m_Interact_Exit;
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
            }
            m_Wrapper.m_InteractActionsCallbackInterface = instance;
            if (instance != null)
            {
                Exit.started += instance.OnExit;
                Exit.performed += instance.OnExit;
                Exit.canceled += instance.OnExit;
            }
        }
    }
    public InteractActions @Interact => new InteractActions(this);
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
    }
    public interface IInventoryActions
    {
        void OnExit(InputAction.CallbackContext context);
    }
    public interface IMenusActions
    {
        void OnExit(InputAction.CallbackContext context);
    }
    public interface IInteractActions
    {
        void OnExit(InputAction.CallbackContext context);
    }
}
