using UnityEngine;
using UnityEngine.InputSystem;

namespace Player{
public class CupBahavior : MonoBehaviour
{
    [SerializeField] private Transform liquid;
    [SerializeField] private float fillSpeed;
    
    private InputAction interactAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        interactAction = InputSystem.actions.FindAction("Interact");
        liquid = transform.Find("Liquid");
    }

    // Update is called once per frame
    void Update() {
        if(interactAction.IsPressed()){
            liquid.transform.Translate(Vector2.up * fillSpeed * Time.deltaTime);
        }
    }
}
}
