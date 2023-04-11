using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timemanager : MonoBehaviour
{
    [SerializeField] private Text sureTxt;

    int kalansure;

    bool sureSaysinmi;

    private void Start()
    {
        kalansure = 90;
        sureSaysinmi = true;
    }

    public void SureyiBaslat()
    {
        StartCoroutine(Suresay());
    }


    IEnumerator Suresay()
    {
        while (sureSaysinmi)
        {
            yield return new WaitForSeconds(1f);

            if (kalansure < 10)
            {
                sureTxt.text = "0"+ kalansure.ToString();
            }
            else
            {
                sureTxt.text = kalansure.ToString();
            }


            if (kalansure <= 0)
            {
                sureSaysinmi=false;
            }

            kalansure--;
        }

    }


}
