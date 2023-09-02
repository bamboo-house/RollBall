using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPlayerPosition = playerTransform.position;

        Vector3 higherPlayerPosition = new Vector3(currentPlayerPosition.x, currentPlayerPosition.y + 10, currentPlayerPosition.z);

        gameObject.GetComponent<Transform>().position = higherPlayerPosition;
    }
}
