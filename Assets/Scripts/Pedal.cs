using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour {
    public GameObject stick1;
    public GameObject stick2;

    // Start is called before the first frame update
    void Start() {
        
    }


    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "CustomHandRight") {
            stick1.gameObject.transform.position = new Vector3(0.254f, 0.678f, -0.142f);

        }
    }
    // Update is called once per frame
    void Update() {
        
        
    }
}
