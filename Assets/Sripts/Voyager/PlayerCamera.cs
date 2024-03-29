﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    public Transform lookAt;

    private Vector3 desiredPosition;
    private float offset = 0.3f;
    private float distance = 1.5f;

    private void Update()
    {
        //Update the position
        desiredPosition = lookAt.position + (-transform.forward * distance) + (transform.up * offset);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, 0.05f);

        //Update the rotation
        transform.LookAt(lookAt.position + (Vector3.up * offset));
    }
}
