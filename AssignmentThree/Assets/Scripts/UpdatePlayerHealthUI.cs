/*
 * Gerard Lamoureux
 * UpdatePlayerHealth.cs
 * Assignment3
 * Handles Player Health UI
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdatePlayerHealthUI : MonoBehaviour, IPlayerObserver
{
    [SerializeField] TextMeshProUGUI text;

    void Start()
    {
        PlayerController.thisPlayerController.RegisterPlayerObserver(this);
    }

    public void UpdateData(PlayerController pc)
    {
        text.text = "Health: " + pc.Health;
    }
}
