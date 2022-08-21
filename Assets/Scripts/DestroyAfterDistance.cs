using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDistance : MonoBehaviour {

    private Vector2 startPoint;

    [SerializeField]
    private float distance = 0;

    private void Start() {
        startPoint = transform.position;
    }

    private void Update() {
        if (Vector2.Distance(startPoint, transform.position) > distance)
            Destroy(gameObject);
    }

}