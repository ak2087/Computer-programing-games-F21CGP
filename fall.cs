using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fall : MonoBehaviour
{
    public float height = 0f;

    void Update()
    {
        if (transform.position.y < height)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
}
