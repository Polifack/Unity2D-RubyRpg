using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public int amount;
    public ParticleSystem pickupEffect;
    public AudioClip collectedClip;
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if ((controller != null) && (controller.CurrentHealth < controller.maxHealth))
        {
            Instantiate(pickupEffect);
            controller.ChangeHealth(amount);
            controller.PlaySound(collectedClip);
            Destroy(gameObject);
        }
    }
}
