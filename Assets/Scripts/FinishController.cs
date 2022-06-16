using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishController : MonoBehaviour
{
    [SerializeField] GameObject _playerController;
    [SerializeField] GameObject _paintController;
    [SerializeField] GameObject _paintWall;
    [SerializeField] Animator _playerAnimator;

    private void OnCollisionStay(Collision collision)
    {
        _playerController.SetActive(false);
        _paintController.SetActive(true);
        _paintWall.SetActive(true);
        _playerAnimator.SetBool("__isRun", false);
    }
}
