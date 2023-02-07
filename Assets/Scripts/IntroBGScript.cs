using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroBGScript : MonoBehaviour
{
    float scrollSpeed = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(0.0f, -1 * scrollSpeed * Time.deltaTime, 0.0f));
        if(this.transform.position.y <= -5.0f)
        {
            scrollSpeed = 0.0f;
            //SceneManager.LoadScene("Main");
        }
    }
}
