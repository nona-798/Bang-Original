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
    private GameObject BackGround;
    [SerializeField]
    private Image mainUI;
    [SerializeField]
    private Image onlineUI;
    [SerializeField]
    private InputField playerName;
    [SerializeField]
    private InputField roomNum;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnlineScene()
    {
        BackGround.gameObject.SetActive(false);
        mainUI.gameObject.SetActive(false); // main visible
        onlineUI.gameObject.SetActive(true);
    }

    public void CloseOnlineScene()
    {
        onlineUI.gameObject.SetActive(false);
        BackGround.gameObject.SetActive(true);
        mainUI.gameObject.SetActive(true);
    }
}

