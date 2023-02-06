/*
 * Gerard Lamoureux
 * HealthPack.cs
 * Assignment3
 * Handles Health Pickups
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : Pickup
{
    [SerializeField] private int amount = 50;
    private void Awake()
    {
        SetPickup(new HealthPickup(amount));
    }
}
