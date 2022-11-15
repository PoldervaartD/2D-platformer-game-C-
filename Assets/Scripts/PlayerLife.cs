using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public float levelTime;
    private bool isCounting = true;
    public static int health = 3;
    public Image totalhealthBar;
    public Image currenthealthBar;
    public Text TimerText;


    private void Start()
    {
        levelTime = 40;
        Debug.Log(health);
        currenthealthBar.fillAmount = (float)health / 10;
    }

    private void Update()
    {
        if (isCounting)
        { 
            if (levelTime > 0)
            {
                levelTime -= Time.deltaTime;
                TimerText.text = Mathf.RoundToInt(levelTime).ToString();
            }

            else if (levelTime <= 0)
            {
                levelTime = 0;
                TimeIsOver();
                isCounting = false;
            }
        }

        if (health <= 0)
        {
            health = 3;
            SceneManager.LoadScene(0);
        }

    }

    public void TakeDamage()
    {
        health--;
        ReloadLevel();

    }

    public void AddHealth()
    { if (health < 3)
        {
            health++;
            currenthealthBar.fillAmount = (float)health / 10;
        }
    }

    private void TimeIsOver()
    {
        health--;
        ReloadLevel();
    }

    private void ReloadLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }
}
