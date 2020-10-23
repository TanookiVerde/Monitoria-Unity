using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootByInput : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletVelocity;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Shoot();
    }
    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.position = this.transform.position;
        bullet.GetComponent<Rigidbody2D>().velocity = GetMouseDirection() * bulletVelocity;
    }
    private Vector2 GetMouseDirection()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return (mousePosition - (Vector2) transform.position).normalized;
    }
}
