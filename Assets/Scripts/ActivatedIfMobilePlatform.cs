using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatedIfMobilePlatform : MonoBehaviour {

    [SerializeField]
    private bool activated = true;

    private void Start() {
        gameObject.SetActive(Application.isMobilePlatform ? activated : !activated);
    }

}