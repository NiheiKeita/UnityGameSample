using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;

    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        rigidBody.AddForce(x * speed, 0, z * speed, ForceMode.Impulse);

    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Vector3 forceDirection = new Vector3(0f, -1.0f, 0f);

            float forceMagnitude = 5.0f;

            Vector3 force = forceMagnitude * forceDirection;

            Rigidbody rb = gameObject.GetComponent<Rigidbody>();

            rb.AddForce(force, ForceMode.Impulse);
        }
    }
    // public void OnPressLeftButton()
    // {
    //         Vector3 forceDirection = new Vector3(0.0f, 1.0f, 0f);

    //         float forceMagnitude = 5.0f;

    //         Vector3 force = forceMagnitude * forceDirection;

    //         Rigidbody rb = gameObject.GetComponent<Rigidbody>();

    //         rb.AddForce(force, ForceMode.Impulse);
    // }
}
