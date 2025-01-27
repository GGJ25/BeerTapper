using UnityEngine;
using UnityEngine.InputSystem;

namespace Player{
public class CupBahavior : MonoBehaviour
{
    
    [SerializeField] private float maxFill;
    [SerializeField] private float minFill;
    [SerializeField] private float fill;
    [SerializeField] private float fillSpeed; // Maybe worth moving this to the Tap?
    [SerializeField] private Transform liquid;
    [SerializeField] private GameManager gm;
    
    [SerializeField] private Tap tap;

    private InputAction interactAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        interactAction = InputSystem.actions.FindAction("Interact");
        liquid = transform.Find("Liquid");
    }

    // Update is called once per frame
    void Update() {
        if(interactAction.IsPressed()){
            tap.Open();
            fill += fillSpeed * Time.deltaTime;
            liquid.transform.Translate(Vector2.up * fillSpeed * Time.deltaTime);
            if(fill > maxFill) {
                Reset();
            }
        }
        if(interactAction.WasReleasedThisFrame()){
            tap.Close();
            if(fill > minFill && fill < maxFill){
                Reset();
                gm.AddScore(1);
            }
        }
    }

    public void Reset(){
        fill = 0;
        liquid.localPosition = new Vector3(0, -1.87f, 0);
    }
}
}
