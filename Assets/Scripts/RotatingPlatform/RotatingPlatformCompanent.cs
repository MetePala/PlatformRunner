using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatformCompanent : MonoBehaviour
{

    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.gameObject.transform.SetParent(gameObject.transform);
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.transform.eulerAngles = new Vector3(0, 0, 0);
            col.collider.transform.SetParent(null);
            
        }
    }
}
