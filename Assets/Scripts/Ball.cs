using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    Rigidbody rBody;

    [SerializeField]
    float maxForce;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        rBody.AddForce(Random.Range(0, maxForce), Random.Range(0, maxForce), Random.Range(0, maxForce), ForceMode.Impulse);
    }
}
