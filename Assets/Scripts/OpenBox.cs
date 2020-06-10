using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenBox : MonoBehaviour
{
    
        public GameObject counter1;

    private void Start()
    {
        counter1 = GameObject.FindGameObjectWithTag("Counter");
    }

    public void Anything()
    {
        int smallNumber = 70;
        int maxMediumNumber = 90;
        //int bigNumber = 80;

        int randomNumber = Random.Range(0, 100);
        //Debug.Log(randomNumber);

        if (randomNumber < smallNumber)
        {
            counter1.GetComponent<Counter>().CommonCounter();
            SceneManager.LoadScene(1);
        }
        else if (randomNumber < maxMediumNumber)
        {
            counter1.GetComponent<Counter>().RareCounter();
            SceneManager.LoadScene(2);
        }
        else
        {
            counter1.GetComponent<Counter>().LegendaryCounter();
            SceneManager.LoadScene(3);
        }
    }

    
}
