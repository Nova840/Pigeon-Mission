using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStartIfMobile : MonoBehaviour {

    [SerializeField]
    private SpriteRenderer spriteRenderer = null;

    [SerializeField]
    private Sprite mobileSprite = null;

    [SerializeField]
    private RectTransform buttonsContainer = null;

    [SerializeField]
    private Vector2 mobileButtonPosition = Vector2.zero;

    private void Start() {
        if (Application.isMobilePlatform) {
            spriteRenderer.sprite = mobileSprite;
            buttonsContainer.anchoredPosition = mobileButtonPosition;
        }
    }

}