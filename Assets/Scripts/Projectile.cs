using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private float currentLife = 0f;
    public float Lifetime = 3f;
    public ParticleSystem explosionEffect;



    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        EnemyController e = other.collider.GetComponent<EnemyController>();
        
        if (e != null)
        {
            e.Fix();
            Instantiate(explosionEffect, other.transform);
        }
            Destroy(gameObject);
    }

    private void Update()
    {
        currentLife += Time.deltaTime;
        if (currentLife >= Lifetime) Destroy(gameObject);
    }
}
