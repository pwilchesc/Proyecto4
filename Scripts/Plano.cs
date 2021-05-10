using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plano : MonoBehaviour
{
    Vector3[] vert;
    int[] tri;
    Mesh mesh;
    int w = 20;
    int h = 50;
    float high1 = 1;
    public GameObject Plano1;
    
    // Start is called before the first frame update
    void Start()
    {  
        Plano1 = new GameObject("1", typeof(MeshFilter),typeof(MeshRenderer));
        mesh = new Mesh();
        Plano1.GetComponent<MeshFilter>().mesh = mesh;
        // Plano1.GetComponent<Renderer>().material.SetTexture("_MainTex",(Texture2D)Resources.Load("Mountain"));
        CreateFigure();
        drawMesh();
        Material newMat = Resources.Load("ssw", typeof(Material)) as Material;
        Plano1.GetComponent<Renderer>().material = newMat;
        Plano1.transform.localPosition = new Vector3(10,0,0);
    }

    void CreateFigure(){
        vert = new Vector3[(w+1)*(h+1)];
        int c = 0;
        int y=0;
        for(int i = 0;i<=h;i++){
            for(int j = 0;j<=w;j++){
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
}
