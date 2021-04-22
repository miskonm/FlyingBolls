using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Events

    public event Action OnSpacePressed;

    #endregion

    #region Unity lifecycle

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke();
        }
    }
    
    #endregion
}
