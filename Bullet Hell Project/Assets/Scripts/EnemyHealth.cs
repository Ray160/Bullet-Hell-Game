using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 200;
    public ParticleSystem smoke;
    // Start is called before the first frame update
    void Start()
    {
        smoke.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0){
            Instantiate(smoke, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("PlayerBullet")){
            Destroy(other.gameObject);
            health -= 1; // change later if bullets do different damage
        }
    }
}
