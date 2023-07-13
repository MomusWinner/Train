using UnityEngine;

public class RailcarInit : MonoBehaviour , ITrainPiece
{
    public Transform FrontCoupling { get; set; }
    public Transform BackCoupling { get; set; }

    public Railcar railcar { get; set; }
    public float Distance { get; set; }

    public void Start()
    {
        railcar = new Railcar(FrontCoupling, BackCoupling);
    }


}
