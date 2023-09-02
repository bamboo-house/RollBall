using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainingItemText : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int remainingItemNumber = GameObject.FindGameObjectsWithTag("Item").Length;

        if(gameManager.isGameOver)
        {
            gameObject.GetComponent<Text>().text = "ゲームオーバー";
            return;
        }

        if(remainingItemNumber == 0)
        {
            gameObject.GetComponent<Text>().text = "クリア！";
        }
        else
        {
            gameObject.GetComponent<Text>().text = $"のこり：{remainingItemNumber}";
        }
    }
}
