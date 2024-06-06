using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class dialogue_script : MonoBehaviour
{
    public Button button;
    public Button bubble;
    void SwitchButtons()
    {

        bubble.gameObject.SetActive(true);
        button.gameObject.SetActive(false);
    }

    public void First()
    {
        SwitchButtons();
    }

    public void Picture()
    {
        TMP_Text textComponent = bubble.GetComponentInChildren<TMP_Text>();
        textComponent.text = "Это мама.";
        Time.timeScale = 0f;
        SwitchButtons();
        figures.item1 = 1;
    }


    public void TV()
    {
        TMP_Text textComponent = bubble.GetComponentInChildren<TMP_Text>();
        textComponent.text = "Телевизор. Мама запирала меня в этой комнате. Мама говорила, что мне так будет лучше.";
        Time.timeScale = 0f;
        SwitchButtons();
        figures.item2 = 1;
    }

    public void Clock()
    {
        TMP_Text textComponent = bubble.GetComponentInChildren<TMP_Text>();
        textComponent.text = "Тик-так. Тик-так. Я не услышал шагов мамы. Часы были слишком громкие. Тик-так.";
        Time.timeScale = 0f;
        SwitchButtons();
        figures.item3 = 1;
    }
    public void Dining_Table()
    {
        TMP_Text textComponent = bubble.GetComponentInChildren<TMP_Text>();
        textComponent.text = "Здесь мама ела. Мама всегда была голодной.";
        Time.timeScale = 0f;
        SwitchButtons();
        figures.item4 = 1;
    }

    public void Desk()
    {
        TMP_Text textComponent = bubble.GetComponentInChildren<TMP_Text>();
        textComponent.text = "Мама всегда была здесь. Она говорила, что у нее много работы.";
        Time.timeScale = 0f;
        SwitchButtons();
        figures.item5 = 1;
    }
    public void Grave()
    {
        TMP_Text textComponent = bubble.GetComponentInChildren<TMP_Text>();
        textComponent.text = "Точно... Мама меня съела. Я не могу уйти отсюда...";
        Time.timeScale = 0f;
        SwitchButtons();

    }

    
}
