using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
[RequireComponent (typeof(Collider))]
public class Hitable : MonoBehaviour
{
    Rigidbody rBody;
    Collider collider;

    [SerializeField]
    [Range(1, 50)]
    float maxForce;

    // Start is called before the first frame update
    private void Awake()
    {
        rBody = GetComponent<Rigidbody>();

        collider = GetComponent<Collider>();
    }

    private void OnMouseUpAsButton()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        collider.Raycast(ray, out hit, 100f);

        Vector3 hitDir = GetHitDirection() * maxForce;

        hitDir *= Input.GetAxis("Toggle");

        //  random foarce
        rBody.AddForce(hitDir, ForceMode.Impulse);
    }

    Vector3 GetRandomForce()
    {
        return new Vector3(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }

    Vector3 GetHitDirection()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        collider.Raycast(ray, out hit, 100f);

        return transform.position - hit.point;
    }
}
