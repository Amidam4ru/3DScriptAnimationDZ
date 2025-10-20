using UnityEngine;

public class CubeTransformator : MonoBehaviour
{
    [SerializeField] private float _scalingSpeed = 1f;
    [SerializeField] private float _rotateSpeed = 1f;
    [SerializeField] private float _moveSpeed = 1f;

    private void Update()
    {
        transform.localScale += Vector3.one * _scalingSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime, Space.Self);
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime, Space.Self);
    }
}
