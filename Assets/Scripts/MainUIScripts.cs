using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class MainUIScripts : MonoBehaviour
{
    public GameObject bg;
    public Image image;
    public Button start;
    public Button howto;
    public Button option;
    public Button exit;
    

    float alpha = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        image.color = new Color(1, 1, 1, 0);
        start.gameObject.SetActive(false);
        howto.gameObject.SetActive(false);
        option.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(bg.transform.position.y >= -1)
        {
            FadeIn();
        }
    }
    void FadeIn()
    {
        image.color = new Color(1, 1, 1, 1);
        ButtonVisible();
    }

    void ButtonVisible()
    {
        start.gameObject.SetActive(true);
        howto.gameObject.SetActive(true);
        option.gameObject.SetActive(true);
        exit.gameObject.SetActive(true);
    }
}

