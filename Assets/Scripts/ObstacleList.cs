using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleList : MonoBehaviour {

    private static List<GameObject> obstacles = new List<GameObject>();

    private void Awake() {
        obstacles.Add(gameObject);
    }

    private void OnDestroy() {
        obstacles.Remove(gameObject);
    }

    public static void ClearObstacles() {
        for (int i = 0; i < obstacles.Count; i++)
            Destroy(obstacles[i]);
    }

}