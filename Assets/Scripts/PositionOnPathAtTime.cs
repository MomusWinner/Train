using PathCreation;
using UnityEngine;


[ExecuteInEditMode]
public class PositionOnPathAtTime : MonoBehaviour
{
    [SerializeField] PathCreator _pathCreator;

    [Range(0f, 1f)]
    [SerializeField] float _t;


    private void Update()
    {
        transform.position = _pathCreator.path.GetPointAtTime(_t);
    }
}
