using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private AudioSource playerAudio;
    

    public float platforme_force = 0;
   

    private Rigidbody2D rb;

    private float movementX;
   
    public Text score;
    public static int bestScore = 0;
    public AudioClip jumpSound;
    public AudioClip deathSound;
    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAudio = GetComponent<AudioSource>();
        playerAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            playerAnim.SetTrigger("TurnLeft");
        }

        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            playerAnim.SetTrigger("TurnRight");
        }

        //recupere la position du player par rapport a la camera
        Vector3 scrPos = Camera.main.WorldToScreenPoint(transform.position);
        
        //si le player tombe alors on a perdu
        if (scrPos.y < Camera.main.transform.position.y)
        {
            playerAudio.PlayOneShot(deathSound, 1.0f);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Fin");
        }

        if (bestScore < (int)transform.position.y)
        {
            bestScore = (int)transform.position.y;
        }
        
        score.text = "score: " + bestScore.ToString();
      
    }

    private void OnMove(InputValue movementValue)

    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName != "Menu") //On interdit les mouvements dans la scene menu
        {
            
            Vector2 movementVector = movementValue.Get<Vector2>();

            movementX = movementVector.x;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("plateforme"))
        {
            
            rb.AddForce(Vector2.up * platforme_force, ForceMode2D.Impulse);
            playerAudio.PlayOneShot(jumpSound, 1.0f);
            
            playerAnim.SetTrigger("Jump");
        }

        if (collision.gameObject.CompareTag("trou"))
        {
            
            UnityEngine.SceneManagement.SceneManager.LoadScene("Fin");
        }

        //Si le player sort par la gauche
        if (collision.gameObject.CompareTag("Left"))
        {
           
            transform.position = new Vector3(6, transform.position.y, transform.position.z);
        }

        //Si le player sort par la droite
        if (collision.gameObject.CompareTag("Right"))
        {
           
            transform.position = new Vector3(-4f, transform.position.y, transform.position.z);
        }

    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(movementX,0.0f);

        rb.AddForce(movement * speed);
    }

}