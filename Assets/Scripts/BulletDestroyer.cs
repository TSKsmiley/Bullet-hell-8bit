using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    public int maxY = 20;
    public Transform trans;

    // Update is called once per frame
    void Update()
    {
        if (trans.position.y > maxY)
        {
            Destroy(gameObject);
        }
    }
}
