using TMPro;
using UnityEngine;

public class UICounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TMP;
    private int spriteIdx0;
    private int spriteIdx1;
    private float counter;

    void Start(){
        TMP = GetComponent<TextMeshProUGUI>();

        TMP.text = $"<sprite={spriteIdx0}><sprite={spriteIdx1}>";
    }

    public void SetNumber(int num){
        counter = num;
        spriteIdx0 = (int)counter / 10;
        spriteIdx1 = (int)counter % 10;
        TMP.text = $"<sprite={spriteIdx0}><sprite={spriteIdx1}>";
    }
    
}
