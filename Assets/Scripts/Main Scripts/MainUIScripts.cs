using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;
using Mirror;

public class MainUIScripts : MonoBehaviour
{
    [SerializeField]
    private GameObject bg;
    [SerializeField]
    private Text buttonText;
    [SerializeField]
    private Image IntroUI;
    [SerializeField]
    private Image mainUI;

    float scroll = 1.0f;
    float alpha = 0.05f;
    bool intro = false;
    bool menu = false;
    bool blink = false;

    // Start is called before the first frame update
    void Start()
    {
        IntroUI.gameObject.SetActive(false);
        mainUI.gameObject.SetActive(false);
        menu = false;
        intro = true;
        blink = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(menu == false)
        {
            if (intro == true)
            {
                IntroScene();
                Invoke("PressAnyKey",0.5f);
            }
            if (intro == false)
            {
                MainScene();
            }
        }
        if(menu == true)
        {

        }
        
    }

    void IntroScene()
    {
        while (bg.transform.position.y >= -5.0f) // 5에서 -5로
        {
            bg.transform.Translate(0.0f, -1.0f * scroll * Time.deltaTime / 2, 0.0f); // --
            if (bg.transform.position.y <= -5.0f) // -5에서 멈추기
            {
                IntroUI.gameObject.SetActive(true); // intro visible
                blink = true;
                break;
            }
        }
        if (Input.anyKey)
        {
            intro = false;
            IntroUI.gameObject.SetActive(false);
        }
    }
    void MainScene()
    {
        while (bg.transform.position.y <= -1.0f) // -5 에서 -1로
        {
            bg.transform.Translate(0.0f, 1.0f * scroll * Time.deltaTime / 2, 0.0f); // ++
            if (bg.transform.position.y >= -1.0f) // -1에서 멈추기
            {
                mainUI.gameObject.SetActive(true); // main visible
                menu = true;
                break;
            }
        }
    }
    void PressAnyKey()
    {
        if (blink == true)
        {
            alpha = 0.0f;
            buttonText.color = new Color(1.0f, 1.0f, 1.0f, alpha);
            if(alpha == 0.0f)
            {
                blink = false;
            }
        }
        else
        {
            alpha = 1.0f;
            buttonText.color = new Color(1.0f, 1.0f, 1.0f, alpha);
            if (alpha == 1.0f)
            {
                blink = true;
            }
        }
    }

    public void ChangeSceneByCreate()
    {
        SceneManager.LoadScene("MakingRoom");
    }
}

