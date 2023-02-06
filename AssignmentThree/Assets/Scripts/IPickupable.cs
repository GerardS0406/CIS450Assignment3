/*
 * Gerard Lamoureux
 * IPickupable.cs
 * Assignment3
 * Handles Pickup Interface and includes the classes for the different pickups
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickupable
{
    void Pickup(Damageable dm);
}

class HealthPickup : IPickupable
{
    private int amount;
    public HealthPickup(int amount = 10)
    {
        this.amount = amount;
    }
    public void Pickup(Damageable dm)
    {
        dm.UpdateHealth(amount);
        Debug.Log("Health Pickup");
    }
}

class WingsPickup : IPickupable
{
    public void Pickup(Damageable dm)
    {
        dm.SetFlyMode(new CanFly());
        Debug.Log("Wings Pickup");
    }
}

class DamageBuffPickup : IPickupable
{
    private int amount;
    public DamageBuffPickup(int amount = 10)
    {
        this.amount = amount;
    }
    public void Pickup(Damageable dm)
    {
        dm.UpdateDamage(amount);
        Debug.Log("Buff Pickup");
    }
}
