using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : OVRGrabbable
{

    public ScoreManager scoreManager;
    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        scoreManager.increaseScore();

    }


}
