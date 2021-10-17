using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControllerMenu : MonoBehaviour
{
    public float speed = 0;


    public float platforme_force = 0;


    private Rigidbody2D rb;

    private float movementX;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("plateforme"))
        {

            rb.AddForce(Vector2.up * platforme_force, ForceMode2D.Impulse);
        }


    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(movementX, 0.0f);

        rb.AddForce(movement * speed);
    }

}