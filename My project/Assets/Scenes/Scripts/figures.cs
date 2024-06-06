using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class figures : MonoBehaviour
{
    public static int item1 = 0;
    public static int item2 = 0;
    public static int item3 = 0;
    public static int item4 = 0;
    public static int item5 = 0;

    public TMP_Text textMy;

    public int count;

    public static figures Instance { get; private set; }

    private void Start()
    {
        count = 0;
    }


    void Update()
    {
        count = item1 + item2 + item3 + item4 + item5;
        textMy.text = count.ToString() + " / 5";

    }


    public void SavePlayer ()
    {
        SaveSystem.SavePlayer(this);
    }
   
    public void LoadPlayer ()

    {
        PlayerData data = SaveSystem.LoadPlayer();

        

        item1 = data.item1;
        item2 = data.item2;
        item3 = data.item3;
        item4 = data.item4;
        item5 = data.item5;

       

    }
    
}
