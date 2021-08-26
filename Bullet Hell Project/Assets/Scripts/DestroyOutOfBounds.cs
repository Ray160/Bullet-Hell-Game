using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float xBound = 5;
    public float yBound = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > xBound || transform.position.x < -xBound){
            Destroy(gameObject);
        }
        if(transform.position.z > yBound || transform.position.z < -yBound){
            Destroy(gameObject);
        }
    }
}
