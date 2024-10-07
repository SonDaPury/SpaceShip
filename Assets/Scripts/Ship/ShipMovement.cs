using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField]
    protected Vector3 worldPosition;

    [SerializeField]
    protected float speed = 0.1f;

    private void FixedUpdate()
    {
        worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPosition.z = 0;

        Vector3 newPosition = Vector3.Lerp(transform.position, worldPosition, speed); // Position của ship khi di chuyển đến điểm đích
        transform.position = newPosition;
    }
}
