using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{   //TODO Implementar Relaciones Editables entre bote y objetivo
    public Boat boat;
    private Transform Coll;
    void Start()
    {
        Debug.Log("Is This Even Running?");
        Coll = GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other) //TODO: Placeholder, esto tiene que fijarse si el bote correcto lo tocó.
    {
        Debug.Log("yes");
        if (other.name == boat.name)
        {
            Coll.SendMessageUpwards("EndGame");
        }

    }
}
