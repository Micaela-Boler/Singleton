using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] AudioSource shotSound;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            Shoot();
    }


    private void Shoot()
    {
        Debug.Log("DISPARO");
        SoundManager.instance.PlaySound(shotSound);
    }
}



