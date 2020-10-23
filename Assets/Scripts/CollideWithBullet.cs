using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithBullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
            Die();
    }
    private void Die()
    {
        GameObject.Destroy(this.gameObject);
    }
}
