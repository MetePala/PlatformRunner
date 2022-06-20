using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentsController : MonoBehaviour
{
    [SerializeField] Transform _girl;
    [SerializeField] Animator _girlAnimator;
    [SerializeField]bool rotation;
    bool startgame;
    private void Awake()
    {
        _girl = transform.parent;
        _girlAnimator = transform.parent.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
      if(startgame)
        _girl.transform.Translate(transform.forward * Time.deltaTime * 2);
        

        if (rotation)
        {
                _girl.transform.eulerAngles = new Vector3(0, 0, 0);
           
        }
           
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startgame = true;
            _girlAnimator.SetBool("__isRun", true);
        }

        if(_girl.transform.position.z>=40.8f)
        {
            _girlAnimator.SetBool("__isRun", false);
            _girl.transform.eulerAngles = new Vector3(0, 180, 0);
            Destroy(transform.GetComponent<OpponentsController>());
        }
       
    }



    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            rotation = false;
            if (_girl.position.x >= other.gameObject.transform.position.x)
            {
                _girl.transform.Rotate(0, 2, 0);
            }
            else if(_girl.position.x < other.gameObject.transform.position.x)
            {
                _girl.transform.Rotate(0, -2, 0);
            }

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            rotation = true;
        }
    }
}