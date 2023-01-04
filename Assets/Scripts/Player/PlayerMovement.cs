using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Vector2 speed = new Vector2(20, 20);

    private void Update()
    {
        var axisX = Input.GetAxis("Horizontal");
        var axisY = Input.GetAxis("Vertical");

        var movement = new Vector3(speed.x * axisX, speed.y * axisY) * Time.deltaTime;

        transform.Translate(movement);
    }
}
