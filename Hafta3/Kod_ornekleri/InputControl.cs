using UnityEngine;

public class InputControl : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            print("Q tuþuna basýldý");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            print("W tuþuna basýldý");
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            print("E tuþuna basýldý");
        }

        if (Input.GetMouseButton(0)) 
        {
            print("Sol tuþa týklanýyor");
        }

        if (Input.GetMouseButtonDown(1))
        {
            print("Sað tuþ týklandý");
        }

        if (Input.GetMouseButtonUp(2))
        {
            Debug.Log("Orta tuþtan çekildi");
        }

    }
}
