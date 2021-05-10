using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globes : MonoBehaviour
{
    public Animation anim;
    AnimationClip animationClip;
    AnimationCurve curve;
    AnimationCurve curve2;
    // Use this for initialization
    void Start()
    {
            Animation();
    }
    void Animation()
    {
        anim = GetComponent<Animation>();
        Keyframe[] keysY;
        keysY = new Keyframe[13];
        keysY[0] = new Keyframe(0f, 2f);
        keysY[1] = new Keyframe(5f, 0f);
        keysY[2] = new Keyframe(10f, 2f);
        keysY[3] = new Keyframe(15f, 0f);
        keysY[4] = new Keyframe(20f, 2f);
        keysY[5] = new Keyframe(25f, 0f);
        keysY[6] = new Keyframe(30f, 2f);
        keysY[7] = new Keyframe(35f, 0f);
        keysY[8] = new Keyframe(40f, 2f);
        keysY[9] = new Keyframe(45f, 0f);
        keysY[10] = new Keyframe(50f, 2f);
        keysY[11] = new Keyframe(55f, 0f);
        keysY[12] = new Keyframe(60f, 2f);
        curve2 = new AnimationCurve(keysY);
        animationClip = new AnimationClip();
        // set animation clip to be legacy
        animationClip.legacy = true;
        animationClip.SetCurve("", typeof(Transform), "localPosition.y", curve2);
        anim.AddClip(animationClip, "test");
        anim.Play("test");
    }

}
