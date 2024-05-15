using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    // Start is called before the first frame update

    float triggerOculus = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);
    public Transform shoot;
    public GameObject bullet;
    public float bulletforce;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")|| triggerOculus > 0.5f)
        {
            GameObject newBullet = Instantiate(bullet, shoot.transform.position, shoot.rotation);
            Rigidbody BulletForce = newBullet.GetComponent<Rigidbody>();
            BulletForce.AddForce(shoot.forward * Time.deltaTime * bulletforce, ForceMode.Impulse);
        }
    }
}
