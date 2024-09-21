using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVisibility : MonoBehaviour
{
    private Camera mainCamera;
    [SerializeField] private EnemyMovement enemyMovement;
    [SerializeField] private Renderer objectRenderer;

    void Start()
    {
        mainCamera = Camera.main;
        objectRenderer = GetComponent<Renderer>();
        if(enemyMovement == null) enemyMovement = GetComponent<EnemyMovement>();
    }

    void Update(){

        if (objectRenderer.isVisible)
        {
            
            Vector3 directionToTarget = transform.position - mainCamera.transform.position;
            Ray ray = new Ray(mainCamera.transform.position, directionToTarget);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform){
                    
                    if(!enemyMovement.isActive) enemyMovement.isActive = true;
                    //Debug.Log("Объект виден камерой, без препятствий");

                }

                else{
                    
                    if(enemyMovement.isActive) enemyMovement.isActive = false;
                    //Debug.Log("Объект скрыт за препятствием");

                }

            }

        }

        else{

            if(enemyMovement.isActive) enemyMovement.isActive = false;
            //Debug.Log("Объект не виден камерой");

        }

    }

}
