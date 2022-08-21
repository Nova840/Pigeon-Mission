using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    private Rigidbody2D rb2d;
    private Renderer thisRenderer;
    private Vector2 spawnPoint;
    public Vector2 SpawnPoint { get { return spawnPoint; } }

    [SerializeField]
    private GameObject deathCanvas = null, finishCanvas = null;
    [SerializeField]
    private GameObject arrowDeathPrefab = null, cookedDeathPrefab = null, kfcDeathPrefab = null, regularDeathPrefab = null, bonesDeathPrefab = null;
    [SerializeField]
    private float spinVelocity = 100;

    private bool killed = false;

    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
        thisRenderer = GetComponent<Renderer>();
    }

    private void Start() {
        spawnPoint = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Collide(collision.transform.name, collision.transform.tag);
    }

    private void OnCollisionEnter2D(Collision2D collision2D) {
        Collide(collision2D.transform.name, collision2D.transform.tag);
    }

    private void Collide(string cName, string cTag) {
        if (killed)//can occasionally trigger twice
            return;
        if (cTag == "Obstacle") {
            rb2d.simulated = false;
            thisRenderer.enabled = false;
            deathCanvas.SetActive(true);
            DeathCounter.Deaths++;
            if (cName == "Dragon") {
                Sound.PlaySound("dragon1");
                CreateDeathPrefab(bonesDeathPrefab);
            } else if (cName == "Fire") {
                Sound.PlaySound("pigeon on fire-trim");
                Sound.PlaySound("fried pigeon");
                CreateDeathPrefab(Random.Range(0, 2) == 0 ? cookedDeathPrefab : kfcDeathPrefab);
            } else if (cName == "Shot(Clone)") {
                Sound.PlaySound("splat");
                Instantiate(arrowDeathPrefab, transform.position, transform.rotation);
            } else {
                Sound.PlaySound("thud");
                CreateDeathPrefab(regularDeathPrefab);
            }
            killed = true;
        } else if (cTag == "Finish") {
            rb2d.simulated = false;
            thisRenderer.enabled = false;
            finishCanvas.SetActive(true);
            Sound.PlaySound("happy pigeon-trim");
        }
    }

    private void CreateDeathPrefab(GameObject prefab) {
        Rigidbody2D r = Instantiate(prefab, transform.position, transform.rotation).GetComponent<Rigidbody2D>();
        r.velocity = rb2d.velocity;
        r.angularVelocity = Random.Range(-spinVelocity, spinVelocity);
    }

}