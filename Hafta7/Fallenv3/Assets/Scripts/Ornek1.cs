using UnityEngine;

public class Ornek1 : MonoBehaviour
{
    [SerializeField]
    int speed = 10; // private
    [HideInInspector]
    public int moveSpeed;
    public GameObject[] nesneler = new GameObject[5];
    private GameObject ucgen;
    public Transform triangleT;
    public SpriteRenderer traingelSR;
    [field:SerializeField]
    public string Name { get; set; }
    public void Calculate()
    {
        this.triangleT = GameObject.Find("Triangle").GetComponent<Transform>();        
    }

    private void Awake()
    {
        Debug.Log("Awake Çalıştı");
        // print("Awake çalıştı");
    }
    private void Start()
    {
        Debug.Log("Start Çalıştı");
        ucgen = GameObject.Find("Triangle");
        ucgen.AddComponent<SpriteRenderer>();
        traingelSR = ucgen.GetComponent<SpriteRenderer>();
        Calculate();
        // this.triangleT.position = new Vector3(2.5f, 5.5f, 10f);
        traingelSR.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);


    }
    private void Update() 
    {
        Debug.Log("Uodate Çalıştı");

    }
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate Çalıştı");

    }
    private void LateUpdate()
    {
        Debug.Log("LateUpdate Çalıştı");

    }

}
