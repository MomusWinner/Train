using PathCreation;
using System;
using UnityEngine;

[RequireComponent(typeof(PositionOnPathAtDistance))]
public class TrainSpawner : MonoBehaviour
{
    [SerializeField] GameObject _train;
    [SerializeField] int _wagonsCount;
    [SerializeField] PathCreator _path;

    void Start()
    {
        CreateTrain();
    }

    void CreateTrain()
    {
        RailcarType[] randRailcars = new RailcarType[_wagonsCount];

        for (int i = 0; i < _wagonsCount; i++)
        {
            randRailcars[i] = (RailcarType)UnityEngine.Random.Range(0, Enum.GetNames(typeof(RailcarType)).Length);
        }

        float distance = GetComponent<PositionOnPathAtDistance>().GetDistance();

        _train.GetComponent<TrainInit>().InitTrain(randRailcars, _path, distance);
        Instantiate(_train);


    }
}
