using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Balloon : MonoBehaviour
{
    //private bool isDead = false;
    public static Balloon instance;
    //Balloon sound
    public AudioSource balloonSound;
    // Movement speed
    public int balloonSpeed = (ScoreManager.speed);
    public Text speedText;
    // flying force
    public float force = 500;
    // score
    public static int currentScore;

    
    // Start is called before the first frame update
    void Start()
    {
        currentScore = ScoreManager.score;
        //InvokeRepeating("increaseSpeed", 1f, 1f);
        
        GetComponent<Rigidbody2D>().velocity = Vector2.right * balloonSpeed ;  
        speedText.text = "Speed: " + balloonSpeed.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // Flying
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            GetComponent<Rigidbody2D>().AddForce(Vector2.down * force);
            balloonSound.Play();
        }

        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }

        //speed = speed + 1;
    }


    

    void OnCollisionEnter2D(Collision2D coll)
    {
    // Restart
        SceneManager.LoadScene ("_GameOver_Screen");
    }

    void Die() {
        SceneManager.LoadScene ("_GameOver_Screen");
    }

    

  
    

}
