using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    private Vector3 _prevMousePosition;
    public Transform Level;
    public float LevelRotateSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _prevMousePosition;
            Level.Rotate(0, -delta.x * LevelRotateSpeed, 0);

        }


  

       _prevMousePosition = Input.mousePosition;
    }
}
