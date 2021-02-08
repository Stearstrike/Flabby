using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore : MonoBehaviour
{
    public AudioSource scoreSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreSound.Play();
        Score.score++;
    }
}
