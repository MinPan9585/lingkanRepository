using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PrimaryBtnTest : MonoBehaviour
{
    public InputActionReference primAction;

    private void Awake()
    {
        primAction.action.performed += Toggle;
    }

    public void Toggle(InputAction.CallbackContext ctx)
    {

    }

    private void OnDestroy()
    {
        primAction.action.performed -= Toggle;
    }
}
