using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

    public Animator anim;
    public Rigidbody rbody;
    public GameObject endScreen;
    public float InputX;
    public float InputZ;
    public GameObject camera;
    public Transform cameraTransform;
    public float speed;

    // Use this for initialization
    void Start()
    {
        endScreen.SetActive(false);
        anim = GetComponent<Animator>();
       
     
    }

    // Update is called once per frame
    void Update()
    {
        
        InputX = Input.GetAxis("Horizontal");
        InputZ = Input.GetAxis("Vertical");

        anim.SetFloat("InputX", InputX);
        anim.SetFloat("InputZ", InputZ);
      //  ransform.position = transform.position + camera.transform.forward;

        float moveX = InputX * 20f ;
        float moveZ = InputZ * 50f ;

       Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = cameraTransform.TransformDirection(moveDirection);
        moveDirection *= speed;


        transform.GetComponent<CharacterController>().Move(moveDirection * Time.deltaTime);
      

        //rbody.velocity = new Vector3(moveX, 0f, moveZ);

      

      

    }
    public void ShowEndScreen()
    {
        Cursor.lockState = CursorLockMode.None;
        endScreen.SetActive(true);
        anim.SetFloat("InputX", 0.0f);
        anim.SetFloat("InputZ", 0.0f);
        camera.GetComponent<PlayerCamera>().enabled = false;
        transform.GetComponent<Player>().enabled = false;
        transform.GetComponent<PlayerMovement>().enabled = false;
    }
}
