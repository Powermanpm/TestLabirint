
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject winMenu;
    private PlayerInventory playerInventory;
    void Start(){

        playerInventory = GetComponent<PlayerInventory>();

    }
    void OnTriggerEnter(Collider other){

        if(other.CompareTag("EndZone") && playerInventory && playerInventory.Keys() >= playerInventory.KeyMax()){
    
            if(winMenu != null) winMenu.SetActive(true);
            FindAnyObjectByType<PauseMenu>().gameObject.SetActive(false);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }

    }

}
