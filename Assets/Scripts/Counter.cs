using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int common, rare, legendary = 0;
    public Text commonText;
    public Text rareText;
    public Text legendaryText;
    public void Start()
    {

        if(GameObject.FindGameObjectsWithTag("Counter").Length > 1)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this);    
    }

    private void Update()
    {
        commonText.text = "Common: " + common;
        rareText.text = "Rare: " + rare;
        legendaryText.text = "Legendary: " + legendary;
    }
    public void CommonCounter()
    {
        common++;
    }
    public void RareCounter()
    {
        rare++;
    }
    public void LegendaryCounter()
    {
        legendary++;
    }

}
