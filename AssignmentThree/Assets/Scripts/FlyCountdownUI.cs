/*
 * Gerard Lamoureux
 * FlyCountdownUI.cs
 * Assignment3
 * Handles Fly Countdown UI
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlyCountdownUI : MonoBehaviour, IPlayerObserver
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] GameObject countdownObj;

    void Start()
    {
        PlayerController.thisPlayerController.RegisterPlayerObserver(this);
    }

    public void UpdateData(PlayerController pc)
    {
        if (pc.TryToFly())
            gameObject.SetActive(true);
        else
            gameObject.SetActive(false);
        text.text = "Fly Countdown: " + pc.FlyLength;
    }
}
