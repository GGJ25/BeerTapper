using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Tap : MonoBehaviour
{

    private Animator[] animators;
    public bool openState;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        animators = GetComponentsInChildren<Animator>();
    }

// Purely for testing, delete Update later
    void Update(){ 
        foreach (Animator anim in animators)
            anim.SetBool("isOpen", openState);
    }

    public void Open(){
        openState = true;
        foreach (Animator anim in animators)
            anim.SetBool("isOpen", openState);
    }

    public void Close(){
        openState = false;
        foreach (Animator anim in animators)
            anim.SetBool("isOpen", openState);
    }

}
