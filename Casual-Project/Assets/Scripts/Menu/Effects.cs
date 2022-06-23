using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    private Transform trs;
    private float dir;
    private float treshold;

    void Start()
    {
        Time.timeScale = 1f;
        trs = GetComponent<Transform>();
        dir = -0.5f;
        treshold = -0.0002f;
    }

  // Update is called once per frame
    void Update()
    {
        trs.Translate(dir * Time.deltaTime, 0f * Time.deltaTime, 0f * Time.deltaTime, Space.World);
        dir += treshold;
        if (dir < -2f)
        {
            treshold = 0.0002f;
        }
        else if (dir > 2f)
        {
            treshold = -0.0002f;
        }
    }
}
