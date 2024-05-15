using UnityEngine;
public class PlayerMov : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 5.0f;
    private GameObject Camera, Player;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Camera = GameObject.Find("CenterEyeAnchor");
        //Camera = GameObject.Find("Camera");
        Player = GameObject.Find("Player");
        
    }
    void Update()
    {

        movimiento();
        rotacion();
    }

    void movimiento()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 vel = Vector3.zero;
        if (hor != 0 || ver != 0)
        {
            Vector3 direction = (Camera.transform.forward * ver + Camera.transform.right * hor).normalized;
            vel = direction * speed;
        }
        vel.y = rb.velocity.y;
        rb.velocity = vel;
    }
    void rotacion()
    {
        Vector3 posicion = (Player.transform.right * Player.transform.position.x) + (Player.transform.up * (Player.transform.position.y + 1.7f)) + (Player.transform.forward *Player.transform.position.z);
        Camera.transform.position = posicion;
    }
}