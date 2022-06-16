using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintController : MonoBehaviour
{
    [SerializeField] GameObject _paint;
    float size = 0.02f;
    int _paintCount;
    
    void Update()
    {
        
        if(Input.GetMouseButton(0))
        {
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(Ray,out hit) && hit.transform.CompareTag("PaintWall"))
            {
                var go = Instantiate(_paint, hit.point + (Vector3.forward* -0.1f), _paint.transform.rotation, transform);
                go.transform.localScale = Vector3.one * size;
                _paintCount++;
                
               
            }
        }
    }
}
