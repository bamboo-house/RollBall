using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemainingItemText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int remainingItemNumber = GameObject.FindGameObjectsWithTag("Item").Length;

        gameObject.GetComponent<UnityEngine.UI.Text>().text = $"のこり：{remainingItemNumber}個";
    }
}
