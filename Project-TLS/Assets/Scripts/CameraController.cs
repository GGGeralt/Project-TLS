using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float panSpeed = 20;
    [SerializeField] float panBorder = 10;

    [SerializeField] float scrollSpeed = 20f;
    [SerializeField] float minY = 20f;
    [SerializeField] float maxY = 140f;

    [SerializeField] Vector3 cameraPlayerPosition;

    private void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.W) || Input.mousePosition.y >= Screen.height - panBorder)
        {
            pos.z += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || Input.mousePosition.y <= panBorder)
        {
            pos.z -= panSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) || Input.mousePosition.x >= Screen.width - panBorder)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.mousePosition.x <= panBorder)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pos = Player.Instance.transform.position + cameraPlayerPosition;
        }

        pos.y -= Input.GetAxis("Mouse ScrollWheel") * scrollSpeed * 100f * Time.deltaTime;

        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        transform.position = pos;
    }
}
