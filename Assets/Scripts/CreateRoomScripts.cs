using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class CreateRoomScripts : MonoBehaviour
{
    public Button p4;
    public Button p5;
    public Button p6;
    public Button p7;
    public TextMeshProUGUI numText;
    private int playerNum;
    // Start is called before the first frame update
    void Start()
    {
        numText = GetComponent<TextMeshProUGUI>();
        playerNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        numText.text = playerNum.ToString();
        
    }

    public void SetNumber(int num)
    {
        playerNum = num;
    }
}
