using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider other)
    {
        if(other.gameObject.name == "TopPaddle")
        {

        }
        else if(other.gameObject.name == "BottomPaddle")
        {

        }
        
    }
}
