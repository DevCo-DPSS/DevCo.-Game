using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad : MonoBehaviour
{
    public Text[] display;
    public int counter = 0;
    public int keyno;
    public bool isChanged = false;
    public KeyPad keyPad;
    public string correctAnswer;
    public string givenAnswer;

    private void Update()
    {
        if (isChanged == true)
        {
            isChanged = false;
            Enter(keyno);
        }
    }

    public void ButtonPress()
    {
        keyPad.keyno = keyno;
        keyPad.isChanged = true;
    }

    public void Enter(int keyno)
    {
        display[counter].text = keyno.ToString();
        givenAnswer += keyno.ToString();
        counter++;
        if (counter >= 3 && givenAnswer != correctAnswer)
        {
            Debug.Log("done");
            counter = 0;
            givenAnswer = "";
            foreach (Text text in display)
            {
                text.text = "0";
            }
        }
    }
}
