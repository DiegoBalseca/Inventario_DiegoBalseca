using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rigidbody2D;

    private float movementSpeed = 5;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        rigidbody2D.linearVelocity = new Vector3(Input.GetAxis("Horizontal") * movementSpeed, rigidbody2D.linearVelocity.y, rigidbody2D.linearVelocity.z);

    }

    
}
