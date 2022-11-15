using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public int fruits = 0;

    [SerializeField] private Text cherriesText;

    [SerializeField] private AudioSource collectionSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruits"))
        {
            collectionSound.Play();
            Destroy(collision.gameObject);
            fruits++;
            cherriesText.text = "Afval: " + fruits;
        }
    }
}
