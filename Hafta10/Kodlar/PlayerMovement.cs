using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;
    float gravity = -9.81f;    

    Transform groundCheck;
    float groundDistance = 0.4f;
    LayerMask groundMask;
    
    bool isGrounded;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        groundCheck = GameObject.Find("Ground").transform;
        groundMask.value = 64;
        /*
         1 << 6
        00000001
        01000000 -> 64
         
         */
    }
    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");        

        Vector3 move = gameObject.transform.right * x + gameObject.transform.forward * z;

        controller.Move(move);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            
        }        
    }
}
