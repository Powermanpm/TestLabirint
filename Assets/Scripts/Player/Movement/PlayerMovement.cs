using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    [SerializeField] private float sprintMultiplier = 2f; 
    [SerializeField] private float groundDrag;
    [SerializeField] private float playerHeight;
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private float decelerationRate = 5f; 
    bool grounded; 
    [SerializeField] private Transform orientation;
    float horisontalInput;
    float verticalInput;
    Vector3 moveDirection;
    Rigidbody rb;

    void Start(){

        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

    }
    
    void Update(){

        MyInput();

        if (grounded) rb.drag = groundDrag;
        else rb.drag = 0;

    }

    void FixedUpdate(){

        MovePlayer();
        SpeedControl();
        StopIfNoInput();

    }

    void MyInput(){

        horisontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

    }

    void MovePlayer(){

        moveDirection = orientation.forward * verticalInput + orientation.right * horisontalInput;
        
        float currentSpeed = moveSpeed;

        if (Input.GetKey(KeyCode.LeftShift) && verticalInput > 0) {
            currentSpeed *= sprintMultiplier; 
        }

        rb.AddForce(moveDirection.normalized * currentSpeed * 10f, ForceMode.Force);

    }

    void SpeedControl(){

        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if (flatVel.magnitude > moveSpeed){

            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);

        }

    }

    void StopIfNoInput(){
        
        if (horisontalInput == 0 && verticalInput == 0){

            Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
            flatVel = Vector3.Lerp(flatVel, Vector3.zero, decelerationRate * Time.deltaTime);
            rb.velocity = new Vector3(flatVel.x, rb.velocity.y, flatVel.z);

        }
        
    }

}