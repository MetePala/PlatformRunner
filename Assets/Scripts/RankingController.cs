using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingController : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;
    [SerializeField] Transform[] opponents;
    [SerializeField] Text _rankText , _lastRankText;
    public static int _rank;

    private void FixedUpdate()
    {
        if(_playerTransform.transform.position.z<39.2f)
        {
            foreach (Transform item in opponents)
            {
                if (item.position.z >= _playerTransform.position.z)
                {
                    _rank++;
                }
            }
            _lastRankText.text = "Rank:" + (_rank + 1).ToString();
            _rankText.text = (_rank + 1).ToString() + "/11";
            _rank = 0;
        }
    }
}
