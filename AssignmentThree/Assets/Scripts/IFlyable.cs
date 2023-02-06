/*
 * Gerard Lamoureux
 * EnemyController.cs
 * Assignment2
 * Handles whether an entity can fly or not
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFlyable
{
    bool fly();
}

class CanFly : IFlyable
{
    public bool fly() { return true; }
}

class CantFly : IFlyable
{
    public bool fly() { return false; }
}
