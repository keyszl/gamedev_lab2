using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parrot : MonoBehaviour
{
    private AudioSource audio1;

    private Rigidbody2D body;
    public float horizontal;
    public float vertical;

    private float moveLimiter = 0.7f;

    public float runSpeed = 5f;

     public ParticleSystem part;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        audio1 = GetComponent<AudioSource>();
        audio1.Play();
        part = GetComponent<ParticleSystem>();
        part.Stop();

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        if (horizontal != 0 && vertical != 0) {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

     void OnTriggerEnter2D(Collider2D col) {
        print("Collision");
        if (col.gameObject.tag == "Fruit") {
            part.Play();  
            Destroy(col.gameObject);
        }

}
}
