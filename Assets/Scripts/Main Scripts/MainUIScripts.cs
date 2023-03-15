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

    public void OnlineScene()
    {
        BackGround.gameObject.SetActive(false);
    }

    public void CloseOnlineScene()
    {
        BackGround.gameObject.SetActive(true);
    }
}

