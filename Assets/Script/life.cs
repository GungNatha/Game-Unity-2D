using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class life : MonoBehaviour
{
    Vector2 startPos;
    private int health ;
    public GameObject loseGame;
    public GameObject heart1,heart2, heart3;
    [SerializeField] private AudioSource suaraLose;
    [SerializeField] private AudioSource suaraGame;

    private void Start()
    {
        startPos = transform.position;
        health = 3 ;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trap"))
        {
            Die();
            health--;
            if(health == 2)
            {
                heart3.gameObject.SetActive(false);
            }else if (health == 1) {
                heart2.gameObject.SetActive(false);
            }else if(health == 0)
            {
                heart1.gameObject.SetActive(false);
            }


            if (health == 0)
            {
                loseGame.gameObject.SetActive(true);
                Time.timeScale = 0f;
                suaraLose.Play();
                suaraGame.Pause();
            }   
        }
    }

    void Die()
    {
        respawn();
    }

    void respawn()
    {
        Time.timeScale = 1f;
        transform.position = startPos;
    }

}