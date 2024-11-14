using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
}

    // Update is called once per frame
    public float speed = 20;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    void Update()
    {
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 9)
        {
            transform.position = new Vector3(9, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.forward * Time.deltaTime * verticalInput);
        playerRb.AddForce(Vector3.right * horizontalInput * 10);
        playerRb.AddForce(Vector3.forward * verticalInput * 10);
        Debug.Log("f");
    }
}
