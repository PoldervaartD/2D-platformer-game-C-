using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;
    [SerializeField] private Text cherriesText;



    private bool levelCompleted = false;
        private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted && cherriesText.text == "Afval: 4")
        {
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 1f);
        }
    }
    
    private void CompleteLevel()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
