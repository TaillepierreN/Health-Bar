using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] int damage = 10;
    Camera _camera;
    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

    }
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
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Player>().GetHurt(damage);
            Destroy(gameObject);
        }
        else
        {
            other.gameObject.GetComponent<Ally>().GetHurt(damage);
            Destroy(gameObject);
        }

    }
}
