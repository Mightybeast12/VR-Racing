using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FH_Base_CC_Move : MonoBehaviour {
    public float fl_MovementSpeed = 6f;
    public float originalspeed = 10f;
    public float boostedfl_MovementSpeed = 40f;
        public float fl_gravity = 15f;
    public float fl_JumpForce = 0f;
    public float og_jumpForce = 0f;
    public float boostedjump = 1f;
    public float doublejump = 2f;
    public float currentjump = 0f;
    bool isplayersmall = false;
    private Vector3 V3_move_direction = Vector3.zero;
    private CharacterController cc_Reference_To_Character_Controller;
    public GameObject smallcapsule;
    public GameObject Walle; 
    
	// Use this for initialization
	void Start () {
        cc_Reference_To_Character_Controller = GetComponent<CharacterController>();
            }	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp("e"))

        {
            isplayersmall = !isplayersmall;
            if (isplayersmall == true)
            {
                cc_Reference_To_Character_Controller.height = 1;
                smallcapsule.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
            }

        else
        {
            if (isplayersmall == false)
            {
                cc_Reference_To_Character_Controller.height = 2;
                smallcapsule.transform.localScale = new Vector3(1f, 1f, 1f);
            }
        }
        if (cc_Reference_To_Character_Controller.isGrounded)
        {
            V3_move_direction.x = Input.GetAxis("Horizontal");
            V3_move_direction.y = 0;
            V3_move_direction.z = Input.GetAxis("Vertical");
            V3_move_direction = V3_move_direction * fl_MovementSpeed * Time.deltaTime;
            currentjump = 0f;


        }
        else
        {
            V3_move_direction.y -= fl_gravity * Time.deltaTime;
        }
        if (currentjump < doublejump)
        {
            if (cc_Reference_To_Character_Controller.isGrounded && Input.GetButton("Jump"))
            {
                V3_move_direction.y = fl_JumpForce;
                currentjump++;

            }
            if (cc_Reference_To_Character_Controller.isGrounded && Input.GetButton("Jump"))
            {
                V3_move_direction.y = fl_JumpForce;
                currentjump++;

            }
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Boosted(true);
        }
        else
        {
            Boosted(false);
        }

        cc_Reference_To_Character_Controller.Move(V3_move_direction);
    }
    void Boosted(bool isBoosting)
    {

        if (isBoosting)
        {

            fl_MovementSpeed = boostedfl_MovementSpeed;

            fl_JumpForce = boostedjump * fl_MovementSpeed / 111;
        }
        else
        {
            fl_JumpForce = og_jumpForce;
            fl_MovementSpeed = originalspeed;
        }

               
  

    }
}
