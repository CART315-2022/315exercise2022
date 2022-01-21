using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        if (Input.GetKey(KeyCode.R))
        {
            this.GetComponent<Transform>( ).Rotate( 0, rotationSpeed, 0 );
        }

        if (Input.GetKey( KeyCode.T ))
        {
            this.GetComponent<Transform>( ).Rotate( 0, -rotationSpeed, 0 );
        }
        */
    }

    public void Rotate1()
    {
        this.GetComponent<Transform>( ).Rotate( 0, rotationSpeed, 0 );
    }

    public void Rotate2()
    {
        this.GetComponent<Transform>( ).Rotate( 0, -rotationSpeed, 0 );
    }
}
