using UnityEngine;

public class UITimeKeeper : MonoBehaviour
{
    [SerializeField] private UICounter counter;
    [SerializeField] private GameManager gm;
    void Start()
    {
        counter = GetComponentInChildren<UICounter>();
    }

    void Update(){
        // TOOD: should make this an obserevr pattern
        counter.SetNumber(gm.GetSecondsLeft());
    }
}
