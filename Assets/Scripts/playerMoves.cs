using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoves : MonoBehaviour
{
    private Vector3 position;

    void Update()
    {
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            position = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x,touch.position.y,0.157f));
        }
        transform.position = Vector3.MoveTowards(transform.position,Vector3.Lerp(transform.position,position,0.1f),0.1f);
        
    }
}
