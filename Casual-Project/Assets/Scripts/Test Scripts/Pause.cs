using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour //Pausa el juego, este script va en el boton
{
    private bool pause = false;

    public void PauseGame()
    {
        if (pause == false)
        {
            Time.timeScale = 0f;
            pause = !pause;
        }
        else
        {
            Time.timeScale = 1f;
            pause = !pause;
        }
        
    }
}
