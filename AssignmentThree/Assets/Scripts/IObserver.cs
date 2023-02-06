/*
 * Gerard Lamoureux
 * UpdatePlayerHealth.cs
 * Assignment3
 * Handles the different Observer Interfaces
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerObserver
{
    void UpdateData(PlayerController pc);
}

public interface IEnemyObserver
{
    void UpdateData(EnemyController ec);
}
