using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectiveController : MonoBehaviour
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

