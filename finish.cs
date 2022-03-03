using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene("Finish");
    }
}
