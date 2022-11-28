using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoColision : MonoBehaviour
{
    public AudioSource colisionAudio;

    // Start is called before the first frame update
    void Start()
    {
        colisionAudio = GameObject.Find(name: "PowerFieldCollision").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "JugadorCiborg")
        {
            colisionAudio.Play();
        }
    }
}
