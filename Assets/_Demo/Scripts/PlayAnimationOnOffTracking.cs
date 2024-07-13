using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnOffTracking : NYImageTrackerEventHandler
{

    public List<Animator> listAnim = new List<Animator>();

    public string onFoundAnimName;
    public string onLostAnimName;


    public override void OnTrackingFound()
    {
        for(int i=0; i < listAnim.Count; i++){
            listAnim[i].Play(onFoundAnimName);
        }
    }

    public override void OnTrackingLost()
    {
        for(int i=0; i < listAnim.Count; i++){
            listAnim[i].Play(onLostAnimName);
        }
    }
}
