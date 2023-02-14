using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class OnlineScripts : MonoBehaviour
{
    [SerializeField]
    private List<Button> maxPlayerButton;

    [SerializeField]
    private List<Button> SetPlayOptionButton;

    private CreateGameRoomData roomData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void UpdateMaxPlayerCount(int count)
    {
        roomData.maxPlayerCount = count;
        if(count == 4)
        {

        }
        else if(count == 6)
        {

        }
        else
        {

        }
    }
}

public class CreateGameRoomData
{
    public int maxPlayerCount;
    public int SetPlayOption;
    public int viceCount;
    public int rinnegatoCount;
    public int fuorileggeCount;
}
