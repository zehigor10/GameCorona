using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public GameObject corona;

    void Start()
    {
        
    }

    void Update()
    {
        var pos = transform.position;
        pos.y = corona.transform.position.y+3;
        transform.position = pos;

    }
}
