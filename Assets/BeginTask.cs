using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using var client = new HttpClient();
client.BaseAddress = new Uri(url);

public class BeginTask : MonoBehaviour
{
    int n;
    
    
    public void LoadScene(string Mygame)
    {
        SceneManager.LoadScene(Mygame);
    }
    public void OnButtonPress()
    {
        n++;
        Debug.Log("Button clicked " + n + " times.");
    }
    // Start is called before the first frame update


}

