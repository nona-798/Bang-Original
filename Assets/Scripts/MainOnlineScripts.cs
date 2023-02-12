using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class MainOnlineScripts : MonoBehaviour
{
    public Button create;
    public Button find;
    public InputField inputNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LoadScene()
    {
        SceneManager.LoadScene("MakeRoom");
    }
}
