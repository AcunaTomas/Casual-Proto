using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform childtrs;
    private float dir = 0f;
    private float dirvert = 0f;
    private void Start()
    {
        childtrs = GetComponent<Transform>();
    }

    private void Update()
    {
        childtrs.Translate(dir * Time.deltaTime, dirvert * Time.deltaTime, 0f * Time.deltaTime, Space.World);
    }
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
    }
}
