using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillWall : MonoBehaviour
{   
    private Vector3 lowerPoint; 
    private Vector3 upperPoint; 
    [SerializeField] private float height;
    [SerializeField] private float moveSpeed = 2f; 

    [SerializeField] private bool isMovingDown = false; 

    void Start(){

        upperPoint = transform.position;
        lowerPoint = transform.position + new Vector3(0, height, 0); 

    }

    void Update()
    {
        
        if (isMovingDown)
        {
            transform.position = Vector3.Lerp(transform.position, lowerPoint, Time.deltaTime * moveSpeed);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, upperPoint, Time.deltaTime * moveSpeed);
        }
    }

    public void Move(bool down){

        isMovingDown = down; 

    }

}
