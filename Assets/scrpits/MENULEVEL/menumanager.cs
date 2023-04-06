using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class menumanager : MonoBehaviour
{
    [SerializeField] Transform kafa;

    [SerializeField] Transform strtbtn;

    private void Start()
    {
        kafa.transform.GetComponent<RectTransform>().DOLocalMoveX(0f, 1f).SetEase(Ease.InOutBack);
        strtbtn.transform.GetComponent<RectTransform>().DOLocalMoveY(-230f, 1f).SetEase(Ease.InOutBack);
    }

    public void oyunaBasla()
    {
        SceneManager.LoadScene("gameLevel");

    }




}
