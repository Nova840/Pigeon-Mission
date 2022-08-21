using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {

    private void Awake() {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
            enabled = false;
    }

    private void Update() {
        if (Input.GetButtonDown("Escape"))
            Application.Quit();
    }

}