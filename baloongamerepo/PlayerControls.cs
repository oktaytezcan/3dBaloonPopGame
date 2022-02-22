using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public int PlayerScore = 0;
    public TextMeshProUGUI ScoreText;

    public BaloonManager BalloonManager;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//kameradan ekrana ray tipi d�nd�rd�k.
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))//sonsuza ���n  g�ndermemek i�in 100 tan�mlad�k fonksiyonun de�erleri hit de�i�keninde tutuluyor.
            {
                Debug.Log(hit.transform.gameObject.name);

                Balloon clickedBalloon = hit.transform.gameObject.GetComponent<Balloon>();//balloon s�n�f�n�n compenentlerini nesnemize atad�k.

                if (clickedBalloon != null)
                {
                    BalloonManager.ShootBalloon(clickedBalloon);//nesnemizi balloonmanagerdaki shootbaloon fonksiyonuna atay�p destroylad�k.

                    if (clickedBalloon.BalloonColor.Equals(BalloonManager.AvailableColors[0]))
                    {//listemizin indekslerine ula��p renge g�re puan ekledik.
                        Debug.Log("1");

                        PlayerScore -= 2;
                        ScoreText.text = PlayerScore.ToString();
                    }

                    else if (clickedBalloon.BalloonColor.Equals(BalloonManager.AvailableColors[1]))
                    {
                        Debug.Log("2");
                        PlayerScore += 1;
                        ScoreText.text = PlayerScore.ToString();
                    }
                    else if (clickedBalloon.BalloonColor.Equals(BalloonManager.AvailableColors[2]))
                    {
                        Debug.Log("3");

                        PlayerScore += 5;
                        ScoreText.text = PlayerScore.ToString();
                    }











                }
            }

        }




    }
    
}