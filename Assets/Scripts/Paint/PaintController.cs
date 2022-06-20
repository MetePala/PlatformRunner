using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintController : MonoBehaviour
{
    [SerializeField] GameObject _paint;
    [SerializeField] Slider _slider;
    float size = 0.2f;
    float timer;
    [SerializeField] GameObject finishPanel;
    [SerializeField] Text _rankText, _paintText;
    float finishTime;
    void Update()
    {
        finishTime += Time.deltaTime;
        if(finishTime>=11.5f)
        {
           // _rankText.text = "Rank:"+(RankingController._rank+1).ToString();
            _paintText.text = "Painted(%):" + _slider.value.ToString("##.#");
            finishPanel.SetActive(true);
            Time.timeScale = 0;

        }


        
        if(Input.GetMouseButton(0))
        {
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(Ray,out hit) && hit.transform.CompareTag("PaintWall"))
            {
                timer += Time.deltaTime;
                if(timer>=0.015f)
                {
                    var go = Instantiate(_paint, hit.point + (Vector3.forward * -0.005f), _paint.transform.rotation);
                    go.transform.localScale = new Vector3(1 * size, 1 * size, 0.01f);
                    _slider.value+=0.15f;
                    timer = 0;
                }
            }
        }

        
    }
}
