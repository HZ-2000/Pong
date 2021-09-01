using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class help : MonoBehaviour
{
    public void helpPage ()
    {
        SceneManager.LoadScene("Help Screen");       
    }

    public void return2game ()
    {
        SceneManager.LoadScene("Pong");       
    }
}
