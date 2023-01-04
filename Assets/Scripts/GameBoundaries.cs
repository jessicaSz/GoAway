using UnityEngine;

public class GameBoundaries : MonoBehaviour
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void LateUpdate()
    {
        Vector3 targetPosition = Camera.main.WorldToViewportPoint (transform.position);
        
        targetPosition.x = Mathf.Clamp01(targetPosition.x);
        targetPosition.y = Mathf.Clamp01(targetPosition.y);
        transform.position = _camera.ViewportToWorldPoint(targetPosition);
    }
}
