using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionCheck : MonoBehaviour
{

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Obstacle") || col.gameObject.CompareTag("HalfDonut"))
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector2.zero;
            Restart();
        }
    }

    void Restart()
    {
      
        transform.position = new Vector3(Random.Range(-1f, 1f), 0, -10.75f);

    }
}
