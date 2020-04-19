using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingScript : MonoBehaviour
{

    //Here i take the RigidBody components
    public Rigidbody2D[] objectRotation;

    //Here i decide what will be there rotation (0 on the Z rotation means the Sprite will be standing)
    public float rotation;

    //Here i put the amount of force i want to make it going back to the 0 Rotation
    public float forceToRotation;



    private void Update() {
        StandingRotation();
   }
    public void StandingRotation()
    {
        foreach (Rigidbody2D rotObj in objectRotation)
        {
        // This will take each Rigidbody object and move its rotation to the float rotation value, with mathf.lerpAngle i can make it not to be immediate but in a time duration
        rotObj.MoveRotation(Mathf.LerpAngle(rotObj.rotation,rotation,forceToRotation*Time.deltaTime));
        }
    }
}
