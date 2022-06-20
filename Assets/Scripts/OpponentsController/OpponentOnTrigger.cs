using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentOnTrigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("HalfDonut"))
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector2.zero;
            transform.position = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-12.5f, -10f));
        }
    }

    private void OnCollisionStay(Collision col)
    {
        if(col.gameObject.CompareTag("RotatePlatform"))
        {
            float a = Random.Range(0, 2.5f);
            
            if(a>=1)
            transform.Translate(transform.right * Time.deltaTime * 2);

            else
                transform.Translate(-transform.right * Time.deltaTime * 2);
        }
    }
}
