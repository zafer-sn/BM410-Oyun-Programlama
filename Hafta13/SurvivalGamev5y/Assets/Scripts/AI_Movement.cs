using UnityEngine;

public class AI_Movement : MonoBehaviour
{
	public float moveSpeed;
	
	Animator animator;
	int walkDirection;	
	
	float walkCounter;
	float waitCounter;
	
	float walkTime;
	float waitTime;
	
	bool isRunning;
	
    private void Start()
	{
		animator = GetComponent<Animator>();
		
		
		walkCounter = Random.Range(3f, 5f);
		waitCounter = Random.Range(2f, 4f);

		walkTime = waitCounter;
		waitTime = waitCounter;
		
		ChooseDirection();
		// isRunning = true;
		// Random r = new Random();
		// r.Next();
		// Random.Next();
	}
	
	private void Update()
	{
		if(isRunning)
		{
		walkCounter -= Time.deltaTime;
		animator.SetBool("isRunning", true);
		switch(walkDirection)
		{
			case 0:
			transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
			transform.position += transform.forward * moveSpeed * Time.deltaTime;
			break;
			case 1:
			transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
			transform.position += transform.forward * moveSpeed * Time.deltaTime;
			break;
			case 2:
			transform.localRotation = Quaternion.Euler(0f, -90f, 0f);
			transform.position += transform.forward * moveSpeed * Time.deltaTime;
			break;
			case 3:
			transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
			transform.position += transform.forward * moveSpeed * Time.deltaTime;
			break;
		}
		if(walkCounter <= 0)
		{
			isRunning = false;
			animator.SetBool("isRunning", false);
			waitCounter = waitTime;
		}		
		}
		else
		{
		waitCounter -= Time.deltaTime;
		if (waitCounter <= 0)
		{
			ChooseDirection();			
		}
		}	
		
	}
	
	public void ChooseDirection()
	{
		walkDirection = Random.Range(0, 4);
		isRunning = true;	
		walkCounter = walkTime;
	}
	
	
}
