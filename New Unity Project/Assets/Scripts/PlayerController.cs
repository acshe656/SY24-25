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
    public float speed = 50;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    public bool gameOver = false;
    public bool isOnGround = false;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
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
        playerRb.AddForce(Vector3.right * horizontalInput * speed);
        playerRb.AddForce(Vector3.forward * verticalInput * speed);
        Debug.Log("f");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            explosionParticle.Play();
            Destroy(playerRb);
        }
    }
}
