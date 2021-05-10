using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Displacement : MonoBehaviour
{
    Vector3[] vert;
    int[] tri;
    Mesh mesh;
    int w = 10;
    int h = 50;
    float high1 = 1;
    public GameObject Plano;
    
    // Start is called before the first frame update
    void Start()
    {  
        Plano = new GameObject("go", typeof(MeshFilter),typeof(MeshRenderer));
        mesh = new Mesh();
        Plano.GetComponent<MeshFilter>().mesh = mesh;
        // Plano.GetComponent<Renderer>().material.SetTexture("_MainTex",(Texture2D)Resources.Load("Mountain"));
        CreateFigure();
        drawMesh();
        Material newMat = Resources.Load("Force Field", typeof(Material)) as Material;
        Plano.GetComponent<Renderer>().material = newMat;

    }

    void CreateFigure(){
        vert = new Vector3[(w+1)*(h+1)];
        int c = 0;
        for(int i = 0;i<=h;i++){
            for(int j = 0;j<=w;j++){
                float y = Mathf.PerlinNoise(i*0.5f,j*0.5f);
                if (y < 0.5f)
                {
                    y=0.5f;
                }
                y=(y*50)-25;
                vert[c] = new Vector3(j,y,i);
                c++;
            }
        }
  
        tri = new int[6*w*h];
        int v = 0;
        int t = 0;
        for(int i = 0;i<h;i++){
            for(int j = 0;j<w;j++){
                tri[t] = v;
                tri[t+1] = v + w + 1;
                tri[t+2] = v + 1;
                tri[t+3] = v + 1;
                tri[t+4] = v + w + 1;
                tri[t+5] = v + w + 2;
                v++;
                t+=6;
            }
            v++;
        }
    }
    void drawMesh(){
        mesh.Clear();
        mesh.vertices = vert;
        mesh.triangles = tri;
        mesh.RecalculateNormals();
    }
    // Update is called once per frame
    void Update( )
    {
        if( Input.GetKeyDown( KeyCode.UpArrow ) ){
            high1=high1+0.1f;
            Debug.Log(high1);
            Plano.transform.localScale = new Vector3(1,high1,1);
        }
        if( Input.GetKeyDown( KeyCode.DownArrow ) ){
            high1=high1-0.1f;
            if (high1<=0)
            {
                high1=0;
            }
            Debug.Log(high1);
           Plano.transform.localScale = new Vector3(1,high1,1);
        }
    }
}