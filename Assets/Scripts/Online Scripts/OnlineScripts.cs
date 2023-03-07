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
}
