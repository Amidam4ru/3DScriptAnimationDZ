using UnityEngine;

public class Scalator : MonoBehaviour
{
    [SerializeField] private float _scalingSpeed = 1f;

    private void Update()
    {
        transform.localScale += Vector3.one * _scalingSpeed * Time.deltaTime;
    }
}
