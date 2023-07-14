using PathCreation;
using System;
using UnityEngine;

public class TrainSpawner : MonoBehaviour
{
    [SerializeField] GameObject _train;
    [SerializeField] int _wagonsCount;
    [SerializeField] PathCreator _path;

    void Start()
    {
        CreateTrain();
    }

    void Update()
    {
        
    }



    void CreateTrain()
    {
        RailcarType[] randRaicar = new RailcarType[_wagonsCount];

        for (int i = 0; i < _wagonsCount; i++)
        {
            randRaicar[i] = (RailcarType)UnityEngine.Random.Range(0, Enum.GetNames(typeof(RailcarType)).Length);
        }
        _train.GetComponent<TrainInit>().railcarTypes = randRaicar;
        _train.GetComponent<TrainInit>().;
        Instantiate(_train);


    }
}
