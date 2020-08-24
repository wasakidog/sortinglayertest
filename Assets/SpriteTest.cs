using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTest : MonoBehaviour
{
    float sumtime=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sumtime+=Time.deltaTime;
        transform.position = new Vector3(0f,0f,-6f+Mathf.PingPong(sumtime,7f));
    }
}
