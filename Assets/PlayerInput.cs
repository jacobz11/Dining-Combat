//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""bd76f5e1-4b72-49fc-b009-d13bf42f2422"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""bd0142c0-7b6a-4e84-8e7f-189b1d5adb5a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotiatin"",
                    ""type"": ""Value"",
                    ""id"": ""66b29612-749c-481f-a1ab-d612d652f5e7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PickUp"",
                    ""type"": ""Button"",
                    ""id"": ""2e0a7760-bbe7-489d-a2ea-e1efc53d35f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""StartCharging"",
                    ""type"": ""Button"",
                    ""id"": ""83ec2b65-f32d-4688-9d6f-7550869e66e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""StopChargung"",
                    ""type"": ""Button"",
                    ""id"": ""fbf51ec4-5bd5-4081-95db-63e6064ab457"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""BostRunnig"",
                    ""type"": ""Button"",
                    ""id"": ""fcbaa957-0466-4e40-a563-9587b29c4209"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""87d1373d-4205-46cb-865b-b2e2ce035f31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8b1d2623-180d-4b39-9bfb-a0dcf260bd2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""149e0d8e-d555-423f-9f83-a281eec01d99"",
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
                    ""id"": ""0bbfe67e-3b85-44c3-a822-77c1272a43e4"",
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
                    ""id"": ""6761444c-8503-44e9-8f17-ca5cc4811630"",
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
                    ""id"": ""d4233f99-352a-4bdb-b1fa-6aca15767b1b"",
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
                    ""id"": ""95914a01-73b6-4cbd-a341-02ab214b8869"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow keys"",
                    ""id"": ""e0a2fbf7-a92e-4a07-8b3a-31af25ff6a55"",
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
                    ""id"": ""2709308c-f53e-4801-b103-e8066728c5be"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6914ba61-4793-40e1-b2f7-bdac7981558b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dc973e54-9e1a-45f9-8459-8003ce42eb6c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""02ce9079-3f3a-40ba-b762-1dfe7d714f0f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""360819e2-6b48-452a-a9d1-72bfc8d3c03f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotiatin"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""913f896b-631c-4a76-a1af-2abf2554d0f4"",
                    ""path"": ""<Mouse>/delta/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotiatin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dcbaaf81-ded4-471a-9c22-fb0a9db596a8"",
                    ""path"": ""<Mouse>/delta/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotiatin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""aa437135-f857-41ce-807b-c1c2e36be45a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61abce50-ab32-4157-bf7c-c74ce6645b46"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartCharging"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8435f280-73fd-4b25-9138-7fb0cbc443f2"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BostRunnig"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42361de5-e093-460e-b486-e291f5936929"",
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
                    ""id"": ""8e4d154d-8176-4133-82e8-4a525d6cb383"",
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
                    ""id"": ""4f2cfb5d-7ca6-43bd-9a34-a58107a84a8d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopChargung"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Rotiatin = m_Player.FindAction("Rotiatin", throwIfNotFound: true);
        m_Player_PickUp = m_Player.FindAction("PickUp", throwIfNotFound: true);
        m_Player_StartCharging = m_Player.FindAction("StartCharging", throwIfNotFound: true);
        m_Player_StopChargung = m_Player.FindAction("StopChargung", throwIfNotFound: true);
        m_Player_BostRunnig = m_Player.FindAction("BostRunnig", throwIfNotFound: true);
        m_Player_Exit = m_Player.FindAction("Exit", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Rotiatin;
    private readonly InputAction m_Player_PickUp;
    private readonly InputAction m_Player_StartCharging;
    private readonly InputAction m_Player_StopChargung;
    private readonly InputAction m_Player_BostRunnig;
    private readonly InputAction m_Player_Exit;
    private readonly InputAction m_Player_Jump;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Rotiatin => m_Wrapper.m_Player_Rotiatin;
        public InputAction @PickUp => m_Wrapper.m_Player_PickUp;
        public InputAction @StartCharging => m_Wrapper.m_Player_StartCharging;
        public InputAction @StopChargung => m_Wrapper.m_Player_StopChargung;
        public InputAction @BostRunnig => m_Wrapper.m_Player_BostRunnig;
        public InputAction @Exit => m_Wrapper.m_Player_Exit;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Rotiatin.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotiatin;
                @Rotiatin.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotiatin;
                @Rotiatin.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotiatin;
                @PickUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickUp;
                @PickUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickUp;
                @PickUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickUp;
                @StartCharging.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartCharging;
                @StartCharging.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartCharging;
                @StartCharging.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartCharging;
                @StopChargung.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopChargung;
                @StopChargung.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopChargung;
                @StopChargung.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopChargung;
                @BostRunnig.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBostRunnig;
                @BostRunnig.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBostRunnig;
                @BostRunnig.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBostRunnig;
                @Exit.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExit;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotiatin.started += instance.OnRotiatin;
                @Rotiatin.performed += instance.OnRotiatin;
                @Rotiatin.canceled += instance.OnRotiatin;
                @PickUp.started += instance.OnPickUp;
                @PickUp.performed += instance.OnPickUp;
                @PickUp.canceled += instance.OnPickUp;
                @StartCharging.started += instance.OnStartCharging;
                @StartCharging.performed += instance.OnStartCharging;
                @StartCharging.canceled += instance.OnStartCharging;
                @StopChargung.started += instance.OnStopChargung;
                @StopChargung.performed += instance.OnStopChargung;
                @StopChargung.canceled += instance.OnStopChargung;
                @BostRunnig.started += instance.OnBostRunnig;
                @BostRunnig.performed += instance.OnBostRunnig;
                @BostRunnig.canceled += instance.OnBostRunnig;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotiatin(InputAction.CallbackContext context);
        void OnPickUp(InputAction.CallbackContext context);
        void OnStartCharging(InputAction.CallbackContext context);
        void OnStopChargung(InputAction.CallbackContext context);
        void OnBostRunnig(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
