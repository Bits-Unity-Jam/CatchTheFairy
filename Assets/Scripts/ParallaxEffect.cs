using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField] Transform _followingTarget;
    [SerializeField, Range(0f, 1f)] float _parallaxStrength;
    [SerializeField] bool _disableVerticalParallax;
    Vector3 _targetPreviousPosition;
    void Start()
    {
        if (!_followingTarget)
        {
            _followingTarget = Camera.main.transform;
        }
    }

    void Update()
    {
        var delta = _followingTarget.position - _targetPreviousPosition;
        if (_disableVerticalParallax)
        {
            delta.y = 0;
        }
        //_targetPreviousPosition = _followingTarget.position;
        //transform.position += delta * _parallaxStrength;
        transform.position = Vector2.Lerp(transform.position, delta, _parallaxStrength * Time.deltaTime) ;
    }
}
