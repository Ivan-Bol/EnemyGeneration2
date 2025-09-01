using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    private Transform _purposePosition;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _purposePosition.position, _movementSpeed * Time.deltaTime);
    }

    public void Initialize(Vector3 startPosition, Transform purposePosition)
    {
        transform.position = startPosition;
        _purposePosition = purposePosition;
    }
}