using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int pointsInScene;
    public AudioSource music;
    private GameObject player;
    

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        GameOver();
    }


    public void GameOver()
    {
        if (player.GetComponent<Health>().health >= 0)
            SoundManager.instance.PlaySound(music);
    }
}
