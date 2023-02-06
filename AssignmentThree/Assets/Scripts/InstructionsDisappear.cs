/*
 * Gerard Lamoureux
 * InstructionsDisappear.cs
 * Assignment2
 * Handles Instruction UI
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsDisappear : MonoBehaviour
{
    [SerializeField] GameObject replayText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyAfterTime());
    }

    IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(5);
        replayText.SetActive(true);
        Destroy(gameObject);
    }
}
