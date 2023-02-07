using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IntroUIScripts : MonoBehaviour
{
    public GameObject bg;
    public Image image;
    //public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(FadeInCoroutine());
        //if (bg.transform.position.y <= -5.0f)
        //{
        //    StartCoroutine(FadeInCoroutine());
        //}

        //if(image.GetComponent<Image>().color.a == 255)
        //{
        //    imgColor.a += alphaSpeed * Time.deltaTime;
        //    image.GetComponent<Image>().color = imgColor;
        //    textColor.a += alphaSpeed * Time.deltaTime;
        //    text.GetComponent<Image>().color = textColor;
        //}
    }

    IEnumerator FadeInCoroutine()
    {
        float alpha = 0.0f;
        while (alpha < 1.0f)
        {
            alpha += 0.1f;
            image.color = new Color(1, 1, 1, alpha);
            //text.color = new Color(1, 1, 1, alpha);
        }
    }
}
