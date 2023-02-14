using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pirate : MonoBehaviour
{
    private AudioSource audio1;

    // Start is called before the first frame update
    void Start()
    {
        audio1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        print("Collision");
        if (col.gameObject.tag == "Player") {
            audio1.Play();
        }
    }

}
