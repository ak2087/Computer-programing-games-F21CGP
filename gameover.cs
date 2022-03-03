using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
   
    public void ResetButton()
    {
        SceneManager.LoadScene("Level1");

    }
    public void Reset1Button()
    {
        SceneManager.LoadScene("Level2");

    }
}