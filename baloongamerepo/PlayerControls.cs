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

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//kameradan ekrana ray tipi döndürdük.
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))//sonsuza ýþýn  göndermemek için 100 tanýmladýk fonksiyonun deðerleri hit deðiþkeninde tutuluyor.
            {
                Debug.Log(hit.transform.gameObject.name);

                Balloon clickedBalloon = hit.transform.gameObject.GetComponent<Balloon>();//balloon sýnýfýnýn compenentlerini nesnemize atadýk.

                if (clickedBalloon != null)
                {
                    BalloonManager.ShootBalloon(clickedBalloon);//nesnemizi balloonmanagerdaki shootbaloon fonksiyonuna atayýp destroyladýk.

                    if (clickedBalloon.BalloonColor.Equals(BalloonManager.AvailableColors[0]))
                    {//listemizin indekslerine ulaþýp renge göre puan ekledik.
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