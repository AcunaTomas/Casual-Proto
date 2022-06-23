using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public Button butts;
    public TextMeshProUGUI texto;
    public Button pausebutt;
    public Image img;

    public void showEndScreen(string a, int state)
    {
        Time.timeScale = 0f;
        pausebutt.gameObject.SetActive(false);
        butts.gameObject.SetActive(true);
        img.gameObject.SetActive(true);
        butts.transform.SendMessage("gameEnded", state);
        texto.gameObject.SetActive(true);
        texto.SetText(a);


    }

 

}
