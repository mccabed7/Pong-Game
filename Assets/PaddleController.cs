using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    // TODO Complete logic in fixedUpdate for using moveToward.  Use random generator for destinations.

    public Transform transformComponent;
    public Rigidbody2D myRigidbody;
    public float speed = 1f;

    private float destination;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        throw new System.Exception("PaddleController not testable yet.  See TODO section in PaddleController.cs");
        if ( speed < 0f ) { throw new System.Exception("Error, speed cannot be negative!"); }

        direction = Vector2.up * speed;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void moveToward(float yDest)
    {
        if(transformComponent.position.y < yDest)
        {
            direction.y = 1 * speed;
        }
        else
        {
            direction.y = -1 * speed;
        }
        myRigidbody.MovePosition((Vector2)transformComponent.position + direction);
    }
}
