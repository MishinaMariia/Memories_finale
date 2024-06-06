using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int item1;
    public int item2;
    public int item3;
    public int item4;
    public int item5;


    public PlayerData (figures figures)
    {
        item1 = figures.item1;
        item2 = figures.item2;
        item3 = figures.item3;
        item4 = figures.item4;
        item5 = figures.item5;


    }
}
