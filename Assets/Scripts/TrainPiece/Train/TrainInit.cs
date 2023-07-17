using PathCreation;
using UnityEngine;

[RequireComponent(typeof(TrainMovement))]
public class TrainInit : MonoBehaviour, ITrainPiece
{
    [SerializeField] RailCarData _swordData;
    [SerializeField] Transform _backCoupling;
    [SerializeField] RailcarType[] _railcarTypes;
    public Train train { get; set; }
    public float Distance { get { return train.Distans;} set { train.Distans = value; } }
    public Transform FrontCoupling { get { return null; } set { } }
    public Transform BackCoupling { get { return _backCoupling; } set { } }


    private void Awake()
    {
        train = new Train(BackCoupling);
        ÑreateRailcars();
    }

    private void ÑreateRailcars()
    {
        for (int i = 0; i < _railcarTypes.Length; i++)
        {
            GameObject railcar = Instantiate(_swordData.Railcars[(int)_railcarTypes[i]],
                transform.position, Quaternion.identity);

            train.Railcars.Add(railcar);
        }
    }

    public void InitTrain(RailcarType[] railcarTypes,PathCreator pathCreator, float distance)
    {
        _railcarTypes = railcarTypes;
        GetComponent<TrainMovement>().distancePath = distance;
        GetComponent<TrainMovement>().path = pathCreator;
    }
}
