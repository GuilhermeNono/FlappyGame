using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject _gameObject;
    public float spawnRate = 2;
    private float timer;
    public float heightOffset = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    private void SpawnPipe()
    {
        var heightestPoint = transform.position.y + heightOffset;
        var lowestPoint = transform.position.y - heightestPoint;
        var newPipePosition = new Vector3(transform.position.x, Random.Range(lowestPoint, heightestPoint));
        Instantiate(_gameObject, newPipePosition , transform.rotation);
    }
}
