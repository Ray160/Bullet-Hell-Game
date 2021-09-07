using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy
{
    public bool stunnable = true;
    public int size = 1; //smaller number = smaller size, use when deciding when to stick vs shatter


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

    public bool isStunnable(){
        return stunnable;
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("PlayerBullet")){
            Destroy(other.gameObject);
            health -= 1; // change later if bullets do different damage
        }
    }

    public void takeDamage(int damage){
        health -= damage;
    }
}
