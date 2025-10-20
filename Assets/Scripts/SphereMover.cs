using UnityEngine;

public class SphereMover : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private void Update()
    {
        transform.position += Vector3.forward * _speed * Time.deltaTime;
    }
}
