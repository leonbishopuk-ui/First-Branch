using UnityEngine;

public class playerController : MonoBehaviour
{
[Header("References")]  
private CharacterController controller; 
[SerializeField] private Transform camera;

[Header("Movement Settings")]
[SerializeField] private float walkSpeed = 5f;
[SerializeField] private float walkTransitionSpeed = 5f;
[SerializeField] private float runSpeed = 10f;
[SerializeField] private float runTransitionSpeed = 10f;
[SerializeField] private float turnSpeed = 2f;
[SerializeField] private float gravity = 9.81f;
[SerializeField] private float jumpHeight = 2f;

private float verticalVelocity;
private float speed;


[Header("Input")]
private float moveInput;
private float turnInput;

private void Start()
{
        controller = GetComponent<CharacterController>();
}

private void Update()
{
        InputManagement();
        Movement();
    }

private void Movement()
{
        GroundMovement();
        Turn();
}

private void GroundMovement()
    {
        Vector3 move = new Vector3(turnInput, 0, moveInput);
        move = transform.TransformDirection(move); 

        if (Input.GetKey(KeyCode.W))
        {
            speed = Mathf.Lerp(speed, walkSpeed, walkTransitionSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = Mathf.Lerp(speed, runSpeed, runTransitionSpeed * Time.deltaTime);
        }
        else
        {
            speed = Mathf.Lerp(speed, walkSpeed, runTransitionSpeed * Time.deltaTime);
        }

        move.y = VerticalForceCalculation();

        move *= speed;  

        controller.Move(move * Time.deltaTime);
    }

private void Turn()
    {
        if (Mathf.Abs(turnInput) > 0 || Mathf.Abs(moveInput) > 0)
        {
        Vector3 currentLookDirection = camera.forward;
        currentLookDirection.y = 0;

        Quaternion targetRotation = Quaternion.LookRotation(currentLookDirection);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
        }
    }

    private float VerticalForceCalculation()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = 0;
            if (Input.GetAxisRaw("Jump") == 1)
            {
                verticalVelocity = Mathf.Sqrt(jumpHeight * gravity * 2);
            }
        }
        else 
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        return verticalVelocity;
    }
    
private void InputManagement()
    {
         moveInput = Input.GetAxis("Vertical");
         turnInput = Input.GetAxis("Horizontal");
    }
    }
   
