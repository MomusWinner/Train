using UnityEngine;

public class TestCoupling : MonoBehaviour
{
    Transform _a;
    [SerializeField] Transform _couplingA;

    [SerializeField] Transform _b;
    [SerializeField] Transform _couplingB;



    void Start()
    {
        _a = GetComponent<Transform>();

        float distansAC = Vector3.Distance(_a.position, _couplingA.position);
        float distansCB = Vector3.Distance(_b.position, _couplingB.position);
        float distans = distansAC + distansCB;

        _b.transform.position = _a.position + Vector3.forward * distans;

    }
}
