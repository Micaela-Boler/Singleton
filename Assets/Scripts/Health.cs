using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    public int health = 3;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && health > 0)
        {
            health--;
            gameManager.GameOver();
            Debug.Log("Cantidad de vidas restantes: " + health);
        }
    }
}
