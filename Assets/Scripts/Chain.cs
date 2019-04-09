using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
[RequireComponent(typeof(SpringJoint))]
public class Chain : MonoBehaviour
{
    SpringJoint sJoint;
    LineRenderer lineRenderer;

    Transform anchorPoint;

    // Start is called before the first frame update
    void Awake()
    {
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
}
