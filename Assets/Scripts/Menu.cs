using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public string nivel;


    public void Jugar()
    {
        SceneManager.LoadScene(nivel);
    }
    
    public void Salir()
    {
        Application.Quit();
    }

}
