using System;
using UnityEngine;


public class Cube : MonoBehaviour
{
    private float _currentDistanceTravel;
    private float _maxDistanceTravel;
    private float _speed;

    public void Init(float maxDistanceTravel, float speed)
    {
        _speed = speed;
        _maxDistanceTravel = maxDistanceTravel;
    }

    private void Update()
    {
        if (_currentDistanceTravel >= _maxDistanceTravel)
        {
            Destroy(gameObject); 
        }
        
        float delta = _speed * Time.deltaTime;

        transform.position += transform.forward * delta;
        
        _currentDistanceTravel += delta;
    }

       
}
