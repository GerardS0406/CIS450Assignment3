/*
 * Gerard Lamoureux
 * Damageable.cs
 * Assignment3
 * Abstract class that handles all base Damageables
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Damageable : MonoBehaviour
{
    [SerializeField] protected DamageableStats stats;

    protected int health = 0;

    public int Health { get => health; }

    protected int damage = 0;

    public int Damage { get => damage; }

    protected IFlyable flyable = new CantFly();

    public virtual void SetFlyMode(IFlyable flyable) { this.flyable = flyable; }

    protected virtual void Awake()
    {
        health = stats.MaxHealth;

        damage = stats.Damage;
    }

    protected void OnMouseDown()
    {
        PlayerController player = PlayerController.thisPlayerController;
        PlayerController.thisPlayerController.AttackDamageable(this, player.damage);
    }

    public virtual bool TryToFly()
    {
        return flyable.fly();
    }

    public virtual void AttackDamageable(Damageable damageable, int damage)
    {
        if (this == damageable)
        {
            Debug.Log("can't attack self!");
            return;
        }

        damageable.UpdateHealth(-damage);
    }

    /// <summary>
    /// Updates a damageable's health by x amount
    /// </summary>
    /// <param name="amount">amount to add to health</param>
    public virtual void UpdateHealth(int amount)
    {
        health += amount;
        if (health > stats.MaxHealth)
            health = stats.MaxHealth;
        else if (health <= 0)
            Die();
    }

    public virtual void UpdateDamage(int amount)
    {
        damage += amount;
        if (damage <= 0)
            damage = 1;
    }

    protected virtual void Die()
    {
        Debug.Log("Kill Me!!!!");
        Destroy(gameObject);
    }
}
