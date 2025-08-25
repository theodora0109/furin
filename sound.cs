using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource audioSources;

    void OnCollisionEnter(Collision collision)
    {
        // "Ball" という名前のオブジェクトに当たったときだけ音を鳴らす
        if (collision.gameObject.name.Contains("ball"))
        {
            audioSources.PlayOneShot(audioSources.clip);
            }
        }
    }

