using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovePlayer : MonoBehaviour {

    private Rigidbody2D rb2d;

    [SerializeField]
    private float speed = 10, jumpForce = 1000;

    private float moveForce = 0;

    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if (!Application.isMobilePlatform)
            moveForce = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Space"))
            Jump();
    }

    private void FixedUpdate() {
        rb2d.AddForce(new Vector2(moveForce, 0) * speed);
    }

    public void ButtonDown(float moveForce) {
        this.moveForce += moveForce;
    }

    public void ButtonUp(float moveForce) {
        this.moveForce -= moveForce;
    }

    public void Jump() {
        rb2d.AddForce(Vector3.up * jumpForce);
    }

}