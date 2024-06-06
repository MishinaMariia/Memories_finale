using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning_trigger : MonoBehaviour
{
    public Animator anim;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger("Warning");
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger("Warning");
        }
    }
}
