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
    private Image bangImage;
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
    }
}