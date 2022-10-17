using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSphere : MonoBehaviour
{
    Rigidbody rigid;
    
    bool left;
    bool right;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
        Vector3 goRight = new Vector3(0.3f, transform.position.y, transform.position.z);
        Vector3 goLeft = new Vector3(-0.3f,transform.position.y,transform.position.z);

        if(Input.touchCount > 0){
            Touch finger = Input.GetTouch(0);
            if(finger.deltaPosition.x > 50.0f){
                right = true;
                left = false;
            }
            if(finger.deltaPosition.x < -50.0f){
                right = false;
                left = true;
            }

            if(right == true){
                transform.position = Vector3.Lerp(transform.position,goRight,3 * Time.deltaTime);
            }
            if(left == true){
                transform.position = Vector3.Lerp(transform.position,goLeft,3 * Time.deltaTime);
            }
        }
    }
}
