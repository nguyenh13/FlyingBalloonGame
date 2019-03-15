using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButton : MonoBehaviour
{
    public AudioSource clickSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void playGame()
    {
        SceneManager.LoadScene("_Start_Screen");
    }

    //onclick
    public void onClick()
    {
        clickSound.Play();
        Invoke("playGame", 1.5f);
        
    }
}
