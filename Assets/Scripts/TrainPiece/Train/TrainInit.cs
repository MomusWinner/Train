using UnityEngine;

[RequireComponent(typeof(TrainMovement))]
public class TrainInit : MonoBehaviour, ITrainPiece
{
    [SerializeField] RailcarType[] _railcarTypes;
    [SerializeField] RailCarData _swordData;

    public float Distance { get { return train.Distans;} set { train.Distans = value; } }

    public Train train { get; set; }

    public Transform FrontCoupling { get { return null; } set { } }
    public Transform BackCoupling { get; set; }


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


}
