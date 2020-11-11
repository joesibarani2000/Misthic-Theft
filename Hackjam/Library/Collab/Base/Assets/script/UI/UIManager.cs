using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text time;
    public Text coin;
    public Text coinwin, coinlose;

  

    public float theTime;

    // Start is called before the first frame update
    void Start()
    {
        coin.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        DecreaseTime();
        UpdateCoin();
    }

    void UpdateCoin()
    {
        coin.text = GameData.instance.getPlayerGold() + "";        
    }

    public void FinalCoin()
    {
        if (!leveldone.asd)
        {
            coinwin.text = GameData.instance.getPlayerGold() + "";
        }
        if (!playerhp.dead)
        {
            //playerInventory.coin /= 2;
            //coinlose.text = playerInventory.coin + "";
        }
    }

    void DecreaseTime()
    {
        if (theTime >= 0.5)
        {
            theTime -= Time.deltaTime * 1;
        }
        string second = Mathf.Floor((theTime % 60)).ToString("00");
        string minute = Mathf.Floor((theTime / 60) % 60).ToString("00");
        time.text = minute + " : " + second;

        if (theTime <= 0.5)
        {
            leveldone.stop = false;
            Time.timeScale = 0;
            FindObjectOfType<GameManager>().gameEnd();
        }
    }
}
