using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform surepanel;

    [SerializeField] Transform yaziImage, buyukYazi;

    [SerializeField] Transform ustDik;

    [SerializeField] Transform altDik;

    [SerializeField] Transform geriSayim;

    [SerializeField] Text üstTxt;

    [SerializeField] Text altTxt;

    Timemanager timermanager;

    dairemanager Dairemanager;

    int oyunsayac, kacincioyun;
    int ustDeger, altDeger;
    int Buyukdeger;

    int butonDegeri;

    private void Awake()
    {
        timermanager = Object.FindObjectOfType<Timemanager>();
        Dairemanager = Object.FindObjectOfType<dairemanager>();
    }


    void sureskor()
    {
        surepanel.GetComponent<CanvasGroup>().DOFade(1f, 2.5f).SetEase(Ease.InFlash);

        yaziImage.GetComponent<RectTransform>().DOLocalMoveX(0f, 1f).SetEase(Ease.OutBack);

        ustDik.GetComponent<RectTransform>().DOLocalMoveX(0, 2f).SetEase(Ease.OutBack);

        altDik.GetComponent<RectTransform>().DOLocalMoveX(0, 2f).SetEase(Ease.OutBack);

        geriSayim.GetComponent<CanvasGroup>().DOFade(1.5f, 2.5f).SetEase(Ease.InOutBack);

    }


    private void Start()
    {
        kacincioyun = 0;
        oyunsayac = 0;

        üstTxt.text = "";
        altTxt.text = "";

        sureskor();

    }


    public void OyunaBasla()
    {
        yaziImage.GetComponent<CanvasGroup>().DOFade(0f, 1f).SetEase(Ease.OutBack);
        buyukYazi.GetComponent<CanvasGroup>().DOFade(1f, 1.4f).SetEase(Ease.InFlash);
        timermanager.SureyiBaslat();

        Kacincioyun();
    }


    void Kacincioyun()
    {
        if (oyunsayac < 5)
        {
            kacincioyun = 1;
        }else if (oyunsayac>=5 && oyunsayac<10)
        {
            kacincioyun = 2;
        }else if (oyunsayac>=10 && oyunsayac<15)
        {
            kacincioyun=3;
        }else if (oyunsayac>=15 && oyunsayac<20)
        {
            kacincioyun = 4;
        }else if (oyunsayac>=20 && oyunsayac<25)
        {
            kacincioyun=5;
        }

        switch (kacincioyun)
        {
            case 1:
                Biricifonksiyon();
                break;
            
            case 2 :
                Ýkincifonksiyon();
                break;
            case 3:
                Ucuncufonksiyon();
                break;
            case 4:
                Dorduncufonksiyon();
                break;
            case 5:
                Besincifonksiyon();
                break;


        }
    }


    void Biricifonksiyon()
    {
        int RastgeleDeger = Random.Range(0, 50);

        if (RastgeleDeger <= 25)
        {
            ustDeger = Random.Range(2, 50);
            altDeger = ustDeger + Random.Range(1, 10);
        }
        else
        {
            ustDeger = Random.Range(2, 50);
            altDeger = Mathf.Abs(ustDeger - Random.Range(1, 10));
        }

        if (ustDeger > altDeger)
        {
            Buyukdeger = ustDeger;
        }
        else
        {
            Buyukdeger = altDeger;
        }

        if (ustDeger == altDeger)
        {
            Biricifonksiyon();
            return;
        }

        üstTxt.text = ustDeger.ToString();
        altTxt.text = altDeger.ToString();

        //Debug.Log("büyük deger" + Buyukdeger);
    }

    void Ýkincifonksiyon()
    {
        int birincisayi = Random.Range(1, 10);
        int ikincisayi = Random.Range(1, 20);
        int ucuncusayi = Random.Range(1, 10);
        int dorduncusayi = Random.Range(1, 20);

        ustDeger = birincisayi + ikincisayi;
        altDeger = ucuncusayi + dorduncusayi;

        if (ustDeger > altDeger)
        {
            Buyukdeger = ustDeger;

        }else if (ustDeger < altDeger)
        {
            Buyukdeger = altDeger;
        }

        if (ustDeger == altDeger)
        {
            Ýkincifonksiyon();
            return;
        }

        üstTxt.text = birincisayi + "+" + ikincisayi;
        altTxt.text = ucuncusayi + "+" + dorduncusayi;
    }

    void Ucuncufonksiyon()
    {
        int birincisayi = Random.Range(11, 30);
        int ikincisayi = Random.Range(1, 11);
        int ucuncusayi = Random.Range(11, 30);
        int dorduncusayi = Random.Range(1, 11);

        ustDeger = birincisayi - ikincisayi;
        altDeger = ucuncusayi - dorduncusayi;

        if (ustDeger > altDeger)
        {
            Buyukdeger = ustDeger;

        }
        else if (ustDeger < altDeger)
        {
            Buyukdeger = altDeger;
        }

        if (ustDeger == altDeger)
        {
            Ucuncufonksiyon();
            return;
        }

        üstTxt.text = birincisayi + "-" + ikincisayi;
        altTxt.text = ucuncusayi + "-" + dorduncusayi;


    }

    void Dorduncufonksiyon()
    {
        int birincisayi = Random.Range(1, 10);
        int ikincisayi = Random.Range(1, 20);
        int ucuncusayi = Random.Range(1, 10);
        int dorduncusayi = Random.Range(1, 20);

        ustDeger = birincisayi * ikincisayi;
        altDeger = ucuncusayi * dorduncusayi;

        if (ustDeger > altDeger)
        {
            Buyukdeger = ustDeger;

        }
        else if (ustDeger < altDeger)
        {
            Buyukdeger = altDeger;
        }

        if (ustDeger == altDeger)
        {
            Dorduncufonksiyon();
            return;
        }

        üstTxt.text = birincisayi + "*" + ikincisayi;
        altTxt.text = ucuncusayi + "*" + dorduncusayi;
    }
    void Besincifonksiyon()
    {
        int birincisayi = Random.Range(1, 20);
        int ikincisayi = Random.Range(1, 10);
        int ucuncusayi = Random.Range(1, 20);
        int dorduncusayi = Random.Range(1, 10);

        ustDeger = Mathf.Abs(birincisayi / ikincisayi);
        altDeger = Mathf.Abs(ucuncusayi / dorduncusayi);

        if (ustDeger > altDeger)
        {
            Buyukdeger = ustDeger;

        }
        else if (ustDeger < altDeger)
        {
            Buyukdeger = altDeger;
        }

        if (ustDeger == altDeger)
        {
            Besincifonksiyon();
            return;
        }

        if (birincisayi<ikincisayi)
        {
            Besincifonksiyon();
            return;
        }else if (ucuncusayi<dorduncusayi)
        {
            Besincifonksiyon();
            return;
        }

        üstTxt.text = birincisayi + ":" + ikincisayi;
        altTxt.text = ucuncusayi + ":" + dorduncusayi;
    }

    public void ButonDegeriniBelirle(string Butonadi)
    {
        if (Butonadi == "ustButton")
        {
            butonDegeri = ustDeger;
        }
        else if (Butonadi == "altButton")
        {
            butonDegeri = altDeger;
        }

        if (butonDegeri == Buyukdeger)
        {
            
            Dairemanager.Dairescaleac(oyunsayac % 5);
            oyunsayac++;

            Kacincioyun();
        }else
        {
            
        }
    }

}