using System;
using UnityEngine;

public class CubeFactory : MonoBehaviour
{
    [SerializeField] private Cube _template;
    [SerializeField] private Transform _spawn;
        
    public void Create(float speed, float maxDistanceTravel)
    {
        Cube cube = Instantiate(_template, _spawn.position, Quaternion.identity);
            
        cube.Init(maxDistanceTravel, speed);
    }
}