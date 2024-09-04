using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance { get; private set; }

    public void GetInstance()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }


    public void PlaySound(AudioSource audio)
    {
        audio.Play();
    }

    public void StopSound(AudioSource audio)
    {
        audio.Stop();
    }
}

