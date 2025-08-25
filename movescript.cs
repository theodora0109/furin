using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movescript : MonoBehaviour
{
    public Rigidbody tongue; // 舌（ぜつ）のRigidbody
    public float windStrength = 10.0f;

    void FixedUpdate()
    {
        // 毎フレームちょっとランダムな風を加える
        Vector3 randomWind = new Vector3(
            Random.Range(-1f, 0.1f),
            0,
            Random.Range(-1f, 0.1f)
        ).normalized * windStrength;

        tongue.AddForce(randomWind);
    }
}


