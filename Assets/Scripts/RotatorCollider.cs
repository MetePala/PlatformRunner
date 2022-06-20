using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorCollider : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Girl"))
        {
            Rigidbody _rigid = other.gameObject.GetComponent<Rigidbody>();
            Vector3 _vector = other.gameObject.transform.position - transform.position;
            _rigid.velocity = _vector * 7;
        }
       
    }
}
