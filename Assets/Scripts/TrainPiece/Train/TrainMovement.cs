using PathCreation;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    [SerializeField] float _groundDistance;
    [SerializeField] PathCreator _pathCreator;
    [SerializeField] EndOfPathInstruction _end;
    [SerializeField] float _speed;

    List<float> _distances;

    GameObject[] _railcars;
    float _time;

    private void Start()
    {
        _distances = new List<float>();

        _railcars = gameObject.GetComponent<TrainInit>().train.GetRailcarGameObjects();

        CountDistancesBetweenRailcars();
        ArrangeRailcar();

    }

    public void Update()
    {
        Drive();
    }

    private void Drive()
    {
        _time += Time.deltaTime * _speed;

        ArrangeRailcar();

    }

    private void PursuePath(GameObject gObgect,float time, EndOfPathInstruction end, float groundDistance)
    {
        gObgect.transform.position = _pathCreator.path.GetPointAtDistance(time, end) + Vector3.up * groundDistance;
        gObgect.transform.rotation = _pathCreator.path.GetRotationAtDistance(time, end);
    }
    
    private void CountDistancesBetweenRailcars()
    {
        if (_railcars == null)
            return;

        CountDistancesBetweenRailcar<TrainInit, RailcarInit>(gameObject, _railcars[0]);

        for (int i = 1; i < _railcars.Length; i++)
        {
            CountDistancesBetweenRailcar<RailcarInit, RailcarInit>(_railcars[i - 1], _railcars[i]);
        }
    }

    public void CountDistancesBetweenRailcar<T1, T2>(GameObject obj1, GameObject obj2) where T1 : ITrainPiece where T2 : ITrainPiece
    {
        float distanceAC = Vector3.Distance(obj1.transform.position,
            obj1.GetComponent<T1>().BackCoupling.position);

        float distanceCB = Vector3.Distance(obj2.transform.position,
            obj2.GetComponent<T2>().FrontCoupling.position);

        float distance = distanceAC + distanceCB;
 
        _distances.Add(distance);
    }

    private void ArrangeRailcar()
    {
        PursuePath(gameObject, _time, _end, _groundDistance);

        if (_railcars == null)
            return;

        float railcarTime = _time;

        for (int i = 0; i < _railcars.Length; i++)
        {
            railcarTime -= _distances[i];
            PursuePath(_railcars[i], railcarTime, _end, _groundDistance);
        }
    }


}
