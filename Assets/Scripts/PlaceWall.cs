using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceWall : MonoBehaviour {

    [SerializeField]
    private GameObject wallPrefab = null, movingPrefab = null, shootingPrefab = null, dragonPrefab = null;

    [SerializeField]
    private Camera mainCamera = null;

    private void Update() {
        if (Input.GetButtonDown("Left Click"))
            Instantiate(wallPrefab, (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
        if (Input.GetButtonDown("Right Click"))
            Instantiate(movingPrefab, (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
        if (Input.GetButtonDown("Middle Click"))
            Instantiate(shootingPrefab, (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
        if (Input.GetButtonDown("Mouse 3"))
            Instantiate(dragonPrefab, (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
    }

}