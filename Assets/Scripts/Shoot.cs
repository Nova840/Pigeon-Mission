using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    [SerializeField]
    private float interval = 2, soundDistance = 10;

    [SerializeField]
    private GameObject shotPrefab = null;

    [SerializeField]
    private Transform shootPoint = null;

    private Transform player;

    private void Start() {
        player = GameObject.Find("Player").transform;
        StartCoroutine(ShootCoroutine());
    }

    private IEnumerator ShootCoroutine() {
        yield return new WaitForSeconds(Random.Range(0f, interval));
        while (true) {
            Instantiate(shotPrefab, shootPoint.position, shootPoint.rotation);
            if (Mathf.Abs(player.position.x - shootPoint.position.x) <= soundDistance)
                Sound.PlaySound("arrow release");
            yield return new WaitForSeconds(interval);
        }
    }

}