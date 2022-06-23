using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Boat : MonoBehaviour
{
    private Transform childtrs;
    private Rigidbody rigid;
    public EndScreen end;
    private float dir = 0f;
    private float dirvert = 0f;
    private bool canmove = true;
    
    private void Start()
    {
        childtrs = GetComponent<Transform>();
        rigid = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() //Mueve el bote a la direcci�n especificada
    {
        if (canmove)
        {
            childtrs.Translate(dir * Time.deltaTime, dirvert * Time.deltaTime, 0f * Time.deltaTime, Space.World);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.parent.GetComponent<Transform>().name == "Boats")
        {
            end.showEndScreen("¡No Te Rindas!", 0);
        }
        StopMoving();
    }




    //Funciones de control de movimiento, Puede que sea necesario rehacerlas
    private void MoveLateral(float direct)
    {
        if (canmove)
        {
            dir = direct + (0.75f * direct);
            dirvert = 0f;
            childtrs.eulerAngles = new Vector3(
                -90 + (90 * (direct / 5)),
                90,
                -90 
            );
        }

    }

    private void MoveVertical(float direct)
    {
        if (canmove)
        {
            dirvert = direct + (0.75f * direct);
            dir = 0f;
            childtrs.eulerAngles = new Vector3(
                270,
                90,
                -90
            );
        }

    }
    private void StopMoving()
    {
        dir = 0;
        dirvert = 0;


    }
    public void stopinput()
    {
        canmove = false;
    }
}
