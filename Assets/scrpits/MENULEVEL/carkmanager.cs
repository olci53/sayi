using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carkmanager : MonoBehaviour
{
    public int speed = 30;


    private void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);

    }
}
