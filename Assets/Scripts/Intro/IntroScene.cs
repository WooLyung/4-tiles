using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    void Start()
    {
        Invoke("ChangeScene", 3.8f);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Map");
    }
}
