using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public AudioSource bump;
    private gameManager gM;
    public float velocity;
    private Rigidbody2D rb;

    public Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gM = FindObjectOfType<gameManager>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * velocity;
            animator.SetTrigger("Click");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Object")
        {
            bump.Play();
            gM.GameOver();
        }
    }
}
