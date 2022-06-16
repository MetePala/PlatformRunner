using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;
    [SerializeField] Animator _playerAnim;
    [SerializeField] float _playerSpeed;
    [SerializeField] float _playerXSpeed;
    [SerializeField] float _smoothTime;
    [SerializeField]float _amount;
    bool _run;
    private void FixedUpdate()
    {
       
       if(_run)
        _playerTransform.Translate(_playerTransform.forward * Time.deltaTime * _playerSpeed);


    }



    private void Update()
    {
      if(Input.GetMouseButton(0))
        {
            _run = true;
            _playerAnim.SetBool("__isRun", true);
        }
      if(Input.GetMouseButtonUp(0))
        {
            _run = false;
            _playerAnim.SetBool("__isRun", false);
        }
    }

    public void Hareket(float x)
    {
        _amount = x * _playerXSpeed * Time.deltaTime;

      //  _amount = Mathf.Clamp(_amount, -1f, 1f);

        Vector3 target = new Vector3(_amount, _playerTransform.position.y, _playerTransform.position.z);
        _playerTransform.position = Vector3.Lerp(_playerTransform.position, target, _smoothTime);

    }


}
