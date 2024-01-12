using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;

    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().centerOfMass = new Vector3(0f, 10f, 0f);
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
		}
 
		if (Input.GetKey("down")) {
            if(180f < transform.eulerAngles.z && transform.eulerAngles.z < 330f ){return;}
			transform.Rotate(0, 0, dz);
		}
 
		if (Input.GetKey("left")) {
            if(180f < transform.eulerAngles.x && transform.eulerAngles.x < 330f ){return;}
			transform.Rotate(dx, 0, 0);
		}
 
		if (Input.GetKey("right")) {
            if(30f < transform.eulerAngles.x && transform.eulerAngles.x < 180f ){return;}
			transform.Rotate(dx, 0, 0);
		}

        // Transform myTransform = this.transform;
 

        // Transform myTransform = this.transform;
        // Vector3 LocalAngle = myTransform.eulerAngles;
        // // if (Input.GetKeyUp(KeyCode.Space)){
        // //     Debug.Log("osita");
        // //     Transform myTransform = this.transform;
        // //     //ワールド座標を基準に、回転取得
        // //     LocalAngle.x = LocalAngle.x + 0.0f; //ワールド座標を基準にした、x軸を軸にした回転角度
        // //     LocalAngle.y =  LocalAngle.y + 1.0f; //ワールド座標を基準にした、y軸を軸にした回転角度
        // //     LocalAngle.z = LocalAngle.z + 1.0f; //ワールド座標を基準にした、z軸を軸にした回転角度
        // //     myTransform.eulerAngles = LocalAngle; 
        // // }
        // if (Input.GetKey("up")) {
        //     LocalAngle.y =  LocalAngle.y + 1.0f;
		// }
		// if (Input.GetKey("down")) {
        //     LocalAngle.y =  LocalAngle.y - 1.0f;
		// }
		// if (Input.GetKey("left")) {
		// 	LocalAngle.z = LocalAngle.z + 1.0f;
		// }
		// if (Input.GetKey("right")) {
		// 	LocalAngle.z = LocalAngle.z - 1.0f;
		// }
        // myTransform.eulerAngles = LocalAngle; 
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
