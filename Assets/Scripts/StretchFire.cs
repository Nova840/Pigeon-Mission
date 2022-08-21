using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StretchFire : MonoBehaviour {

    [SerializeField]
    private float minScale = 1, maxScale = 1, speed = .1f;

    private void Start() {
        transform.localScale = new Vector3(Random.Range(minScale, maxScale), transform.localScale.y, transform.localScale.z);
    }

    private void FixedUpdate() {
        transform.localScale = new Vector3(transform.localScale.x + speed, transform.localScale.y, transform.localScale.z);
        if (transform.localScale.x < minScale || transform.localScale.x > maxScale)
            speed = -speed;
    }

}