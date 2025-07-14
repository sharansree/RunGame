using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * -1.5f * Time.deltaTime);

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(new Vector3(0f, 5f, 0f), ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(0f, 0f, -1f), ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(0f, 0f, 1f), ForceMode.Force);
        }

        if(transform.position.y < -4f)
        {
            transform.position = new Vector3(49f, .5f, 0f);
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Physics.gravity = new Vector3(0f, 9.8f, 0f);
        }
        if(Input.GetKey(KeyCode.S))
        { 
            Physics.gravity = new Vector3(0f, -9.8f, 0f); 
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.gameObject.tag=="enemy")
            transform.position = new Vector3(49f,.5f,0f);
    }

}
