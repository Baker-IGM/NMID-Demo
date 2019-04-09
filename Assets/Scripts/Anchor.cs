using System.Collections.Generic;
using UnityEngine;

public class Anchor : MonoBehaviour
{
    [SerializeField]
    GameObject anchorPoint;

    [SerializeField]
    List<Chain> chains;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Chain c in chains)
        {
            AddNewChain(c);
        }
    }

    void AddNewChain(Chain c)
    {
        if (c != null)
        {
            c.SetAnchorPoint(anchorPoint.transform);
        }
    }
}
