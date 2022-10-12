using System.Collections;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private CubeFactory _cubeFactory;

    [SerializeField] private FloatValue _respawnTime;
    [SerializeField] private FloatValue _speed;
    [SerializeField] private FloatValue _maxDistance;
    
    public void SpawnCube()
    {
        StartCoroutine(SpawnCubeWithDelay());
    }

    private IEnumerator SpawnCubeWithDelay()
    {
        yield return new WaitForSeconds(_respawnTime.Value);
        
        _cubeFactory.Create(_speed.Value, _maxDistance.Value);
    }
}
