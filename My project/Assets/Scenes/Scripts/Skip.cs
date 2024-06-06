using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject dialogue;
    public GameObject Skip;
    void Start()
    {
        Time.timeScale = 0f;
       
    }

    public void skip_all()
    {
        dialogue.SetActive(false);
        Skip.SetActive(false);
        Time.timeScale = 1f;
    }
    public void skip()
    {
        Skip.SetActive(false);
    }


}
