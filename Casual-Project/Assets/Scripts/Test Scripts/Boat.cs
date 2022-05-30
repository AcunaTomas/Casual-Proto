using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    private Transform childtrs;
    private float dir = 0f;
    private float dirvert = 0f;
    private void Start()
    {
        childtrs = GetComponent<Transform>();
    }

    private void Update() //Mueve el bote a la dirección especificada
    {
        childtrs.Translate(dir * Time.deltaTime, dirvert * Time.deltaTime, 0f * Time.deltaTime, Space.World);
    }


    private void OnCollisionEnter(Collision collision)
    {
        StopMoving();
    }



    //Funciones de control de movimiento, Puede que sea necesario rehacerlas
    private void MoveLateral(float direct)
    {
        dir = direct;
        dirvert = 0f;
    }

    private void MoveVertical(float direct)
    {
        dirvert = direct;
        dir = 0f;
    }
    private void StopMoving()
    {
        dir = 0;
        dirvert = 0;

    }
}
