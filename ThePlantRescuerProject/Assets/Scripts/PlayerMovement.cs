using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Public Variable, Visible in unity inspector
    public float forceStrength;
    
    // these will be called by each button for movement
    public void MoveRight()
    {
        // Get the Rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // move in the correct direction with the set Force Strength
        ourRigidbody.AddForce(Vector2.right * forceStrength);
    }

    public void MoveLeft()
    {
        // Get the Rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // move in the correct direction with the set Force Strength
        ourRigidbody.AddForce(Vector2.left * forceStrength);
    }

}
