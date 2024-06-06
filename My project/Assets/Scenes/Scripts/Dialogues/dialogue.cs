

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public string[] dialogue;
    private int index = 0;


    public void Settings()
    {
        dialogueText.text = "";
        if (!dialoguePanel.activeInHierarchy)
        {
            dialoguePanel.SetActive(true);
            dialogueText.text = dialogue[index];
        }
        else if (dialogueText.text == dialogue[index])
        {
            NextLine();
        }
    }

  

    public void RemoveText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
        Time.timeScale = 1f;
    }



    public void NextLine()
    {
        if (index < 2)
        {
            
            dialogueText.text = "";
            dialogueText.text = dialogue[index];
            index++;
        }
        else
        {
            RemoveText();
        }
    }

}
