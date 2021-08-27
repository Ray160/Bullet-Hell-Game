using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public GameObject bullet;

    private Rigidbody playerRb;
    public float xAxis;
    public float yAxis;
    public float xAxisSnap;
    public float yAxisSnap;

    //public bool altFire = false;

    //public float moveSpeed = 10f;
    //public float dashPower = 70f;
    /*
    public bool canDash = true;
    public bool momentum = false;
    public bool movementControl = true;
    public Vector3 dashDir;     */
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //InvokeRepeating("fireSpreadBullets", 0f, 0.1f); // actually use coroutine instead so can control firerate? unless fixed firerate
    }

    // Update is called once per frame
    void Update()
    {
        /*
        xAxis = Input.GetAxis("Horizontal");
        yAxis = Input.GetAxis("Vertical");
        xAxisSnap = Input.GetAxis("HorizontalSnap");
        yAxisSnap = Input.GetAxis("VerticalSnap");


        //if(!momentum){
            //playerRb.transform.Translate((Vector3.right * xAxis + Vector3.forward * yAxis) * moveSpeed * Time.deltaTime);
            //playerRb.AddForce(Vector3.forward * yAxis * moveSpeed);
  /*      }else if(momentum && movementControl){
            playerRb.AddForce((Vector3.right * xAxis + Vector3.forward * yAxis).normalized * dashPower);
            Vector3 vel = playerRb.velocity;
            if(vel.magnitude < 1.5 * moveSpeed){
                Debug.Log(vel.magnitude);
                momentum = false;
                playerRb.velocity = new Vector3(0,0,0);
                
            }
        }// if going in same direction as dash, halve the input
        if(Input.GetKeyDown(KeyCode.Space) && canDash){
            dashDir = (Vector3.right * xAxis + Vector3.forward * yAxis).normalized;
            playerRb.velocity = new Vector3(0,0,0);
            playerRb.AddForce(dashDir* dashPower, ForceMode.Impulse);
            canDash = false;
            momentum = true;
            movementControl = false;
            Invoke("DashTimer",2f);
            Invoke("MoveControlTimer", 0.25f);
        }
*//*
        if(Input.GetKeyDown(KeyCode.Z)){
            InvokeRepeating("fireBullets", 0f, 0.1f);
        }
        if(Input.GetKeyUp(KeyCode.Z)){
            CancelInvoke("fireBullets");
        }
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            altFire = !altFire;
        }
*/
    }
/*
    private void fireBullets(){
        if(altFire){
            fireTightBullets();
        }else{
            fireSpreadBullets();
        }
    }

    private void MoveControlTimer(){
        //movementControl = true;
    }
    
    private void fireSpreadBullets(){
        float sideAngle = 15f;
        Vector3 mainOffset = new Vector3(0.4f, 0, 0);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) + mainOffset, bullet.transform.rotation);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) - mainOffset, bullet.transform.rotation);
        Instantiate(bullet, gameObject.transform.position + Vector3.forward * 0.6f, bullet.transform.rotation);

        Vector3 sideOffset = new Vector3(0.4f, 0, 0);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) - sideOffset, bullet.transform.rotation * Quaternion.Euler(0, -sideAngle, 0));
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) + sideOffset, bullet.transform.rotation * Quaternion.Euler(0, sideAngle, 0));
        
        Vector3 sideSpacing = new Vector3(0.2f, 0, 0);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) - sideOffset - sideSpacing, bullet.transform.rotation * Quaternion.Euler(0, -sideAngle, 0));
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) + sideOffset + sideSpacing, bullet.transform.rotation * Quaternion.Euler(0, sideAngle, 0));

    }

    private void fireTightBullets(){
        float sideAngle = -6f;
        Vector3 mainOffset = new Vector3(0.2f, 0, 0);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) + mainOffset, bullet.transform.rotation);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) - mainOffset, bullet.transform.rotation);
        Instantiate(bullet, gameObject.transform.position + Vector3.forward * 0.6f, bullet.transform.rotation);

        Vector3 sideOffset = new Vector3(0.6f, 0, 0);
        Vector3 sideOffset2 = new Vector3(0, 0, -0.4f);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) - sideOffset + sideOffset2, bullet.transform.rotation * Quaternion.Euler(0, -sideAngle, 0));
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) + sideOffset + sideOffset2, bullet.transform.rotation * Quaternion.Euler(0, sideAngle, 0));
        
        Vector3 sideSpacing = new Vector3(0.2f, 0, 0);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) - sideOffset - sideSpacing + sideOffset2, bullet.transform.rotation * Quaternion.Euler(0, -sideAngle, 0));
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) + sideOffset + sideSpacing + sideOffset2, bullet.transform.rotation * Quaternion.Euler(0, sideAngle, 0));

    }*/

    private void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Ground")){

        }
    }
}
