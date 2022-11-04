using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drum : MonoBehaviour {
    AudioSource audio;

    // Start is called before the first frame update
    void Start() {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "Head") {
            audio.Play(0);
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
