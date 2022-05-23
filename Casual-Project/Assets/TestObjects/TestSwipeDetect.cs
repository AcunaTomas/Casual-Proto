using System.Collections;
using UnityEngine;

public class TestSwipeDetect : MonoBehaviour
{

    [SerializeField]
    private float mindistance = .2f;
    [SerializeField]
    private float maxtime = 1f;
    [SerializeField, Range(0f, 1f)]
    private float dirThreshold = .9f;


    public InputManagerTest inputManager;
    private Vector2 initalposition;
    private float starttime;
    private Vector2 endposition;
    private float endtime;

    private void OnEnable()
    {
        inputManager.OnStartTouch += swipeStart;
        inputManager.OnEndTouch += swipeEnd;
    }
    private void OnDisable()
    {
        inputManager.OnStartTouch -= swipeStart;
        inputManager.OnEndTouch -= swipeEnd;
    }


    private void swipeStart(Vector2 position, float time)
    {
        initalposition = position;
        starttime = time;
    }

    private void swipeEnd(Vector2 position, float time)
    {
        endposition = position;
        endtime = time;
        detect();
    }
    
    private void detect()
    {
        if (Vector2.Distance(initalposition, endposition) >= mindistance && (endtime - starttime) <= maxtime)
        {
            Debug.Log("xd");
            Vector2 direction = endposition - initalposition;
            Vector2 dir = new Vector2(direction.x, direction.y).normalized;
            swipeDirection(dir);
        }

    }

    private void swipeDirection(Vector2 dir)
    {
        if (Vector2.Dot(Vector2.up, dir) > dirThreshold)
        {
            Debug.Log("Up");
        }
        else if (Vector2.Dot(Vector2.down, dir) > dirThreshold)
        {
            Debug.Log("Down");
        }
        else if (Vector2.Dot(Vector2.left, dir) > dirThreshold)
        {
            Debug.Log("Left");
        }
        else if (Vector2.Dot(Vector2.right, dir) > dirThreshold)
        {
            Debug.Log("Right");
        }
    }
}
