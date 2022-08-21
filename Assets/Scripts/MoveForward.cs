using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {

    [SerializeField]
    private float speed = .1f;

    private void FixedUpdate() {
        transform.position -= transform.right * speed;
    }

}