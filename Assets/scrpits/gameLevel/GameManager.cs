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

    Timemanager timermanager;

    private void Awake()
    {
        timermanager = Object.FindObjectOfType<Timemanager>();
    }


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

        üstTxt.text = "";
        altTxt.text = "";
    }


    public void OyunaBasla()
    {
        üstTxt.text = "asdasd";

        altTxt.text = "asdasd";

        timermanager.SureyiBaslat();
    }

 


}
