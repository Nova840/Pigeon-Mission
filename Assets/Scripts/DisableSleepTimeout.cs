using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableSleepTimeout : MonoBehaviour {

    private void Awake() {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

}