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
    public Text buttonText;

    float alpha = 0.0f;
    float textAlpha = 1.0f;
    bool Pop = false;
    bool UpDown = false;

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
            if(Input.anyKey)
            {
                NextScene();
            }
        }
    }

    void FadeIn()
    {
        while (alpha < 1.0f)
        {
            alpha += 0.03f * Time.deltaTime;
            image.color = new Color(1, 1, 1, alpha);
            madeText.color = new Color(1, 1, 1, alpha);
            buttonText.color = new Color(1, 1, 1, alpha);
            if (alpha > 1.0f)
            {
                //Pop = true;
                break;
            }
        }
    }

    private void PopPop()
    {
        while(true)
        {
            if(textAlpha >= 1.0f)
            {
                UpDown = false;
            }
            else if(textAlpha <= 0.0f)
            {
                UpDown = true;
            }
            if(UpDown == false)
            {
                textAlpha -= 0.03f * Time.deltaTime;
            }
            else
            {
                textAlpha += 0.03f * Time.deltaTime;
            }
            buttonText.color = new Color(1, 1, 1, alpha);
            if(Input.anyKey)
            {
                NextScene();
                break;
            }
        }
    }

    private void NextScene()
    {
        SceneManager.LoadScene("Main");
    }
}
