
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private GameObject deathMenu; 

    void OnTriggerEnter(Collider other){
        
        if (other.CompareTag("Enemy")){

            ShowGameOverScreen();
            FindAnyObjectByType<PauseMenu>().gameObject.SetActive(false);

        }

    }

    void ShowGameOverScreen(){

        if(deathMenu != null) deathMenu.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

}
