using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotación : MonoBehaviour
{
    // Start is called before the first frame update
    public int velocidadRotacion, mov;
    private int state;
    private float gradosRotados = 0f;
    void Start()
    {
        
        mov = 30;
        velocidadRotacion = 15;
        state = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Verificar si se han rotado 360 grados
        if (gradosRotados < 360f && state == 0)
        {
            transform.Rotate(Vector3.up, Mathf.Deg2Rad * velocidadRotacion);
            gradosRotados += Mathf.Deg2Rad * velocidadRotacion;

        }
        else if (state == 0 && transform.position.y < 132)
        {
            transform.Translate(Vector3.up * mov * Time.deltaTime);
        }
        else if (state == 0)
        {
            state = 1;
        }
        if (state == 1 && gradosRotados < 2*360f)
        {
            transform.Rotate(Vector3.up, Mathf.Deg2Rad * velocidadRotacion);
            gradosRotados += Mathf.Deg2Rad * velocidadRotacion;
        }
        else if (state == 1 &&  transform.position.y > -147)
        {
            transform.Translate(Vector3.down * mov * Time.deltaTime);
        }
        else if(state == 1)
        {
            state = 2;
            gradosRotados = 0;
        }
        if (state == 2 && gradosRotados < 360f)
        {
            transform.Rotate(Vector3.up, Mathf.Deg2Rad * velocidadRotacion);
            gradosRotados += Mathf.Deg2Rad * velocidadRotacion;
        }
        else if (state == 2 && transform.position.y < 3)
        {
            transform.Translate(Vector3.up * mov * Time.deltaTime);
        }


    }
}
