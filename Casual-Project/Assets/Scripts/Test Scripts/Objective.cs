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

    private void OnTriggerEnter(Collider other) // Revisa si colisiona con un bote, si ese es el caso, avisa al manager
    {
        Debug.Log("yes");
        if (other.name == boat.name)
        {
            boat.stopinput();
            Coll.SendMessageUpwards("UpdateArrivals"); //avisa al manager que llego el bote correcto
        }

    }



}
