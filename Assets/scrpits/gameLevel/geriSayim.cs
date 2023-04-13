using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.PlayerLoop;

public class geriSayim : MonoBehaviour
{
    [SerializeField] private GameObject geriSayimobj;

    [SerializeField] private Text geriSayimtext;

    GameManager GameManager;

    

    IEnumerator geriSayma()
    {
        geriSayimtext.text = "3";
        yield return new WaitForSeconds(0.5f);

        geriSayimobj.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        geriSayimobj.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.5f);

        geriSayimtext.text = "2";
        yield return new WaitForSeconds(0.5f);

        geriSayimobj.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        geriSayimobj.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.5f);

        geriSayimtext.text = "1";
        yield return new WaitForSeconds(0.5f);

        geriSayimobj.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        geriSayimobj.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.5f);

        

        StopAllCoroutines();

        GameManager.OyunaBasla();
    }

    private void Start()
    {
        StartCoroutine(geriSayma());
    }


    private void Awake()
    {
        GameManager = Object.FindObjectOfType<GameManager>();
    }

}
