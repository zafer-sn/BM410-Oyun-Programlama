using System;
using UnityEngine;

public class UnityBasics : MonoBehaviour
{    
    /*
     Awake metodu oyun baþlar baþlamaz 1 kez çalýþýr.
    Awake metodu Starttan her zaman önce çalýþýr.
    Awake metodu ilgili script aktif olmasa bile 1 kez çalýþýr.
     */
    private void Awake()
    {        
        print("Awake çalýþtý.");
    }
    /*
     Start metodu oyun baþlar baþlamaz 1 kez çalýþýr.
    Start metodu Awaketen her zaman sonra çalýþýr
    Start metodu script aktif deðilse çalýþmaz!
     */
    private void Start()
    {
        print("Start çalýþtý.");
    }
    /*
     Update metodu her bir framede bir kez çalýþýr.
    Örneðin bir kullanýcý 200 FPS(Frame Per Second - Saniyede gösterilen kare sayýsý)
    alýyorsa 1 saniye de Update metodu 200 kez çalýþýr.
     */
    private void Update()
    {
        print("Update çalýþtý.");
    }
    /*
     FixedUpdate metodu saniyede 50 kez çalýþýr.
    0.02 saniyede 1 kez çalýþýr.
     */
    private void FixedUpdate()
    {
        print("FixedUpdate çalýþtý.");
    }
    /*
     LateUpdate metodu her bir framede bir kez çalýþýr.
    Bir framein sonuna doðru çalýþýr.
     */
    private void LateUpdate()
    {
        print("LateUpdate çalýþtý.");
    }
}
