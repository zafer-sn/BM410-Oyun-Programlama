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
            print("U ya bas�ld�");
        }*/
        float xMove = Input.GetAxis("Horizontal") * moveSpeed;
        // gameObject scriptin s�r�klenip b�rak�larak at�ld��� nesneyi ifade eder.
        gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(xMove, 0f);

    }
}
