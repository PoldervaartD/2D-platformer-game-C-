using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    [SerializeField] float startingTime = 10f;
    [SerializeField] Text TimerText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        TimerText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}