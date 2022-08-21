using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour {

    [SerializeField]
    private Transform player = null;

    private void Update() {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }

}