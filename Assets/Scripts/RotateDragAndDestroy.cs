using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDragAndDestroy : MonoBehaviour
{
    public bool isActive = false;
    Color activeColor = new Color();
    public GameObject arCamera;
    public GameObject explosion;

    RaycastHit hit;
    private Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive){
            activeColor = Color.green;
            if(Input.touchCount == 1){

                Touch touch = Input.GetTouch(0);
                position = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x,touch.position.y,0.252f));

                if(touch.phase == TouchPhase.Moved){
                    transform.Rotate(0f,touch.deltaPosition.x,0f);
                }

                if(touch.phase == TouchPhase.Ended){
                    isActive = false;
                    if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit)) {

                    if(hit.transform.tag == "Cube"){
                        Destroy(hit.transform.gameObject);
                        Instantiate(explosion,hit.transform.position,hit.transform.rotation);
                        Destroy(explosion,2f);
                }
            }
                }
            }
            transform.position = Vector3.MoveTowards(transform.position,Vector3.Lerp(transform.position,position,0.1f),0.1f);
        }
        else
            activeColor = Color.red;

        GetComponent<MeshRenderer>().material.color = activeColor;
        
    }
}
