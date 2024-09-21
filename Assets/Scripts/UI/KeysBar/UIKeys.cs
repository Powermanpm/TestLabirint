
using UnityEngine.UI;
using UnityEngine;

public class UIKeys : MonoBehaviour
{

    [SerializeField] private PlayerInventory playerInventory;
    private Image bar;

    void Start(){
        
        bar = GetComponent<Image>();
        if(playerInventory == null) playerInventory = FindAnyObjectByType<PlayerInventory>();

    }

    void Update(){

        bar.fillAmount = (float)playerInventory.Keys()/playerInventory.KeyMax();

    }

}
