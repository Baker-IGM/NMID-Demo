using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
[RequireComponent (typeof(LineRenderer))]
[RequireComponent (typeof(SpringJoint))]
[RequireComponent (typeof(Collider))]
public class Ball : MonoBehaviour
{
    Rigidbody rBody;
    SpringJoint sJoint;
    LineRenderer lineRenderer;
    [SerializeField]
    Collider collider;

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

        collider = GetComponent<Collider>();
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
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        collider.Raycast(ray, out hit, 100f);

        Vector3 hitDir = transform.position - hit.point;
        hitDir *= maxForce;

        //  random foarce
        rBody.AddForce(hitDir, ForceMode.Impulse);
    }

    Vector3 GetRandomForce()
    {
        return new Vector3(Random.Range(0, maxForce), Random.Range(0, maxForce), Random.Range(0, maxForce));
    }

    Vector3 GetHitDirection()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        collider.Raycast(ray, out hit, 100f);
        Debug.Log(hit.point);

        return transform.position - hit.point;
    }
}
