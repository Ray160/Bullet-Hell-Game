using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRb;
    public float xAxis;
    public float zAxis;
    public float xAxisSnap;
    public float zAxisSnap; // no floats, on or off

    public float moveSpeed = 10f;
    public float dashPower = 70f;

    public float dashCooldown = 1f;

    public bool canDash = true;
    public bool momentum = false;
    public bool movementControl = true;
    public Vector3 dashDir;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xAxis = Input.GetAxis("Horizontal");
        zAxis = Input.GetAxis("Vertical");
        xAxisSnap = Input.GetAxis("HorizontalSnap");
        zAxisSnap = Input.GetAxis("VerticalSnap");


        if(!momentum){
            playerRb.transform.Translate((Vector3.right * xAxisSnap + Vector3.forward * zAxisSnap) * moveSpeed * Time.deltaTime);
            //playerRb.AddForce(Vector3.forward * zAxis * moveSpeed);
        }else if(momentum && movementControl){
            if((xAxisSnap > 0 && dashDir.x < 0) || (xAxisSnap < 0 && dashDir.x > 0)){
                playerRb.AddForce(Vector3.right * xAxisSnap * dashPower * 1.5f);
                Debug.Log("Xs: " + xAxisSnap + "| Xd: " + dashDir.x);
            }
            if((zAxisSnap > 0 && dashDir.z < 0) || (zAxisSnap < 0 && dashDir.z > 0)){
                playerRb.AddForce(Vector3.forward * zAxisSnap * dashPower * 1.5f);
                Debug.Log("Z: " + dashDir.z);
            }
            //playerRb.AddForce((Vector3.right * xAxis + Vector3.forward * zAxis).normalized * dashPower/2);
            Vector3 vel = playerRb.velocity;
            if(vel.magnitude <= 0.8 * moveSpeed * moveSpeed){
                //Debug.Log(vel.magnitude);
                momentum = false;
                playerRb.velocity = new Vector3(0,0,0);
                
            }
        }// if going in same direction as dash, halve the input
        if(Input.GetKeyDown(KeyCode.Space) && canDash){
            dashDir = (Vector3.right * xAxisSnap + Vector3.forward * zAxisSnap);
            playerRb.velocity = new Vector3(0,0,0);
            playerRb.AddForce(dashDir.normalized* dashPower, ForceMode.Impulse);
            canDash = false;
            momentum = true;
            movementControl = false;
            Invoke("DashTimer",dashCooldown);
            Invoke("MoveControlTimer", 0.3f);
        }
    }

    private void DashTimer(){
        canDash = true;
        //playerRb.velocity = new Vector3(0,0,0);
    }

    private void MoveControlTimer(){
        movementControl = true;
    }
}
