using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishController : MonoBehaviour
{
    [SerializeField] GameObject _playerController;
    [SerializeField] GameObject _paintController;
    [SerializeField] GameObject _paintWall;
    [SerializeField] Animator _playerAnimator;
    [SerializeField] GameObject _particle1, _particle2, _particle3;
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            _particle1.SetActive(true);
            _particle2.SetActive(true);
            _particle3.SetActive(true);
            _playerController.SetActive(false);
            _paintController.SetActive(true);
            _paintWall.SetActive(true);
            _playerAnimator.SetBool("__isRun", false);
            collision.transform.position = new Vector3(0, 0, 39.2f);
            collision.gameObject.GetComponent<Rigidbody>().isKinematic=true;
        }
      
    }
  

}
