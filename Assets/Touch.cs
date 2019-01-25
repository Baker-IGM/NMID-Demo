using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    [SerializeField]
    float width, height;

    [SerializeField]
    Vector3 pointerWorldPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            pointerWorldPos.x = (pointerWorldPos.x < 0) ? 0 : Input.mousePosition.x / Screen.width;
            pointerWorldPos.y = (pointerWorldPos.y < 0) ? 0 : Input.mousePosition.y / Screen.height;

            Debug.Log(Input.mousePosition);
        }
    }
}
