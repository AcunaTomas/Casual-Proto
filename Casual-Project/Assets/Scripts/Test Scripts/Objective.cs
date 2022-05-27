using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    private Transform Coll;
    void Start()
    {
        Debug.Log("Is This Even Running?");
        Coll = GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("yes");
        Coll.SendMessageUpwards("EndGame");
    }
}
