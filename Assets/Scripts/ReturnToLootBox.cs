using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToLootBox : MonoBehaviour
{
    public void ReturnToBase()
    {
        SceneManager.LoadScene(0);
    }
}
