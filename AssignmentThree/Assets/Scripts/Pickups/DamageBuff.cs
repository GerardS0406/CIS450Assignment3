/*
 * Gerard Lamoureux
 * DamageBuff.cs
 * Assignment2
 * Handles Damage Buff Pickups
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBuff : Pickup
{
    [SerializeField] private int amount = 50;
    private void Awake()
    {
        SetPickup(new DamageBuffPickup(amount));
    }
}
