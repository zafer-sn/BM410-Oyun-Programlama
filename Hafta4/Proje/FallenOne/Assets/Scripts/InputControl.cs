using UnityEngine;

public class InputControl : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            print("Q tu�una bas�ld�");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            print("W tu�una bas�ld�");
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            print("E tu�una bas�ld�");
        }

        if (Input.GetMouseButton(0)) 
        {
            print("Sol tu�a t�klan�yor");
        }

        if (Input.GetMouseButtonDown(1))
        {
            print("Sa� tu� t�kland�");
        }

        if (Input.GetMouseButtonUp(2))
        {
            Debug.Log("Orta tu�tan �ekildi");
        }

    }
}