using System;
using UnityEngine;

public class UnityBasics : MonoBehaviour
{    
    /*
     Awake metodu oyun ba�lar ba�lamaz 1 kez �al���r.
    Awake metodu Starttan her zaman �nce �al���r.
    Awake metodu ilgili script aktif olmasa bile 1 kez �al���r.
     */
    private void Awake()
    {        
        print("Awake �al��t�.");
    }
    /*
     Start metodu oyun ba�lar ba�lamaz 1 kez �al���r.
    Start metodu Awaketen her zaman sonra �al���r
    Start metodu script aktif de�ilse �al��maz!
     */
    private void Start()
    {
        print("Start �al��t�.");
    }
    /*
     Update metodu her bir framede bir kez �al���r.
    �rne�in bir kullan�c� 200 FPS(Frame Per Second - Saniyede g�sterilen kare say�s�)
    al�yorsa 1 saniye de Update metodu 200 kez �al���r.
     */
    private void Update()
    {
        print("Update �al��t�.");
    }
    /*
     FixedUpdate metodu saniyede 50 kez �al���r.
    0.02 saniyede 1 kez �al���r.
     */
    private void FixedUpdate()
    {
        print("FixedUpdate �al��t�.");
    }
    /*
     LateUpdate metodu her bir framede bir kez �al���r.
    Bir framein sonuna do�ru �al���r.
     */
    private void LateUpdate()
    {
        print("LateUpdate �al��t�.");
    }
}
