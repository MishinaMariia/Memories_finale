using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguesTriggers : MonoBehaviour
{
    public GameObject GameObject;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.SetActive(false);
        }
    }
}
