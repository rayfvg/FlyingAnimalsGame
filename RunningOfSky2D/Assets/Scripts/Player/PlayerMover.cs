using UnityEngine;

namespace Player
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private float _MoveSpeed;
        [SerializeField] private float _stepSize;
        [SerializeField] private float _maxHeightY;
        [SerializeField] private float _minHeightY;
        [SerializeField] private AudioSource _audioSource;

        private Vector3 _targetPosition;

        private void Start() => _targetPosition = transform.position;
        private void Update()
        {
            if (transform.position.y > _maxHeightY)
                transform.position = new Vector2(transform.position.x, _maxHeightY);
            
            if (transform.position.y < _minHeightY)
                transform.position = new Vector2(transform.position.x, _minHeightY);

            if(_targetPosition.y > _maxHeightY)
                _targetPosition = new Vector2(_targetPosition.x, _maxHeightY);

            if (_targetPosition.y < _minHeightY)
                _targetPosition = new Vector2(_targetPosition.x, _minHeightY);

            if (transform.position != _targetPosition)
                transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _MoveSpeed * Time.deltaTime);
        }
        public void TryMoveUp()
        {
            if (transform.position.y < _maxHeightY)
                SetNextPosition(_stepSize);
            if(Time.timeScale >= 1)
            _audioSource.Play();

        }
        public void TryMoveDown()
        {
            if (transform.position.y > _minHeightY)
                SetNextPosition(-_stepSize);
            if(Time.timeScale >=1)
            _audioSource.Play();
        }
        private void SetNextPosition(float stepSize) => _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + stepSize);
    }
}