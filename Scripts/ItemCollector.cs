using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int Cherries = 0;
    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource cherrySoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cherry")
        {
            cherrySoundEffect.Play();
            Destroy(collision.gameObject);
            Cherries++;
            cherriesText.text = "Cherries:" + Cherries;
        }
    }
}