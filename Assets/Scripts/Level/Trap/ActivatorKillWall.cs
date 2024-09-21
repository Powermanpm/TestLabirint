using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ActivatorKillWall : MonoBehaviour
{   
    [SerializeField] private KillWall killWall;

    void OnTriggerEnter(Collider other){

        if(other.CompareTag("Player")){

            if(killWall != null) killWall.Move(true);

        }

    }

    void OnTriggerExit(Collider other){

        if(other.CompareTag("Player")){

            if(killWall != null) killWall.Move(false);

        }

    }

}
