using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoardScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;

    [SerializeField] TextMeshProUGUI _text;
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().centerOfMass = new Vector3(0f, 10f, 0f);
        _text.text = "start";
    }

    private void FixedUpdate()
    {
    }
    void Update()
    {
        Transform transform = this.transform;

		float dz = Input.GetAxis("Vertical") * 0.04f;
		float dx = Input.GetAxis("Horizontal") * 0.04f;
		if (Input.GetKey("up")) {
            Debug.Log(transform.eulerAngles.x);
            if(30f < transform.eulerAngles.z && transform.eulerAngles.z < 180f ){return;}
			transform.Rotate(0, 0, dz);
            // _text.text = "up";
		}
 
		if (Input.GetKey("down")) {
            if(180f < transform.eulerAngles.z && transform.eulerAngles.z < 330f ){return;}
			transform.Rotate(0, 0, dz);
            // _text.text = "down";
		}
 
		if (Input.GetKey("left")) {
            if(180f < transform.eulerAngles.x && transform.eulerAngles.x < 330f ){return;}
			transform.Rotate(dx, 0, 0);
            // _text.text = "left";
		}
 
		if (Input.GetKey("right")) {
            if(30f < transform.eulerAngles.x && transform.eulerAngles.x < 180f ){return;}
			transform.Rotate(dx, 0, 0);
            // _text.text = "right";
		}
         _text.text = "経過時間(秒)" +Time.time.ToString("n2");
// Debug.Log ("経過時間(秒)" + Time.time);
    }
}
