using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    [SerializeField] private AudioSource keySound;
    [SerializeField] private PlayerInventory playerInventory;

    void Start(){

        if(keySound == null) keySound = GetComponent<AudioSource>();
        if(playerInventory == null) playerInventory = GetComponent<PlayerInventory>();

    }
    void OnTriggerEnter(Collider other){

        if(other.CompareTag("Key")){

            if(playerInventory != null) {
                
                playerInventory.AddKeys(1);
                keySound.Play();

            }
            
            else{
                
                playerInventory = GetComponent<PlayerInventory>();
                playerInventory.AddKeys(1);

            }
            Destroy(other.gameObject);

        }

    }

}
