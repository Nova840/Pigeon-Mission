using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour {

    /*
    [SerializeField]
    private GameObject player;

    private Rigidbody2D playerRb2D;
    private Renderer playerRenderer;
    private PlayerCollision playerDeath;
    private MovePlayer movePlayer;

    private void Start() {
        playerRb2D = player.GetComponent<Rigidbody2D>();
        playerRenderer = player.GetComponent<Renderer>();
        playerDeath = player.GetComponent<PlayerCollision>();
        movePlayer = player.GetComponent<MovePlayer>();
    }
    */

    private void Update() {
        if (Input.GetButtonDown("R")) {
            //StartCoroutine(DelayFrame());
            Restart();
        } else if (Input.GetButtonDown("B")) {
            Back();
        }
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Back() {
        SceneManager.LoadScene("Start");
    }

    /*
    private IEnumerator DelayFrame() {
        yield return new WaitForSeconds(0);
        player.transform.position = playerDeath.SpawnPoint;
        player.transform.rotation = Quaternion.identity;
        playerRb2D.simulated = true;
        playerRb2D.angularVelocity = 0;
        playerRb2D.velocity = Vector2.zero;
        playerRenderer.enabled = true;
        gameObject.SetActive(false);
        ObstacleList.ClearObstacles();
        movePlayer.HasTakenOff = false;
    }
    */

}