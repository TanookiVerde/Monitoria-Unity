using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByInput : MonoBehaviour
{
    [SerializeField] private float velocity;

    private void Update()
    {
        Vector2 direction = new Vector2(
            Input.GetAxis("Horizontal"), 
            Input.GetAxis("Vertical")
            );
        Move(direction);
    }
    private void Move(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * velocity;
    }
}
