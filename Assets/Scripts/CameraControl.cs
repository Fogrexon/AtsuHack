using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    Camera camera;
    Vector2 prevMouse;

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

        if (Input.GetMouseButton(2) || Input.GetKey(KeyCode.Space)) {
            camera.transform.position = new Vector3(
                -(Input.mousePosition.x - prevMouse.x) * camera.orthographicSize / Screen.height * 2f + camera.transform.position.x,
                -(Input.mousePosition.y - prevMouse.y) * camera.orthographicSize / Screen.height * 2f + camera.transform.position.y,
                camera.transform.position.z
            );
        }

        prevMouse = Input.mousePosition;
    }
}
