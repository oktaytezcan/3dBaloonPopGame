using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Balloon : MonoBehaviour
{
    public float MovementSpeed;
    public Color BalloonColor;
    public int Score;
    

    private void FixedUpdate() // SANİYEDE sabit bir sayı ile çalışmasıdır.
    {
        transform.position += new Vector3(0,MovementSpeed * Time.deltaTime,0);//nesnenin pozisyonunu değiştik ve uçmamaması için yavaşlattık.
    }
}