using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    public float moveSpeed2 = 100f;
    /*
     int degiskenDegeri -> camelCase
    int DegiskenDegeri -> PascalCase
    int degisken_degeri -> snake_case
     */
	private void Update()
    {
        /*if(Input.GetKey(KeyCode.U))
        {
            print("U ya basýldý");
        }*/
        float xMove = Input.GetAxis("Horizontal") * moveSpeed;
        // gameObject scriptin sürüklenip býrakýlarak atýldýðý nesneyi ifade eder.
        gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(xMove, 0f);

    }
}
