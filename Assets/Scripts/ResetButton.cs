using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour {
    public GameObject stick1;
    public GameObject stick2;

    AudioSource audio;

    Vector3 pos1;
    Vector3 pos2;

    Quaternion rot1;
    Quaternion rot2;

    // Set initial transfrom
    void Start() {
        pos1 = stick1.transform.position;
        pos2 = stick2.transform.position;

        rot1 = stick1.transform.rotation;
        rot2 = stick2.transform.rotation;

        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) {
        //Debug.Log(other.gameObject.name);
        if(other.gameObject.name == "GrabVolumeBig") {
            audio.Play(0);
            stick1.gameObject.transform.SetPositionAndRotation(pos1, rot1);
            stick2.gameObject.transform.SetPositionAndRotation(pos2, rot2);
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
