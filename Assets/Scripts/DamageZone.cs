using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    public int amount;
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if ((controller != null) && (controller.CurrentHealth > 0))
        {
            controller.ChangeHealth(-amount);
        }
    }
}
