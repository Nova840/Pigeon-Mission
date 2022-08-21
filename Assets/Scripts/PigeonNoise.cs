using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonNoise : MonoBehaviour {

    private SpriteRenderer spriteRenderer;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update() {
        if (Input.GetButtonDown("S") && spriteRenderer.enabled)
            Sound.PlaySound("basic pigeon cooing");
    }

}