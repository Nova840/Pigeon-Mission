using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PigeonSprite : MonoBehaviour {

    [SerializeField]
    private Sprite flying = null, standing = null;

    private SpriteRenderer spriteRenderer;
    private bool hasTakenOff = false;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.transform.CompareTag("Obstacle"))
            return;
        spriteRenderer.sprite = standing;
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.transform.CompareTag("Obstacle"))
            return;
        spriteRenderer.sprite = flying;
        if (spriteRenderer.enabled && !hasTakenOff) {
            Sound.PlaySound("pigeons-taking-off-trim");
            hasTakenOff = true;
        }
    }

}