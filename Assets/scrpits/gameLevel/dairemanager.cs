using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class dairemanager : MonoBehaviour
{
    [SerializeField] private GameObject[] dairelerDizi;
    
    void Dairescalekapat()
    {
        foreach(GameObject dair in dairelerDizi)
        {
            dair.GetComponent<RectTransform>().localScale = Vector3.zero;

        }
    }

    private void Start()
    {
        Dairescalekapat();
    }

    public void Dairescaleac(int hangiDaire)
    {
        dairelerDizi[hangiDaire].GetComponent<RectTransform>().DOScale(1, 0.3f);

        if (hangiDaire%5 == 0)
        {
            Dairescalekapat();
        }
    }


    
}
