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
        RailcarType[] randRailcar = new RailcarType[_wagonsCount];

        for (int i = 0; i < _wagonsCount; i++)
        {
            randRailcar[i] = (RailcarType)UnityEngine.Random.Range(0, Enum.GetNames(typeof(RailcarType)).Length);
        }

        _train.GetComponent<TrainMovement>().distancePath = GetComponent<PositionOnPathAtDistance>().GetDistance();
        _train.GetComponent<TrainInit>().railcarTypes = randRailcar;
        _train.GetComponent<TrainMovement>().path = _path;
        Instantiate(_train);


    }
}
