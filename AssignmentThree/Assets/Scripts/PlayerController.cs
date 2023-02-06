/*
 * Gerard Lamoureux
 * PlayerController.cs
 * Assignment3
 * Handles Player and their fly mode
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Damageable, IPlayerSubject
{
    private List<IPlayerObserver> observers = new List<IPlayerObserver>();

    protected int flyLength = 0;
    protected Coroutine flyCoroutine;

    public static PlayerController thisPlayerController;

    public int FlyLength { get => flyLength; }
    protected override void Awake()
    {
        base.Awake();
        health = 10;
        SetFlyMode(new CantFly());
        thisPlayerController = this;
    }

    public override void SetFlyMode(IFlyable flyable)
    {
        base.SetFlyMode(flyable);
        if (TryToFly())
        {
            flyLength = 15;
            if (flyCoroutine != null)
                StopCoroutine(flyCoroutine);
            flyCoroutine = StartCoroutine(FlyTime());
        }
        else
        {
            if (flyCoroutine != null)
                StopCoroutine(flyCoroutine);
        }
    }

    private IEnumerator FlyTime()
    {
        while(flyLength > 0)
        {
            NotifyPlayerObservers();
            yield return new WaitForSeconds(1);
            flyLength--;
        }
        SetFlyMode(new CantFly());
        NotifyPlayerObservers();
    }

    public override void UpdateHealth(int amount)
    {
        health += amount;
        if (health > stats.MaxHealth)
            health = stats.MaxHealth;
        else if (health <= 0)
            Die();
        NotifyPlayerObservers();
    }

    public override void UpdateDamage(int amount)
    {
        damage += amount;
        if (damage <= 0)
            damage = 1;
        NotifyPlayerObservers();
    }

    public void RegisterPlayerObserver(IPlayerObserver observer)
    {
        observers.Add(observer);

        observer.UpdateData(this);
    }

    public void RemovePlayerObserver(IPlayerObserver observer)
    {
        if(observers.Contains(observer))
        {
            observers.Remove(observer);
        }
    }

    public void NotifyPlayerObservers()
    {
        foreach(IPlayerObserver observer in observers)
        {
            observer.UpdateData(this);
        }
    }
}
