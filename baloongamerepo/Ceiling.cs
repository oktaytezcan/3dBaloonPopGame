using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ceiling : MonoBehaviour
{
    //GameObject c;
    

    private void OnCollisionEnter(Collision collision)
    {
        //Balloon bceiling = c.GetComponent<Balloon>();
        //PlayerControls p = c.GetComponent<PlayerControls>();
        if (collision.gameObject)
        {
              Destroy(gameObject);
            Debug.Log("yokedildi");
        }
       // if (bceiling.Score < 0)
       // {

       //     Destroy(gameObject);

        //}

        //else if (bceiling.Score > 0)
        //{

          //  p.PlayerScore -= 1;
          //  p.ScoreText.text = p.ToString();
            //Destroy(gameObject);
        //}
       















    }

}

