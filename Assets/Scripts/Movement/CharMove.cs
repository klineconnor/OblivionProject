using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{

    public GameObject mainCamera;
    public JumpDetector jumpD;
    float rotateX;
    float rotateY;
    public float headRotateMin;
    public float headRotateMax;
    public float rotateCharSpeed;
    public float rotateCamSpeed;
    public float moveSpeed;
    public float jumpPower;
	public int runToggle = 1;
    Vector3 moveCharVector;
    Vector3 rotateCharVector;
    Vector3 rotateCamVector;
    Vector3 jumpVector;
    Rigidbody rb;
	
	void Start ()
    {
        Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
	}

    void Update()
    {
        rotateX += Input.GetAxis("Mouse X");
        rotateY += Input.GetAxis("Mouse Y");
        rotateY = Mathf.Clamp(rotateY, headRotateMin, headRotateMax);
        rotateChar();
        rotateCam();
        moveChar();
    }

    void FixedUpdate()
    {
        jumpChar();
    }

    void rotateChar()
    {
        rotateCharVector = new Vector3(0.0f, rotateX, 0.0f);
        transform.rotation = Quaternion.Euler(rotateCharVector * rotateCharSpeed);
    }

    void rotateCam()
    {
        rotateCamVector = new Vector3(-rotateY, 0.0f, 0.0f);
        mainCamera.transform.localRotation = Quaternion.Euler(rotateCamVector * rotateCamSpeed);
    }
    void moveChar()
    {
		if (Input.GetButton ("Run")) {
			runToggle = 4;
		} else {
			runToggle = 1;
		}
        moveCharVector = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
		transform.Translate(moveCharVector * Time.deltaTime * moveSpeed * runToggle);
    }

    void jumpChar()
    {
        jumpVector = new Vector3(0.0f, Input.GetAxis("Jump"), 0.0f);
        if (jumpD.onGround)
        {
            rb.AddForce(jumpVector * jumpPower * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
