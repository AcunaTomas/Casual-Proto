using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Continuebutton : MonoBehaviour
{
    private Button button;
    private int gotonextscene;
    void Start()
    {
        button = GetComponent<Button>();
    }

    public void Continue()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + gotonextscene);
    }

    public void gameEnded(int b)
    {
        gotonextscene = b;

    }
}
