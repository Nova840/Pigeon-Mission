using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillate : MonoBehaviour {

    [SerializeField]
    private float speed = .1f, distance = 5;

    [SerializeField]
    private bool vertical = true;

    private Vector2 startPoint;

    private void Start() {
        startPoint = transform.localPosition;
        transform.localPosition += transform.InverseTransformDirection(new Vector3(0, Random.Range(-distance, distance), 0));
        if (Random.Range(0, 2) == 0)
            speed = -speed;
    }

    private void FixedUpdate() {
        if (Vector2.Distance(startPoint, transform.localPosition) >= distance)
            speed = -speed;
        transform.Translate((vertical ? Vector2.up : Vector2.left) * speed);
    }

}