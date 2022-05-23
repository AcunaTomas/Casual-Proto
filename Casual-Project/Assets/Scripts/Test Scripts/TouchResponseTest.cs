using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchResponseTest : MonoBehaviour
{
    private Transform trs;

    private void Start()
    {
        trs = GetComponent<Transform>();
    }
    
    public void MoveBoat(int a, int b)
    {
        Debug.Log("It Moves!");
    }
}
