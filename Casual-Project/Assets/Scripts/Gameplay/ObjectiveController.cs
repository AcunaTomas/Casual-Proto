using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectiveController : MonoBehaviour //Reemplazo del gameManager para testing, controla si todos los botes llegaron a sus destinos
{
    private Transform trs;
    private int boatsarrived = 0;
    public EndScreen endScreen;

    private void Start()
    {
        Time.timeScale = 1f;
        trs = GetComponent<Transform>();
    }

    private void EndGame() //Termina el nivel y avanza al siguiente nivel
    {
        Debug.Log("WIN");
        endScreen.showEndScreen("Nivel Superado!", 1);
    }

    private void LoseGame() //Termina el nivel y lo reinicia
    {
        Debug.Log("LOSE");
        endScreen.showEndScreen("No Te Rindas!", 0);

    }
    private void Update()
    {
        if (boatsarrived >= trs.childCount)
        {
            EndGame();
        }
    }

    private void UpdateArrivals() //avisa que llego un bote
    {
        boatsarrived += 1;
    }

    
}

