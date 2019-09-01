using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ViewModel : MonoBehaviour 
{
    public Text buttonText;
    public GameObject SecondFloor;
    
    public Slider slider;

    public void Slider_Changed(float newValue)
    {
        Vector3 pos = SecondFloor.transform.position;
        pos.y = newValue;
        SecondFloor.transform.position = pos;
    }

    public void Button_Click()
    {
        Debug.Log("Hello, World!");
    }

    public void Button_String(string msg)
    {
        buttonText.text = msg;
    }

    public void Toggle_Changed(bool newValue)
    {
        SecondFloor.SetActive(newValue);
        slider.interactable = newValue;
    }

    public void Text_Changed(string newText)
    {
        float temp = float.Parse(newText);
        SecondFloor.transform.localScale = new Vector3(temp, temp, temp);
    }




}
