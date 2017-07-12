using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContronal : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.AddForce(moveHorizontal * speed, 0, moveVertical * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
