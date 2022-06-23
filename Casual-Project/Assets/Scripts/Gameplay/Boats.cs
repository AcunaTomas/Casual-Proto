using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boats : MonoBehaviour //Control de los botes, toma el swipe y mueve los barcos a esa direcci�n.
{
    private Transform trs;
    private AudioSource audios;
    private void Start()
    {
        audios = GetComponent<AudioSource>();
        trs = GetComponent<Transform>();
    }

    public void MoveBoats(string direction)
    {
        audios.Play();
        switch (direction)
        {
            case "Right":
                trs.BroadcastMessage("MoveLateral", 5f);
                break;

            case "Left":
                    trs.BroadcastMessage("MoveLateral", -5f);
                    break;

            case "Up":
                trs.BroadcastMessage("MoveVertical", 5f);
                break;

            case "Down":
                trs.BroadcastMessage("MoveVertical", -5f);
                break;
            default:
                break;
        }
            
    }

}
