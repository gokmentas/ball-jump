using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLevel : MonoBehaviour
{

    public float sensitivvity = 0.8f;

    private Vector3 mouse_reference;
    private Vector3 mouse_Offset;
    private Vector3 rotatiton;

    private bool isRotating;

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            mouse_Offset = Input.mousePosition - mouse_reference;
            rotatiton.y = -(mouse_Offset.x + mouse_Offset.y) * sensitivvity;

            transform.Rotate(rotatiton);
            
            mouse_reference = Input.mousePosition;
        }
    }

    private void OnMouseDown()
    {
        isRotating = true;

        mouse_reference = Input.mousePosition;
    }

    void OnMouseUp()
    {
        isRotating = false;
    }

} // class
