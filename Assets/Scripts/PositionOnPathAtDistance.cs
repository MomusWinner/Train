using PathCreation;
using UnityEngine;
using UnityEngineInternal;

[ExecuteInEditMode]
public class PositionOnPathAtDistance : MonoBehaviour
{
    [SerializeField] PathCreator _pathCreator;

    [SerializeField] float _dictance;


    private void Update()
    {
        transform.position = _pathCreator.path.GetPointAtDistance(_dictance);
    }

    public float GetDistance()
    {
        return _dictance;
    }
}
