using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int Health = 2;
    public int BumpDamage = 50;
    public Transform tf;

    private PlayerHealth ph;
    
    // Start is called before the first frame update
    void Start()
    {
        ph = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per physics tick
    void FixedUpdate()
    {
        tf.Translate(Vector3.up * .1f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ph.ChangeHealth(-1*BumpDamage);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            Health--;
            if (Health == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
