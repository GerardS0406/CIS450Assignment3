/*
 * Gerard Lamoureux
 * Pickup.cs
 * Assignment2
 * Handles abstract class for Pickups
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    IPickupable pickupable;

    public void SetPickup(IPickupable pickupable) { this.pickupable = pickupable; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController pc = collision.gameObject.GetComponent<PlayerController>();
        if(pc)
        {
            pickupable.Pickup(pc);
            Destroy(gameObject);
        }
    }
}
