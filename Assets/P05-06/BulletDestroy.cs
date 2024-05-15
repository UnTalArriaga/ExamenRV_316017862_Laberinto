using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Scene"))
        {
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 5.0f);
    }
}
