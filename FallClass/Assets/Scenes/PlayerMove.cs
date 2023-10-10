using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;
  

    private CharacterController Controller;
    private Vector3 moveDirection;
    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
       Controller = GetComponent<CharacterController>();

    }

   
    // Update is called once per frame
    void Update()
    {


      
        float Hor = Input.GetAxis("Horizontal");
        float Vert = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(Hor, 0, Vert);

        moveDirection.y -= gravity * Time.deltaTime;



        if (Input.GetButtonDown("Jump") && Controller.isGrounded)
            {
                isJumping = true;
           
        }
            else
            {
  
            isJumping = false;
            }

            

           
            if (isJumping)
            {
                moveDirection.y = jumpForce;
               
        }
        Controller.Move(moveDirection * Time.deltaTime * moveSpeed);

    }
}
