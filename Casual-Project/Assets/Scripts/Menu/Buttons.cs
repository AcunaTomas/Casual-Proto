using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    private Button button;


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }


}
