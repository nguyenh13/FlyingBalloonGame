using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameEndless : MonoBehaviour
{
    public AudioSource clickSound;
    // Start is called before the first frame upd

    private void playGame()
    {
        SceneManager.LoadScene("endless");
    }

    //onclick
    public void onClick()
    {
        clickSound.Play();
        Invoke("playGame", 1.5f);
        
    }
}
