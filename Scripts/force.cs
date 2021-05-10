using UnityEngine;

public class force : MonoBehaviour
{
public Material sswf;


void Start() {

    sswf.SetFloat("_FresnelPower",3f);
}
float rdir;
void Update(){
    if( Input.GetKeyDown( KeyCode.RightArrow ) )
            rdir=rdir+0.2f;
            sswf.SetFloat("_FresnelPower",rdir);
            if( Input.GetKeyDown( KeyCode.LeftArrow ) )
            rdir=rdir-0.2f;
            sswf.SetFloat("_FresnelPower",rdir);
    
}
}