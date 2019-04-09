using System.Collections.Generic;
using UnityEngine;

public class Anchor : MonoBehaviour
{
    [SerializeField]
    GameObject anchorPoint;

    [SerializeField]
    List<Ball> balls;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Ball b in balls)
        {
            AddNewBall(b);
        }
    }

    void AddNewBall(Ball b)
    {
        b.SetAnchorPoint(anchorPoint.transform);
    }
}
