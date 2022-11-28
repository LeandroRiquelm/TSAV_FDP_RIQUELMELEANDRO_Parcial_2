using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacion : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(x, 0, z);
        if (move.magnitude > 0.1f)
        {
            animator.SetBool("Movimiento", true);
        }
        else
        {
            animator.SetBool("Movimiento", false);
        }

    }
}
