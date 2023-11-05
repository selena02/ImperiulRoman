using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    private PlayerInputActions playerinputActions;
    private void Awake()
    {
        playerinputActions = new PlayerInputActions();
        playerinputActions.Player.Enable();
    }
    public Vector2 GetMovementVectorNormalised()
    {
        
        Vector2 inputVector = playerinputActions.Player.Move.ReadValue<Vector2>();
        

        inputVector = inputVector.normalized;
        return inputVector;
    }
}
