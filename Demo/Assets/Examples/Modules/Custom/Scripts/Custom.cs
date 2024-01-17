using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GamePush;
using TMPro;

using Examples.Console;

namespace Examples.Custom
{
    public class Custom : MonoBehaviour
    {
        public TMP_InputField nameInputField;
        public TMP_InputField argsInputField;

        public void CustomCall()
        {
            GP_Custom.Call(nameInputField.text, argsInputField.text == "" ? null : argsInputField.text);
            ConsoleUI.Instance.Log("Custom call " + nameInputField.text);
        }

        public void CustomReturn()
        {
            string result = GP_Custom.Return(nameInputField.text, argsInputField.text == "" ? null : argsInputField.text);
            if (result != null)
                ConsoleUI.Instance.Log("Custom return: " + result.ToString());
        }

        public void CustomValue()
        {
            string result = GP_Custom.Value(nameInputField.text);
            if (result != null)
                ConsoleUI.Instance.Log("Custom value: " + result.ToString());
        }

    }
}

