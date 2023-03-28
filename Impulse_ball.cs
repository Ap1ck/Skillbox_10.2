using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse_ball : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {     
      if (Input.GetKey(KeyCode.Space))
      {
         _rigidbody.AddForce(Vector3.left * _speed, ForceMode.Impulse);
      } 
    }
}
