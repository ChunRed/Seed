using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnOffTracking : NYImageTrackerEventHandler
{
    // public Animator targetAnim;
    // public Animator targetAnim2;

    public List<Animator> listAnim = new List<Animator>();

    public string onFoundAnimName;
    public string onLostAnimName;

    // public string onFoundAnimName2;
    // public string onLostAnimName2;

    public override void OnTrackingFound()
    {
        for(int i=0; i < listAnim.Count; i++){
            listAnim[i].Play(onFoundAnimName);
        }
        // targetAnim.Play(onFoundAnimName);
        // targetAnim2.Play(onFoundAnimName2);
    }

    public override void OnTrackingLost()
    {
        for(int i=0; i < listAnim.Count; i++){
            listAnim[i].Play(onLostAnimName);
        }
        // targetAnim.Play(onLostAnimName);
        // targetAnim2.Play(onLostAnimName2);
    }
}
