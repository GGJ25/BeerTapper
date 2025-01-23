using UnityEngine;
using UnityEngine.InputSystem;

namespace Player{
public class CupBahavior : MonoBehaviour
{
    [SerializeField] private Transform liquid;
    [SerializeField] private float fillSpeed;
    private Touchscreen touch = Touchscreen.current;
    // private Gyroscope gyro = Gyroscope.current;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        liquid = transform.Find("Liquid");
    }

    // Update is called once per frame
    void Update() {
        if(touch.primaryTouch.press.isPressed){
            liquid.transform.Translate(Vector2.up * fillSpeed * Time.deltaTime);
        }
    }
}
}
