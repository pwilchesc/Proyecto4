using UnityEngine;

public class ssws : MonoBehaviour
{
public Material ssw;


void Start() {
    ssw.SetFloat("_Amplitude",2f);
}
float amp;
float amplitud;
void Update(){
    amp=5;
    amplitud=Mathf.PingPong(Time.time*0.5f, 2);
    ssw.SetFloat("_Amplitude",amplitud);
}
}
