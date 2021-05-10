using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NubesA : MonoBehaviour
{
public Animation anim;
    AnimationClip animationClip;
    AnimationCurve curve;
    // Use this for initialization
    void Start()
    {
            Animation();
    }
    void Animation()
    {
        anim = GetComponent<Animation>();
        // define animation curve
        // AnimationCurve translateY = AnimationCurve.Linear(0.0f, 0.0f, 3f, 3.0f);
        Keyframe[] keysX;
        keysX = new Keyframe[4];
        keysX[0] = new Keyframe(0f, 0f);
        keysX[1] = new Keyframe(30f, -10f);
        keysX[2] = new Keyframe(40f, -10f);
        keysX[3] = new Keyframe(60f, -0f);
        
        curve = new AnimationCurve(keysX);
        animationClip = new AnimationClip();
        // set animation clip to be legacy
        animationClip.legacy = true;
        animationClip.SetCurve("", typeof(Transform), "localPosition.z", curve);
        anim.AddClip(animationClip, "NubesAA");
        anim.Play("NubesAA");
    }

}
