using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float bulletSpeed = 10;
    public Transform bulletSpawnPos;
    public GameObject bullet;
     
     
    void Fire()
    {
        var bulletClone = Instantiate(bullet, bulletSpawnPos.position, transform.rotation);
        bulletClone.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
    }
 
    void Update () 
    {
        if (Input.GetButtonDown("Fire1")) Fire();
    }
}
