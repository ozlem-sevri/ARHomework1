using UnityEngine;
using UnityEngine.Events;
using Vuforia;
 
public class arButton : MonoBehaviour
{
 
    public GameObject vbBtnObj;
    public GameObject cube;
 
    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("TouchButton");
        cube = GameObject.Find("AnimationCube");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
 
        

    }
 
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.GetComponent<Animation>().Play();
    }
 
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.GetComponent<Animation>().Stop();
    }
}
