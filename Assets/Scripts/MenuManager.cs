using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void OpenPrototype()
    {
        SceneManager.LoadScene("Prototype 1");
    }

    public void OpenChallenge()
    {
        SceneManager.LoadScene("Challenge 1");
    }
}
