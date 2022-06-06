using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectiveController : MonoBehaviour //Reemplazo del gameManager para testing, controla si todos los botes llegaron a sus destinos
{
    private Transform trs;
    private int boatsarrived = 0;

    private void Start()
    {
        trs = GetComponent<Transform>();
    }

    private void EndGame() //Termina el nivel y avanza al siguiente nivel
    {
        Debug.Log("WIN");
        SceneManager.LoadScene("Testing Scene");
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

