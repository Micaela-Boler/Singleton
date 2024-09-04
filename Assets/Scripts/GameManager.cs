using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] AudioSource music;
    [SerializeField] GameObject player;


    public void GameOver()
    {
        if (player.GetComponent<Health>().health == 0)
        {
            SoundManager.instance.PlaySound(music);
            Debug.Log("PERDISTE");
        }
    }
}
