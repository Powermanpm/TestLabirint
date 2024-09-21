
using UnityEngine;

public class PlayerCameraMovement : MonoBehaviour
{   
    [SerializeField] private Transform cameraPosition;
    void LateUpdate()
    {
        transform.position = cameraPosition.position;
    }
}
