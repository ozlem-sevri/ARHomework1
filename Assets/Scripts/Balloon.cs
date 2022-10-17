using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public Transform[] points;
    public GameObject[] balloons;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartBallon());
    }

    IEnumerator StartBallon(){
        yield return new WaitForSeconds(3);
        for(int i = 0; i < 4; i++){
            Instantiate(balloons[i],points[i].position,Quaternion.identity);
        }
         StartCoroutine(StartBallon());
    }
   
}
