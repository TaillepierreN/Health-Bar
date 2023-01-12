using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Camera _camera;
    Vector3 mousePos;
    private void Start()
    {
        _camera = Camera.main;

    }
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        mousePos = Input.mousePosition - GetMousePosition();
    }
    private void OnMouseDrag()
    {
        transform.position = _camera.ScreenToWorldPoint(Input.mousePosition - mousePos);
    }
    Vector3 GetMousePosition()
    {
        return _camera.WorldToScreenPoint(transform.position);
    }
}
