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

    
    private bool isStart = false;
    private float startTime;
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
            if(30f < transform.eulerAngles.z && transform.eulerAngles.z < 180f ){
                // 
            }else{
                transform.Rotate(0, 0, dz);
            }
		}
 
		if (Input.GetKey("down")) {
            if(180f < transform.eulerAngles.z && transform.eulerAngles.z < 330f ){
                // 
            }else{
                transform.Rotate(0, 0, dz);
            }
		}
		if (Input.GetKey("left")) {
            if(180f < transform.eulerAngles.x && transform.eulerAngles.x < 330f ){
                //
            }else{
                transform.Rotate(dx, 0, 0);
            }
		}
		if (Input.GetKey("right")) {
            if(30f < transform.eulerAngles.x && transform.eulerAngles.x < 180f ){
                //
            }else{
                transform.Rotate(dx, 0, 0);
            }
		}

		if ((Input.GetKey("right") || Input.GetKey("left") || Input.GetKey("down") || Input.GetKey("up")) && !isStart) {
            isStart = true;
            startTime = Time.time;
        }

        _text.text = showText();

        //ボードが変な方向に傾かないように修正
        Vector3 LocalAngle = transform.eulerAngles;
        LocalAngle.y = 0f;
        transform.eulerAngles = LocalAngle;
    }

    private string showText()
    {
        string result = "ボードを動かしてください。";
        if(isStart){
            result = "経過時間(秒)" + (Time.time - startTime).ToString("n2") ;
        }
        return result;
    }
}
