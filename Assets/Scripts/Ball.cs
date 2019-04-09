using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
[RequireComponent (typeof(LineRenderer))]
[RequireComponent (typeof(SpringJoint))]
public class Ball : MonoBehaviour
{
    Rigidbody rBody;
    SpringJoint sJoint;
    LineRenderer lineRenderer;

    Transform anchorPoint;

    [SerializeField]
    [Range(1, 50)]
    float maxForce;

    // Start is called before the first frame update
    private void Awake()
    {
        rBody = GetComponent<Rigidbody>();

        sJoint = GetComponent<SpringJoint>();

        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, transform.position);
    }

    public void SetAnchorPoint(Transform anchor)
    {
        anchorPoint = anchor;

        sJoint.anchor = anchorPoint.position;

        lineRenderer.SetPosition(1, anchorPoint.position);
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, transform.position);
    }

    private void OnMouseUpAsButton()
    {
        rBody.AddForce(Random.Range(0, maxForce), Random.Range(0, maxForce), Random.Range(0, maxForce), ForceMode.Impulse);
    }
}
