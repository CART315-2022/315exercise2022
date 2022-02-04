using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray theray = Camera.main.ScreenPointToRay( Input.mousePosition );

            RaycastHit rayHitInfo;
            if (Physics.Raycast( theray, out rayHitInfo ))
            {

                GameObject.Instantiate( prefab, rayHitInfo.point, Quaternion.identity );
            }
        }
    }
}
