using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    [SerializeField] ObjSpawner objSpawner;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Score.theScore += 1;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Spike"))
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().GameOver();
        }

    }
    void Update()
    {
        if (Score.theScore == objSpawner.n)
            FindObjectOfType<GameManager>().GameOver();
    }
}
