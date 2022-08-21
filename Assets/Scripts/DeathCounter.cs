using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class DeathCounter : MonoBehaviour {

    private static int deaths = 0;
    public static int Deaths {
        get { return deaths; }
        set {
            PlayerPrefs.SetInt(DeathsKey, deaths = value);
        }
    }
    public const string DeathsKey = "Deaths";

    private Text text;

    private void Awake() {
        text = GetComponent<Text>();
    }

    private void Start() {
        if (PlayerPrefs.HasKey(DeathsKey))
            Deaths = PlayerPrefs.GetInt(DeathsKey);
        else
            PlayerPrefs.SetInt(DeathsKey, 0);
    }

    private void Update() {
        text.text = "Pigeons Killed: " + deaths;
    }

}