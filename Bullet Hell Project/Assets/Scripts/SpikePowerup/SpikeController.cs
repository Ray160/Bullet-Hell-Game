using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // maybe make it so it has health and only self destructs after delay after health = 0?
    void OnTriggerEnter(Collider other){
        Debug.Log(other.gameObject.name);
        IEnemy enemyScript = other.gameObject.GetComponent<IEnemy>(); 
        if(enemyScript != null && enemyScript.isStunnable()){
            gameObject.transform.SetParent(other.gameObject.transform, true);
            Invoke("stopMovement",0.2f);
            Invoke("selfDestruct",4f);
            enemyScript.takeDamage(50);
        }
    }

    private void stopMovement(){
        gameObject.GetComponent<MoveForward>().enabled = false;
    }

    private void selfDestruct(){
        Destroy(gameObject);
    }
}
