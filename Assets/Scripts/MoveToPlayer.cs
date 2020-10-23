using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveToPlayer : MonoBehaviour
{
    [SerializeField] private float velocity;

    private void Update()
    {
        Move(GetPlayerDirection());
    }
    private void Move(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * velocity;
    }
    private Vector2 GetPlayerDirection()
    {
        Vector3 playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        return (playerPosition - transform.position).normalized;
    }
}
