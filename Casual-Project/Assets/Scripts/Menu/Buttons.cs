using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    private Button button;


    public void StartGame() //Posiblemente la mejor parte de código que haya escrito, me llevo horas usar una built-in function
    {
        SceneManager.LoadScene(1);
    }


}
