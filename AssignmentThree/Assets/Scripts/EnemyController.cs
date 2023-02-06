/*
 * Gerard Lamoureux
 * EnemyController.cs
 * Assignment3
 * Handles enemies and their text
 */

using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class EnemyController : Damageable, IEnemySubject, IEnemyObserver
{
    [SerializeField] TextMeshProUGUI text;

    protected List<IEnemyObserver> observers = new List<IEnemyObserver>();

    void Start()
    {
        RegisterEnemyObserver(this);
    }

    public void UpdateData(EnemyController ec)
    {
        text.text = "Enemy\nHealth\n" + ec.Health;
    }

    public void RegisterEnemyObserver(IEnemyObserver observer)
    {
        observers.Add(observer);

        observer.UpdateData(this);
    }

    public void RemoveEnemyObserver(IEnemyObserver observer)
    {
        if (observers.Contains(observer))
        {
            observers.Remove(observer);
        }
    }

    public void NotifyEnemyObservers()
    {
        foreach(IEnemyObserver observer in observers)
        {
            observer.UpdateData(this);
        }
    }

    public override void UpdateHealth(int amount)
    {
        health += amount;
        if (health > stats.MaxHealth)
            health = stats.MaxHealth;
        else if (health <= 0)
            Die();
        NotifyEnemyObservers();
    }
}

