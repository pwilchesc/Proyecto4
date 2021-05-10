using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nubes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Nubes";
        transform.localPosition = new Vector3(0, 0, 0);
        Nube(14.5f,15.7f,37.3f);
        Nube(14.5f,7f,37.3f);   
        Nube(23.9f,9.66f,13.5f);
        Nube(23.9f,5.5f,15f);
        Nube(12.7f,7f,8.6f);
        Nube(25.1f,8.45f,31f);
    }

    // Update is called once per frame
  void Nube(float x, float y, float z){ 
      Material newMatg = Resources.Load("nube", typeof(Material)) as Material;
        
        GameObject nube1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        nube1.transform.localScale = new Vector3(1,1,1);
        nube1.transform.localPosition = new Vector3(x,y,z);
        nube1.GetComponent<Renderer>().material.color= new Color(0.5f,0.8292f,1);
        nube1.transform.parent = GameObject.FindWithTag("Nubes").transform;
                nube1.GetComponent<Renderer>().material = newMatg;

        GameObject nube2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        nube2.transform.parent = nube1.transform;
        nube2.transform.localPosition = new Vector3(0,-0.5F,0);
        nube2.GetComponent<Renderer>().material.color= new Color(0.5f,0.8292f,1);
                nube2.GetComponent<Renderer>().material = newMatg;

        GameObject nube3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        nube3.transform.parent = nube1.transform;
        nube3.transform.localPosition = new Vector3(-0.5F,-0.3F,0);
        nube3.GetComponent<Renderer>().material.color= new Color(0.5f,0.8292f,1);
                nube3.GetComponent<Renderer>().material = newMatg;

        GameObject nube4 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        nube4.transform.parent = nube1.transform;
        nube4.transform.localPosition = new Vector3(0.5F,-0.3F,0);
        nube4.GetComponent<Renderer>().material.color= new Color(0.5f,0.8292f,1);
                nube4.GetComponent<Renderer>().material = newMatg;

        GameObject nube5 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        nube5.transform.parent = nube1.transform;
        nube5.transform.localPosition = new Vector3(-0.8F,-0.6F,0);
        nube5.GetComponent<Renderer>().material.color= new Color(0.5f,0.8292f,1);
                nube5.GetComponent<Renderer>().material = newMatg;

        GameObject nube6 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        nube6.transform.parent = nube1.transform;
        nube6.transform.localPosition = new Vector3(0.8F,-0.6F,0);
        nube6.GetComponent<Renderer>().material.color= new Color(0.5f,0.8292f,1);
        nube1.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                nube6.GetComponent<Renderer>().material = newMatg;


    }
    
}
