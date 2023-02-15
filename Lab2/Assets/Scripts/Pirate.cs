using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pirate : MonoBehaviour
{
    private AudioSource audio1;
    public string text;

    // Start is called before the first frame update
    void Start()
    {
        audio1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col) {
        print("Collision");
        if (col.gameObject.tag == "Player") {
            audio1.Play();
            GameManager.Instance.DialogShow(text);
        }
    }
    
    public void OnTriggerExit2D(Collider2D collider2D) {
        if (collider2D.gameObject.CompareTag("Player")) {
            GameManager.Instance.DialogHide();
        }
    }

}
