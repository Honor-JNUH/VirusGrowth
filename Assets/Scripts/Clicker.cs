using UnityEngine;
using System.Collections;

public class Clicker : MonoBehaviour
{
    public GameObject circlePrefab;
    GameObject circle;
    Vector3 inputPos { get { Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition); pos.z = 0; return pos; } }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            circle = (GameObject) Instantiate(circlePrefab, inputPos, Quaternion.FromToRotation(Vector3.up, Vector3.up));
        }

        if (Input.GetMouseButton(0)) {
            Vector3 pos = circle.transform.position;
            circle.transform.Translate(inputPos - pos);
        }

        if (Input.GetMouseButtonUp(0)) {
            Destroy(circle);
        }
    }
}
