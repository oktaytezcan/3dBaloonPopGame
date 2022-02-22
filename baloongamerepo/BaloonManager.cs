using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
public class BaloonManager : MonoBehaviour
{
   GameObject a;
    
   public GameObject panel;
    public GameObject BaloonObject;
    public int StartingNumberOfBalloons;
    
    [Header("Baloon Creation Variables")]
    

    public Vector3 MinPosition;
    public Vector3 MaxPosition;

    public float MinMovementSpeed;
    public float MaxMovementSpeed;

    public List<Color> AvailableColors = new List<Color>();

    
    public List<int> AvailableScores = new List<int>();

    bool oyun_durduruldu = false;
    public void durdur_btn()
    {
        oyun_durduruldu = !oyun_durduruldu;
        if (oyun_durduruldu==true)
        {
            Time.timeScale = 0.0f;

        }
        else
        {
            Time.timeScale = 1.0f;
        }


    }
    public void tekraroyna_btn()
    {
        //PlayerControls p = a.GetComponent<PlayerControls>();
        Time.timeScale = 1.0f;
      
        for (int i = 0; i < StartingNumberOfBalloons; i++)//oyunun baþýnda bir kez balonlarý yarattýk.
        {
            CreateBalloon();
        }
        



    }
    
    
   public void Start()
    {
        
        for (int i = 0; i < StartingNumberOfBalloons; i++)//oyunun baþýnda bir kez balonlarý yarattýk.
        {
            CreateBalloon();
        }
    }
    

    public void CreateBalloon()
    {
        float spawnX = Random.Range(MinPosition.x, MaxPosition.x);
        float spawnY = Random.Range(MinPosition.y, MaxPosition.y);
        float spawnZ = Random.Range(MinPosition.z, MaxPosition.z);

        Vector3 position = new Vector3(spawnX, spawnY, spawnZ);

        GameObject createdBalloon = GameObject.Instantiate(BaloonObject, position, Quaternion.identity);//balonun belli bi aralýkta random oluþmasýný saðladýk ve baloon objesini sahneye yükledik,rotaasyonunu engelledik.

        Balloon balloonScript = createdBalloon.GetComponent<Balloon>();//balloonmanagerda olusturdugumuz componentlarý balloon sýnýfýndaki nesneye atadýk.

        float moveSpeed = Random.Range(MinMovementSpeed, MaxMovementSpeed);//hýz aralýðý tanýmlayýp belli aralýklarda random hýz oluþturduk
        balloonScript.MovementSpeed = moveSpeed;

        int colorScoreIndex = Random.Range(0, AvailableColors.Count);//renkleri random seçip colorscorýndeksine atadýk.

        balloonScript.BalloonColor = AvailableColors[colorScoreIndex];//ürettiðimiz sayý ve skorlarý oluþturdugumuz listelere atadýk.
        balloonScript.Score = AvailableScores[colorScoreIndex];

        ChangeBalloonColor(balloonScript);
    }
    
    
    public void ChangeBalloonColor(Balloon balloonToChange)
    {
        Material baloonMat = balloonToChange.gameObject.GetComponent<MeshRenderer>().material;
        baloonMat.color = balloonToChange.BalloonColor;
    }

    public void ShootBalloon(Balloon balloonToDestroy)//týkladýðýmýz balonu yok ettiðimiz fonksiyon
    {
        GameObject.Destroy(balloonToDestroy.transform.gameObject); 
    }

  








    }


