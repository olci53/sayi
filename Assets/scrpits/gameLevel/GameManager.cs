using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform surepanel;

    [SerializeField] Transform yaziImage;

    [SerializeField] Transform ustDik;

    [SerializeField] Transform altDik;

    [SerializeField] Transform geriSayim;

    [SerializeField] Text üstTxt;

    [SerializeField] Text altTxt;

    private int a;

    private int b;

    private int c;

    void sureskor()
    {
        surepanel.GetComponent<CanvasGroup>().DOFade(1f, 2.5f).SetEase(Ease.InFlash);

        yaziImage.GetComponent<CanvasGroup>().DOFade(1f, 1f).SetEase(Ease.InFlash);
        
        ustDik.GetComponent<RectTransform>().DOLocalMoveX(0, 2f).SetEase(Ease.OutBack);

        altDik.GetComponent<RectTransform>().DOLocalMoveX(0, 2f).SetEase(Ease.OutBack);

        geriSayim.GetComponent<CanvasGroup>().DOFade(1.5f, 2.5f).SetEase(Ease.InOutBack);

    }


    private void Start()
    {
        sureskor();

        sayiLar();
    }


    public void OyunaBasla()
    {
        Debug.Log("basla");
    }

    public void sayiLar()
    {
        a = Random.Range(0, 100);                                              //Deðiþicek     

        b = Random.Range(0, 100);

        c = Random.Range(0, 100);

        üstTxt.text = "";

        altTxt.text = "";


    }

}
