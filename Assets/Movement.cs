using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assim20 
{
public class Movement : MonoBehaviour
{      
    public float moveSpeed = 5f;

         void Start()
    {
        transform.position = new Vector3(-271.5f, 10.051f, 135.4f);  
    }

    void Update()
    {
   
        float moveX = 0f;
        float moveZ = 0f;

        if (Input.GetKey(KeyCode.RightArrow)) moveX = 12f;
        if (Input.GetKey(KeyCode.LeftArrow)) moveX = -12f;
        if (Input.GetKey(KeyCode.UpArrow)) moveZ = 12f;
        if (Input.GetKey(KeyCode.DownArrow)) moveZ = -12f;

        transform.position += new Vector3(moveX, 0, moveZ) * moveSpeed * Time.deltaTime;
    }
    }

}
