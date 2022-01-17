using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int apel = 0;
    [SerializeField] private Text ApelText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apel"))
        {
            Destroy(collision.gameObject);
            apel++;
            ApelText.text = "Apel :" + apel;
        }
    }
}