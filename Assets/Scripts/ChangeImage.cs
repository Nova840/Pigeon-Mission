using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SpriteRenderer))]
public class ChangeImage : MonoBehaviour {

    [SerializeField]
    private Sprite[] sprites = null;

    [SerializeField]
    private Selectable forwardButton = null, backButton = null;

    private SpriteRenderer spriteRenderer;
    private int currentSprite = 0;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start() {
        Set();
    }

    public void ForwardButton() {
        currentSprite++;
        Set();
    }

    public void BackButton() {
        currentSprite--;
        Set();
    }

    private void Set() {
        spriteRenderer.sprite = sprites[currentSprite];
        backButton.interactable = currentSprite != 0;
        forwardButton.interactable = currentSprite != sprites.Length - 1;
    }

}