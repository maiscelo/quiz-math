using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UserMenager : MonoBehaviour
{
    int n;
    public InputField nameInput;
    public Button submitButton;
    // Start is called before the first frame update
    //using var client = new HttpClient();
    //client.BaseAddress = new Uri(url);
    public void OnButtonPress()
    {
        n++;
        Debug.Log("Button clicked " + n + " times.");
    }
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //submitButton.onClick.Invoke();
        //Debug.Log("butao pressionado");
    }
}
