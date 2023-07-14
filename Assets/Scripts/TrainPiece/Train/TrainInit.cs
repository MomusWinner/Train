using UnityEngine;

[RequireComponent(typeof(TrainMovement))]
public class TrainInit : MonoBehaviour, ITrainPiece
{
    [SerializeField] RailCarData _swordData;
    [SerializeField] Transform _backCoupling;

    public Train train { get; set; }
    public RailcarType[] railcarTypes;
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
        for (int i = 0; i < railcarTypes.Length; i++)
        {
            GameObject railcar = Instantiate(_swordData.Railcars[(int)railcarTypes[i]],
                transform.position, Quaternion.identity);

            train.Railcars.Add(railcar);
        }
    }


}
