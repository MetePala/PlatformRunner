using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] float _xPos, _xoffset;
    [SerializeField] PlayerController _playerController;
    [SerializeField] GameObject startPanel;
    void Start()
    {

    }
    void Update()
    {
        InputController();
    }

    private void FixedUpdate()
    {
        if (_xoffset != 0)
            _playerController.Hareket(_xoffset);
    }




    void InputController()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPanel.SetActive(false);
            _xPos = Input.mousePosition.x;
        }
       else if (Input.GetMouseButton(0))
        {
           
            _xoffset = Input.mousePosition.x - _xPos;
        }

       else if (Input.GetMouseButtonUp(0))
        {
            _xoffset = 0f;

        }
    }
}
