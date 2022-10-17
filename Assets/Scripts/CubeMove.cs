using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    int touch;
    
    // Start is called before the first frame update
    void Start()
    {
        touch = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 right = new Vector3(0.01f, transform.position.y, transform.position.z );
        Vector3 left = new Vector3(-0.01f,transform.position.y,transform.position.z);
        Vector3 forward = new Vector3(transform.position.x,0.01f,transform.position.z);
        Vector3 back = new Vector3(transform.position.x,-0.01f,transform.position.z);
        if(Input.touchCount > 0 ){
            touch++;
            if(touch % 4 == 1)
                 transform.position = Vector3.Lerp(transform.position,right, 1);
            if(touch % 4 == 2)
                transform.position = Vector3.Lerp(transform.position,left, 1);
            if(touch %4 == 3)
                 transform.position = Vector3.Lerp(transform.position,forward, 1);
            if(touch % 4 == 0)
                transform.position = Vector3.Lerp(transform.position,back, 1);



        }
      
    }

}
