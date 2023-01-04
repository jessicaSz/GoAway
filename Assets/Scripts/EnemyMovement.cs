using System;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    private Transform _player;

    private bool _canMove = true;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerMovement>().gameObject.transform;
    }

    private void Update()
    {
        if (!_canMove) return;

        var distance = Vector2.Distance(_player.position, transform.position);

        if (!(distance < 3)) return;

        var direction = transform.position - _player.position;

        float moveSpeed = speed * Time.deltaTime;
        transform.position =
            Vector3.MoveTowards(transform.position, transform.position + direction, moveSpeed );
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag("Player"))
        {
            return;
        }

        _canMove = false;
    }
}
