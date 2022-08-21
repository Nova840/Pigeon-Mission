using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class SetTextToVersion : MonoBehaviour {

    private void Start() {
        GetComponent<Text>().text = "v" + Application.version;
    }

}