using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    AudioSource shotSound;

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



public class Health : MonoBehaviour
{
    public int health = 3;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            health--;
            Debug.Log("Cantidad de vidas restantes: " + health);
        }
    }
}