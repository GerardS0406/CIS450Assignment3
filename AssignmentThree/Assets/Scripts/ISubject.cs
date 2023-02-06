/*
 * Gerard Lamoureux
 * UpdatePlayerHealth.cs
 * Assignment3
 * Handles Subject Interface for different Observer Interfaces
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerSubject
{
    void RegisterPlayerObserver(IPlayerObserver observer);
    void RemovePlayerObserver(IPlayerObserver observer);
    void NotifyPlayerObservers();
}

public interface IEnemySubject
{
    void RegisterEnemyObserver(IEnemyObserver observer);
    void RemoveEnemyObserver(IEnemyObserver observer);
    void NotifyEnemyObservers();
}
