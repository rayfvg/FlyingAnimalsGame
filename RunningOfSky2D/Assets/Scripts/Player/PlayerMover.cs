using UnityEngine;

namespace Player
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private float _MoveSpeed;
        [SerializeField] private float _stepSize;
        [SerializeField] private float _maxHeightY;
        [SerializeField] private float _minHeightY;

        private Vector3 _targetPosition;

        private void Start() => _targetPosition = transform.position;
        private void Update()
        {
            if (transform.position != _targetPosition)
                transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _MoveSpeed * Time.deltaTime);
        }
        public void TryMoveUp()
        {
            if (transform.position.y < _maxHeightY)
                SetNextPosition(_stepSize);
        }
        public void TryMoveDown()
        {
            if (transform.position.y > _minHeightY)
                SetNextPosition(-_stepSize);
        }
        private void SetNextPosition(float stepSize) => _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + stepSize);
    }
}