using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{

    public static int coinValue = 0;
    
    Text coin;
    // Start is called before the first frame update
    void Start()
    {
        coin = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        coin.text = "Coins : " + coinValue;

        if (coinValue >= 20)
        {
            coinValue = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
