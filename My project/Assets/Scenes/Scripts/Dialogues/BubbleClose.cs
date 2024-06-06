using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BubbleClose : MonoBehaviour
{
    public Button bubble;
    public Button final;
    public GameObject col;
    int check = 0;

   
    public void Close()
    {
        figures figures = FindObjectOfType<figures>();
        if (figures != null)
        {
            Time.timeScale = 1f;
            bubble.gameObject.SetActive(false);
            int check = figures.count;
            Debug.Log("Значение check: " + check);
            if (check == 5)
            {
                final.gameObject.SetActive(true);
                col.gameObject.SetActive(false);

                TMP_Text textComponent = final.GetComponentInChildren<TMP_Text>();
                textComponent.text = "Я все нашел. Пора пойти посмотреть, что на улице.";
            }
        }
        else
        {
            Debug.LogWarning("Объект не найден");
        }

    }
    public void Close_final()
    {
        Time.timeScale = 1f;
        bubble.gameObject.SetActive(false);
        SceneManager.LoadScene(0);

    }

    public void Close_prefinal()
    {
        Time.timeScale = 1f;
        bubble.gameObject.SetActive(false);

    }

}
