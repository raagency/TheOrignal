using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    // [SerializeField] private Transform vfxHitGreen;
    [SerializeField] private Transform vfxHitRed;
    private Rigidbody bulletRigidbody;
    public int damageAmount = 20;

    private void Awake() {
        bulletRigidbody = GetComponent<Rigidbody>();
    }

    private void Start() {
        float speed = 40f;
        bulletRigidbody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<BulletTarget>() != null) {
            
            Instantiate(vfxHitRed, transform.position, Quaternion.identity);
        } else {
            
            Instantiate(vfxHitRed, transform.position, Quaternion.identity);
        }

        if (other.tag == "Enemy") 
        { 
            other.GetComponent<Enemy>().TakeDamage(damageAmount);
        }
    Destroy(gameObject);
    }

    
}
