using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mirror;
public class CreateRoomScripts : MonoBehaviour
{
    [SerializeField]
    private Image Loading;
    bool done;
    // Start is called before the first frame update
    void Start()
    {
        done = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(done == false)
        {
            CreateRoom();
        }
        if (done == true)
        {
            SceneManager.LoadScene("GameRoom");
        }
    }

    void CreateRoom()
    {
        var manager = BangRoomManager.singleton;
        // �� ���� �۾� ó��
        //
        manager.StartHost();
        done = true;
    }
}
