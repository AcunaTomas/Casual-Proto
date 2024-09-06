using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationlmao : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float target = 90f;
    void Update()
    {   
        float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.z, target,  2 *Time.deltaTime);
        if (angle >= target)
        {
            target += target;
        }
        transform.eulerAngles = new Vector3(0,0,angle);
    }
}
