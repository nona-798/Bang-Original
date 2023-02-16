using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIScripts : MonoBehaviour
{
    [SerializeField]
    private GameObject bg;
    [SerializeField]
    private Image image;
    [SerializeField]
    private TMP_Text madeText;
    [SerializeField]
    private Text buttonText;
    [SerializeField]
    private Image IntroUI;
    [SerializeField]
    private Image mainUI;

    float alpha = 0.0f;
    bool intro = false;

    //public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        intro = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (intro == false && bg.transform.position.y >= -5.0f)
        {
            bg.transform.Translate(new Vector3(0.0f, -5.0f * Time.deltaTime, 0.0f));
        }
        if (bg.transform.position.y <= -5.0f)
        {
            FadeIn();
            if (Input.anyKey)
            {
                FadeOut();
                intro = true;
            }
        }
        if(intro == true)
        {
            bg.transform.Translate(new Vector3(0.0f, 5.0f * Time.deltaTime, 0.0f));
            if (bg.transform.position.y <= -1.0f)
            {
                bg.transform.Translate(new Vector3(0.0f, 0.0f * Time.deltaTime, 0.0f));
                IntroUI.gameObject.SetActive(false);
                mainUI.gameObject.SetActive(true);
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
    void FadeOut()
    {
        while (alpha > 0.0f)
        {
            alpha -= 0.03f * Time.deltaTime;
            image.color = new Color(1, 1, 1, alpha);
            madeText.color = new Color(1, 1, 1, alpha);
            buttonText.color = new Color(1, 1, 1, alpha);
            if (alpha < 0.0f)
            {
                break;
            }
        }
    }
}
