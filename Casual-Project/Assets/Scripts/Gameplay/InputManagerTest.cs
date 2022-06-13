using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-1)]
public class InputManagerTest : MonoBehaviour //El nuevo sistema de input de unity, No se si esto va a ser reemplazado
{
    private TestTouchControls controls;

    //Funcionalidad para los eventos de touch y los callbacks
    #region
    public delegate void StartTouch(Vector2 position, float time);
    public event StartTouch OnStartTouch;
    public delegate void EndTouch(Vector2 position, float time);
    public event EndTouch OnEndTouch;
    #endregion

    private void Awake()
    {
        controls = new TestTouchControls();

    }

    private void OnEnable()
    {
        controls.Enable();

    }

    private void OnDisable()
    {
        controls.Disable();
    }

    void Start()
    {
        controls.General.Touch.started += ctx => StartTap(ctx);
        controls.General.Touch.canceled += ctx => EndTap(ctx);
    }

    //Los callbacks de los eventos, donde se manda la informaci�n para detectar un swipe
    void StartTap(InputAction.CallbackContext context)
    {

        if (OnStartTouch != null)
        {
            OnStartTouch(controls.General.Position.ReadValue<Vector2>(), (float)context.startTime);

        }
    }
    void EndTap(InputAction.CallbackContext context)
    {
        if (OnEndTouch != null)
        {
            OnEndTouch(controls.General.Position.ReadValue<Vector2>(), (float)context.time);
        }
    }
}
