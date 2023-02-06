/*
 * Gerard Lamoureux
 * Wings.cs
 * Assignment2
 * Handles Wings Pickup
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wings : Pickup
{
    private void Awake()
    {
        SetPickup(new WingsPickup());
    }
}
