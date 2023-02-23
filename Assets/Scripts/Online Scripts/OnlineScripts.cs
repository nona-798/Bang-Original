using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class OnlineScripts : MonoBehaviour
{
    private CreateGameRoomData roomData;
    int min = 0; 
    int max = 99999;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        

    }

    void MakeRoomNumber()
    {
        roomData.RoomNumber = Random.Range(min, max);
        roomData.RoomMaxMem = 7;
        roomData.RoomMember = 1;
    }
}

public class CreateGameRoomData
{
    public int RoomNumber;
    public int RoomMember;
    public int RoomMaxMem;
}
