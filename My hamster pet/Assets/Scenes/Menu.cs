using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private string nomeDoHamster;

    public void Hamster1()
    {
        SceneManager.LoadScene("SceneHamster1");
    }

    public void Hamster2() 
    {
        SceneManager.LoadScene("SceneHamster2");
    }

    public void Hamster3()
    {
        SceneManager.LoadScene("SceneHamster3");
    }
}
