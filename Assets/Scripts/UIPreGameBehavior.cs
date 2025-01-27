using Player;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIProgressBehavior : MonoBehaviour
{
    private InputAction interactAction;
    [SerializeField] private GameObject[] objectsToActivate;
    [SerializeField] private GameObject[] objectsToDeactivate;
    void Start(){
        interactAction = InputSystem.actions.FindAction("Interact");
    }
    [SerializeField] private GameManager gm;
    [SerializeField] private CupBahavior cup;
    public bool startGame;

    // Update is called once per frame
    void Update(){
        if(interactAction.WasPressedThisFrame()){
            foreach(GameObject obj in objectsToActivate){
                obj.SetActive(true);
            }
            foreach(GameObject obj in objectsToDeactivate){
                obj.SetActive(false);
            }
            if(startGame){
                cup.Reset();
                gm.StartGame();
            }
        }
    }
}
