using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Enemy_Sideways : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerLife>().TakeDamage();
        }
    }
}