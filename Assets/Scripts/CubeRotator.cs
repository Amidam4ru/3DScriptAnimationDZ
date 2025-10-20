using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 1f;

    private void Update()
    {
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime, Space.Self);
    }
}
