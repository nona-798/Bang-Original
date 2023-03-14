using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Mirror;

public class OnlineScripts : MonoBehaviour
{
    [SerializeField]
    private InputField nameInput;
    [SerializeField]
    private GameObject createRoomUI;

    public void CreateRoom()
    {
        var manager = BangRoomManager.singleton;
        // 방 설정 작업 처리
        //
        manager.StartHost();
    }

    public void OnClickCreateRoomButton()
    {
        if(nameInput.text != "")
        {
            PlayerSetting.Name = nameInput.text;
            createRoomUI.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
            nameInput.GetComponent<Animator>().SetTrigger("on");
        }
    }

    public void OnClickEnterGameRoomButton()
    {
        if (nameInput.text != "")
        {
            var manager = BangRoomManager.singleton;
            manager.StartClient();
        }
        else
        {
            nameInput.GetComponent<Animator>().SetTrigger("on");
        }
    }
}
