using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectiveController : MonoBehaviour //TODO: Unused, Reemplazo del gameManager para testing
{
    private Transform trs;


    private void Start()
    {
        trs = GetComponent<Transform>();
    }

    private void EndGame()
    {
        SceneManager.LoadScene("Testing Scene");
    }
        

}

