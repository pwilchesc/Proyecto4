using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 


public class Change : MonoBehaviour
{
    float r =0;
    float g =0;
    // Start is called before the first frame update
    void Start()
    {
        
        transform.localScale = new Vector3(2, 2, 2);
        GetComponent<Renderer>().material.color= Color.grey;
        

    }

    // Update is called once per frame
    void Update( )
    {
        if( Input.GetKeyDown( KeyCode.A ) )
            GetComponent<Renderer>().material.color= Color.yellow;
        if( Input.GetKeyDown( KeyCode.R ) )
            GetComponent<Renderer>().material.color= Color.red;
        if( Input.GetKeyDown( KeyCode.V ) )
            GetComponent<Renderer>().material.color= Color.green;
        if( Input.GetKeyDown( KeyCode.Z ) )
            GetComponent<Renderer>().material.color= Color.blue;
        if( Input.GetKeyDown( KeyCode.B ) )
            GetComponent<Renderer>().material.color= Color.black;

    }
}
