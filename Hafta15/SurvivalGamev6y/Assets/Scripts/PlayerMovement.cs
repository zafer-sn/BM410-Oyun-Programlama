using UnityEngine;

public class PlayerMovement : MonoBehaviour
{	
	public float moveSpeed;
	public float jumpHeight;

	CharacterController controller;
	float gravity = -9.81f * 2;
	bool isGrounded;
	
	Transform ground; // null
	float radius = 0.4f;
	LayerMask layer;
	
	Vector3 velocity; // struct
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		ground = GameObject.Find("Ground").transform;
        controller = GetComponent<CharacterController>();
		layer.value = 64;
		// 00000001
		// 01000000 -> 64
    }

    // Update is called once per frame
    void Update()
    {
		isGrounded = Physics.CheckSphere(ground.position, radius, layer);
		
		if(isGrounded && velocity.y < 0)
		{
			velocity.y = -2f;
		}
		
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
		
		Vector3 move = transform.forward * z + transform.right * x;	
		
		
		controller.Move(move * moveSpeed * Time.deltaTime);
		
		if(isGrounded && Input.GetButtonDown("Jump"))
		{
			velocity.y = Mathf.Sqrt(-2 * gravity * jumpHeight);
			
		}
		
		velocity.y += gravity * Time.deltaTime; // velocity.y = velocity.y - gravity;
		
		controller.Move(velocity * Time.deltaTime);
		
		// print(velocity.y);
		
    }
}
