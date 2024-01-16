using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Assertions.Comparers;


public class PaddleController : MonoBehaviour
{
    public float speed = 2f;
    public float minX = 0; // remember to switch stuff to mobile
    public float maxX = 5;

    private Vector2 targetPosition;

    private void Start()
    {
        PickNewTarget();
    }


    private void Update()
    {
        MovePaddle();

        if ((Vector2)transform.position == targetPosition)
        {
            PickNewTarget();
        }

    }

    private void MovePaddle()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

    }

    private void PickNewTarget()
    {
        float randomX = Random.Range(minX, maxX);
        targetPosition = new Vector2(randomX, transform.position.y);
    }
}


