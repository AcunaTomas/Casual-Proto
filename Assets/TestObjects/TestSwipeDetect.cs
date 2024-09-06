using System.Collections;
using UnityEngine;

public class TestSwipeDetect : MonoBehaviour //Codigo de detecci�n de Swipes
{
    //Valores configurables para la detecci�n de swipes, valores de tolerancia, rango y tiempo de swipes
    public Boats boats;
    [SerializeField]
    private float mindistance = .1f;
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

    //Eventos usados para calcular si fue un swipe o no
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
    
    //Detectar swipe
    private void detect()
    {
        if (Vector2.Distance(initalposition, endposition) >= mindistance && (endtime - starttime) <= maxtime)
        {

            Vector2 direction = endposition - initalposition;
            Vector2 dir = new Vector2(direction.x, direction.y).normalized;
            swipeDirection(dir);
        }

    }

    //Detecci�n de la direcci�n del swipe
    private void swipeDirection(Vector2 dir)
    {
        if (Vector2.Dot(Vector2.up, dir) > dirThreshold)
        {
            boats.MoveBoats("Up");
        }
        else if (Vector2.Dot(Vector2.down, dir) > dirThreshold)
        {
            boats.MoveBoats("Down");
        }
        else if (Vector2.Dot(Vector2.left, dir) > dirThreshold)
        {
            boats.MoveBoats("Left");
        }
        else if (Vector2.Dot(Vector2.right, dir) > dirThreshold)
        {
            boats.MoveBoats("Right");
        }
    }
}
