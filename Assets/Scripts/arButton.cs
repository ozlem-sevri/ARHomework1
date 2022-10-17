using UnityEngine;
using UnityEngine.Events;
using Vuforia;
 
public class vb_anim : MonoBehaviour
{
 
    public GameObject vbBtnObj;
    public Animator capsule;
 
    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("TouchButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
 
        capsule.GetComponent<Animator>();
    }
 
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        capsule.Play("Animation");
        
    }
 
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        capsule.Play("none");
    }
}
