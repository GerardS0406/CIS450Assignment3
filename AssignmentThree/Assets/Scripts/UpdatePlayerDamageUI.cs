/*
 * Gerard Lamoureux
 * UpdatePlayerDamageUI.cs
 * Assignment3
 * Handles Player Damage UI
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdatePlayerDamageUI : MonoBehaviour, IPlayerObserver
{
    [SerializeField] TextMeshProUGUI text;

    void Start()
    {
        PlayerController.thisPlayerController.RegisterPlayerObserver(this);
    }
    public void UpdateData(PlayerController pc)
    {
        text.text = "Damage: " + pc.Damage;
    }
}
