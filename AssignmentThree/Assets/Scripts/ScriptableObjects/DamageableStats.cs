/*
 * Gerard Lamoureux
 * DamageableStats.cs
 * Assignment2
 * Scriptable Object Script that handles stats for damageables
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Damageable Stats")]
public class DamageableStats : ScriptableObject
{
    /// <summary>
    /// The maximum health for a damageable
    /// </summary>
    [SerializeField] private int maxHealth = 100;

    public int MaxHealth { get => maxHealth; }

    /// <summary>
    /// The damage done by this damageable
    /// </summary>
    [SerializeField] private int damage = 10;

    public int Damage { get => damage; }
}
