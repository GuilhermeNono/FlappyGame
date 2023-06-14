using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 3;
    public float deadZone = -12;

    private Transform _transform;
    // Start is called before the first frame update
    private void Start()
    {
        _transform = transform;
    }

    // Update is called once per frame
    private void Update()
    {
        _transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
        if (_transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
