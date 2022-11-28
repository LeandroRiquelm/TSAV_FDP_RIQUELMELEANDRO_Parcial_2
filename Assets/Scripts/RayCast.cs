using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    private new Transform camara;

    public float rayDistance;

    // Start is called before the first frame update
    void Start()
    {
        camara = transform.Find("Camara");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(camara.position, camara.forward * rayDistance, Color.red);

        RaycastHit hit;
        if(Physics.Raycast(transform.position, Vector3.forward, out hit))
        {
            string nombre = hit.collider.gameObject.name;
        }
    }
}
