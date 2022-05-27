using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boats : MonoBehaviour
{
    private Transform trs;

    private void Start()
    {
        trs = GetComponent<Transform>();
    }

    public void MoveBoats(string direction)
    {
        switch (direction)
        {
            case "Right":
                trs.BroadcastMessage("MoveLateral", 1.5f);
                break;

            case "Left":
                    trs.BroadcastMessage("MoveLateral", -1.5f);
                    break;

            case "Up":
                trs.BroadcastMessage("MoveVertical", 1.5f);
                break;

            case "Down":
                trs.BroadcastMessage("MoveVertical", -1.5f);
                break;
            default:
                break;
        }
            
    }

}
