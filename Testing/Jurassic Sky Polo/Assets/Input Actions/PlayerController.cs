// GENERATED AUTOMATICALLY FROM 'Assets/Input Actions/PlayerController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""Birb"",
            ""id"": ""db65d6f7-3df1-4d84-9a7b-69cbc2a74c06"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""b5407439-57bf-43cd-8a66-adda96cb2387"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""72841c9d-63bd-4ad5-a80b-ba5c15f9f409"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Birb
        m_Birb = asset.FindActionMap("Birb", throwIfNotFound: true);
        m_Birb_Movement = m_Birb.FindAction("Movement", throwIfNotFound: true);
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

    // Birb
    private readonly InputActionMap m_Birb;
    private IBirbActions m_BirbActionsCallbackInterface;
    private readonly InputAction m_Birb_Movement;
    public struct BirbActions
    {
        private @PlayerController m_Wrapper;
        public BirbActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Birb_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Birb; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BirbActions set) { return set.Get(); }
        public void SetCallbacks(IBirbActions instance)
        {
            if (m_Wrapper.m_BirbActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_BirbActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_BirbActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_BirbActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_BirbActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public BirbActions @Birb => new BirbActions(this);
    public interface IBirbActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
