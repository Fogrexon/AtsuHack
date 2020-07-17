using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    Camera camera;

    void Start() {
        camera = Camera.main;
    }

    void Update() {
        float d = Input.GetAxis("Mouse ScrollWheel");
        if (d > 0f) {
            camera.orthographicSize = camera.orthographicSize * 0.9f;
        }
        if (d < 0f) {
            camera.orthographicSize = camera.orthographicSize * 1.1f;
        }
    }
}
