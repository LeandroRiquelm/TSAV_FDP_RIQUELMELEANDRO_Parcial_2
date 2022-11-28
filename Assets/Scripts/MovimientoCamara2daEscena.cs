using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara2daEscena : MonoBehaviour
{
    float panSpeed = 20f;
    float panBorderThickness = 10f;
    Vector2 panLimit;

    float scrollSpeed = 20f;
    float minY = 20f;
    float maxY = 120f;

    float rotationX = 0f;
    float rotationY = 0f;

    public float sensibilidad = 15f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            pos.z += panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            pos.z -= panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            pos.x += panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        pos.z = Mathf.Clamp(pos.x, -panLimit.y, panLimit.y);
    }

    void Rotacion()
    {
        rotationY += Input.GetAxis("Mouse X") * sensibilidad;
        rotationX += Input.GetAxis("Mouse Y") * -1 * sensibilidad;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
