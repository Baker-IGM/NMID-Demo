using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent (typeof(Rigidbody))]
[RequireComponent(typeof(LineRenderer))]
public class Ball : MonoBehaviour
{
    Rigidbody rBody;

    [SerializeField]
    float maxForce;
    
    LineRenderer lineRenderer;

    [SerializeField]
    Transform anchorTransform;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();

        lineRenderer = GetComponent<LineRenderer>();

        lineRenderer.SetPosition(0, anchorTransform.position);
        lineRenderer.SetPosition(1, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(1, transform.position);
    }

    private void OnMouseUpAsButton()
    {
        rBody.AddForce(Random.Range(0, maxForce), Random.Range(0, maxForce), Random.Range(0, maxForce), ForceMode.Impulse);
    }
}
