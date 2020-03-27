using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Basic_CC_Move : MonoBehaviour {
    public float fl_MovementSpeed = 6f;
    public float fl_gravity = 2f;
    public float fl_JumpForce = 0.8f;
    private Vector3 V3_move_direction = Vector3.zero;
    private CharacterController cc_Reference_To_Character_Controller;
    public float force = 20;

    // Use this for initialization
    void Start()
    {
        cc_Reference_To_Character_Controller = GetComponent<CharacterController>();

    }
    // Update is called once per frame
    void Update()
    {


        if (cc_Reference_To_Character_Controller.isGrounded)
        {
            V3_move_direction.x = Input.GetAxis("Horizontal");
            V3_move_direction.y = 0;
            V3_move_direction.z = Input.GetAxis("Vertical");
            V3_move_direction = V3_move_direction * fl_MovementSpeed * Time.deltaTime;
            if (Input.GetKey("Jump"))
            {
                V3_move_direction.y = fl_JumpForce;
                
            }
          
        }
        else
        {
            V3_move_direction.y -= fl_gravity * Time.deltaTime;
        }
        cc_Reference_To_Character_Controller.Move(V3_move_direction);

    
    }

    
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        /*
        Rigidbody _temporary_rb = hit.gameObject.GetComponent<Rigidbody>();
        if (_temporary_rb !=null) { 
            Vector3 dir = hit.gameObject.transform.position - transform.position;

            // We then get the opposite (-Vector3) and normalize it
            dir = dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
            _temporary_rb.AddForce(dir * force);

        }
        */

        print(hit.gameObject.tag);
        if(hit.gameObject.tag == "Changeable")
        {
                GetComponent<Renderer>().material.color = Color.red;
        }

    }



}
