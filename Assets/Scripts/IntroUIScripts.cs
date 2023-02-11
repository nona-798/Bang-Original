using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class IntroUIScripts : MonoBehaviour
{
    public GameObject bg;
    public Image image;
    public TMP_Text madeText;
    public TMP_Text buttonText;

    float alpha = 0.0f;
    bool beep = false;
    bool alphaM = false;
    //public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(FadeInCoroutine());
        if (bg.transform.position.y <= -5.0f)
        {
            FadeIn();

            if (Input.anyKey)
            {
                // Intro -> Main
                NextScene();
            }
        }
    }

    void FadeIn()
    {
        while (alpha < 1.0f)
        {
            alpha += 0.05f * Time.deltaTime;
            image.color = new Color(1, 1, 1, alpha);
            madeText.color = new Color(1, 1, 1, alpha);
            buttonText.color = new Color(1, 1, 1, alpha);
            if (alpha > 1.0f)
            {
                break;
            }
        }
    }

    void NextScene()
    {
        SceneManager.LoadScene("Main");
    }
}
