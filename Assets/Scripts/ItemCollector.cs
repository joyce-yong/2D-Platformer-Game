using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;

    [SerializeField] private TextMeshProUGUI cherriesText;

    [SerializeField] private AudioSource collectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if game object collide with smthg(check if its cherry with the tag)
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;
            //this is ^ equivalent to cherries = cherries +1
            cherriesText.text = "Cherries: " + cherries;
        }
    }

}
