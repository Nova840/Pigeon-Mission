using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFadeOut : MonoBehaviour {

    private Renderer thisRenderer = null;

    [SerializeField]
    private float speed = 1;

    private void Awake() {
        thisRenderer = GetComponent<Renderer>();
    }

    private void Update() {
        Color c = thisRenderer.material.color;
        c.a -= speed * Time.deltaTime;
        thisRenderer.material.color = c;
        if (c.a <= 0)
            Destroy(gameObject);
    }

}