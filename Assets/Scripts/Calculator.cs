using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{

    [SerializeField]
    Text inputField;

    string inputString;
    int[] number = new int[2];
    string operatorSymbol;
    int i = 0;
    int result;
    bool displayedResults = false;

    public void ButtonPressed()
    {
        if (displayedResults == true)
        {
            inputField.text = "";
            inputString = "";
            displayedResults = false;
        }

        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        string buttonvalue = EventSystem.current.currentSelectedGameObject.name;
        inputString += buttonvalue;

        int arg;
        if (int.TryParse(buttonvalue, out arg))
        {
            if (i > 1) i = 0;
            number[i] = arg;
            i = i + 1;
        }
        else
        {
            switch (buttonvalue)
            {
                case "+":
                    operatorSymbol = buttonvalue;
                    break;
                case "-":
                    operatorSymbol = buttonvalue;
                    break;
                case "*":
                    operatorSymbol = buttonvalue;
                    break;
                case "/":
                    operatorSymbol = buttonvalue;
                    break;
                case "=":
                    switch (operatorSymbol) {
                        case "+":
                            result = number[0] + number[1];
                            break;
                        case "-":
                            result = number[0] - number[1];
                            break;
                        case "*":
                            result = number[0] * number[1];
                            break;
                        case "/":
                            result = number[0] / number[1];
                            break;
                       
                    }

                    displayedResults = true;
                    inputString = result.ToString();
                    number = new int[2];
                    break;
            }
        }

      

        inputField.text = inputString;

    }

}