using PathCreation;
using UnityEngine;


[ExecuteInEditMode]
public class ActionPointPosition : MonoBehaviour
{
    [SerializeField] PathCreator _pathCreator;
    [Range(0f, 1f)]
    [SerializeField] float _t;




    private void Update()
    {

        Debug.Log(1);
        transform.position = _pathCreator.path.GetPointAtTime(_t);
        
    }
}
