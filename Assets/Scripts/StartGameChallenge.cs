using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameChallenge : MonoBehaviour
{
    public AudioSource clickSound;
    // Start is called before the first frame upd

    private void playGame()
    {
        SceneManager.LoadScene("challenge");
    }

    //onclick
    public void onClick()
    {
        clickSound.Play();
        Invoke("playGame", 1.5f);
        
    }
}
