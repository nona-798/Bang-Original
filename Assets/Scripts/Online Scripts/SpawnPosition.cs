using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour
{
    [SerializeField]
    private Transform[] position;
    private int index;
    
    public Vector3 GetSpawnPos()
    {
        Vector3 pos = position[index++].position;
        if(index >= position.Length)
        {
            index = 0;
        }
        return pos;
    }
}
