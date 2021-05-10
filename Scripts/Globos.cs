using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globos : MonoBehaviour
{
    void Start()
    {
        gameObject.tag = "Globos";
        transform.localPosition = new Vector3(0, 0, 0);
        Globe(3.9f+15f, -2.3f+13f, -19f+25f);
        Globe(1.1f+15f, -4.6f+13f, -18.3f+25f);
        Globe(3.1f+15f, -0.3f+13f, -16.7f+25f);
        Globe(10f+15f, 5.6f+13f, -2.3f+25f);
        Globe(6.4f+15f, -1.5f+13f, 20f+25f);
        Globe(8.6f+15f, 0.2f+13f, 16.9f+25f);
        
    }

    void Globe(float x, float y, float z){ 
        GameObject Up = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Up.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        Up.transform.localPosition = new Vector3(x,y,z);
        Up.GetComponent<Renderer>().material.color= new Color(1,0.5293f,0);
        Up.transform.parent = GameObject.FindWithTag("Globos").transform;
        Material newMatg = Resources.Load("globo", typeof(Material)) as Material;
        Up.GetComponent<Renderer>().material = newMatg;
        GameObject arriba = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        arriba.transform.parent = Up.transform;
        arriba.transform.localPosition = new Vector3(0, -0.5f, 0);
        arriba.transform.localScale = new Vector3(0.5f, 0.1f, 0.5f);
        arriba.GetComponent<Renderer>().material.color= new Color(1,0.2174f,0);
        GameObject canasta = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        canasta.transform.parent = Up.transform;
        canasta.transform.localPosition = new Vector3(0, -1.2f, 0);
        canasta.transform.localScale = new Vector3(0.5f, 0.2f, 0.5f);
        canasta.GetComponent<Renderer>().material.color= new Color(0.3379f,0.2290f,0.2290f);
        Material newMatc = Resources.Load("canasta", typeof(Material)) as Material;
        canasta.GetComponent<Renderer>().material = newMatc;
        GameObject lightGameObject = new GameObject("The Light");
        Light lightComp = lightGameObject.AddComponent<Light>();
        lightComp.color = Color.yellow;
        lightGameObject.transform.parent = arriba.transform;
        lightGameObject.transform.localPosition = new Vector3(0, -1, 0);
        lightGameObject.GetComponent<Light>().color =Color.green;
    }
}
