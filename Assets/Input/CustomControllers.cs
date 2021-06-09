// GENERATED AUTOMATICALLY FROM 'Assets/Input/CustomControllers.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace InputController
{
    public class @CustomControllers : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @CustomControllers()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""CustomControllers"",
    ""maps"": [
        {
            ""name"": ""Mouvement"",
            ""id"": ""d49d865e-7ff3-4f6b-a26a-a9850a943bb6"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fc321318-a9b8-48e6-b5e1-255648507eb3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e2d496a7-2490-4af3-ae8b-873a888883a3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""42af3f3d-7091-48ae-9c94-e6acb718e688"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd45dc41-8de6-4d56-93f1-bf9a524324e1"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e7914039-e406-4af7-a5fe-bfc4ac9d059c"",
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
                    ""id"": ""81d03669-d6e6-460e-a079-8dc6b53ccf67"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2539d4f6-63dd-4b4e-9ce0-1d87730b1fa5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6915b62c-a3be-4ef0-b3d0-352e8c36ede3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d10dbd14-63fc-410e-a997-39f790a01d1d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""28af53e4-0361-44ae-b636-af9adbc441ae"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
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
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Mouvement
            m_Mouvement = asset.FindActionMap("Mouvement", throwIfNotFound: true);
            m_Mouvement_Look = m_Mouvement.FindAction("Look", throwIfNotFound: true);
            m_Mouvement_Move = m_Mouvement.FindAction("Move", throwIfNotFound: true);
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

        // Mouvement
        private readonly InputActionMap m_Mouvement;
        private IMouvementActions m_MouvementActionsCallbackInterface;
        private readonly InputAction m_Mouvement_Look;
        private readonly InputAction m_Mouvement_Move;
        public struct MouvementActions
        {
            private @CustomControllers m_Wrapper;
            public MouvementActions(@CustomControllers wrapper) { m_Wrapper = wrapper; }
            public InputAction @Look => m_Wrapper.m_Mouvement_Look;
            public InputAction @Move => m_Wrapper.m_Mouvement_Move;
            public InputActionMap Get() { return m_Wrapper.m_Mouvement; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MouvementActions set) { return set.Get(); }
            public void SetCallbacks(IMouvementActions instance)
            {
                if (m_Wrapper.m_MouvementActionsCallbackInterface != null)
                {
                    @Look.started -= m_Wrapper.m_MouvementActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_MouvementActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_MouvementActionsCallbackInterface.OnLook;
                    @Move.started -= m_Wrapper.m_MouvementActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_MouvementActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_MouvementActionsCallbackInterface.OnMove;
                }
                m_Wrapper.m_MouvementActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                }
            }
        }
        public MouvementActions @Mouvement => new MouvementActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
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
        public interface IMouvementActions
        {
            void OnLook(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
        }
    }
}
