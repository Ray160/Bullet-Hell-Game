using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireBullets : MonoBehaviour
{
    public GameObject bullet;

    public bool altFire = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)){
            InvokeRepeating("fireBullets", 0f, 0.1f);
        }
        if(Input.GetKeyUp(KeyCode.Z)){
            CancelInvoke("fireBullets");
        }
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            altFire = !altFire;
        }
    }

    private void fireBullets(){
        if(altFire){
            fireTightBullets();
        }else{
            fireSpreadBullets();
        }
    }

    private void fireSpreadBullets(){
        float sideAngle = 15f;
        Vector3 mainOffset = new Vector3(0.4f, 0, 0);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) + mainOffset, bullet.transform.rotation);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) - mainOffset, bullet.transform.rotation);
        Instantiate(bullet, gameObject.transform.position + Vector3.forward * 0.6f, bullet.transform.rotation);

        Vector3 mirroredOffset = new Vector3(0.6f, 0, 0);
        Vector3 absoluteOffset = new Vector3(0, 0, -0.2f);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) - mirroredOffset + absoluteOffset, bullet.transform.rotation * Quaternion.Euler(0, -sideAngle, 0));
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) + mirroredOffset + absoluteOffset, bullet.transform.rotation * Quaternion.Euler(0, sideAngle, 0));
        
        Vector3 sideSpacing = new Vector3(0.2f, 0, 0);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) - mirroredOffset + absoluteOffset * 2 - sideSpacing, bullet.transform.rotation * Quaternion.Euler(0, -sideAngle, 0));
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) + mirroredOffset + absoluteOffset * 2 + sideSpacing, bullet.transform.rotation * Quaternion.Euler(0, sideAngle, 0));

    }

    private void fireTightBullets(){
        float sideAngle = -6f;
        Vector3 mainOffset = new Vector3(0.2f, 0, 0);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) + mainOffset, bullet.transform.rotation);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) - mainOffset, bullet.transform.rotation);
        Instantiate(bullet, gameObject.transform.position + Vector3.forward * 0.6f, bullet.transform.rotation);

        Vector3 mirroredOffset = new Vector3(0.6f, 0, 0);
        Vector3 absoluteOffset = new Vector3(0, 0, -0.4f);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) - mirroredOffset + absoluteOffset, bullet.transform.rotation * Quaternion.Euler(0, -sideAngle, 0));
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) + mirroredOffset + absoluteOffset, bullet.transform.rotation * Quaternion.Euler(0, sideAngle, 0));
        
        Vector3 sideSpacing = new Vector3(0.2f, 0, 0);
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) - mirroredOffset + absoluteOffset - sideSpacing, bullet.transform.rotation * Quaternion.Euler(0, -sideAngle, 0));
        Instantiate(bullet, gameObject.transform.position + (Vector3.forward * 0.6f) + mirroredOffset + absoluteOffset + sideSpacing, bullet.transform.rotation * Quaternion.Euler(0, sideAngle, 0));

    }
}
