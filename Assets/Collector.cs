using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public string collectibleTag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter ( Collision collision )
    {
        if (collision.gameObject.tag == collectibleTag)
        {
            GameObject.Destroy( collision.gameObject );
        }
    }
}
