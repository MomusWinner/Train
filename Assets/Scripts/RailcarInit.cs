using UnityEngine;

public class RailcarInit : MonoBehaviour, ITrainPiece
{
    [SerializeField] Transform _frontCoupling;
    [SerializeField] Transform _backCoupling;

    public Transform FrontCoupling { get{return _frontCoupling;}  set { } }
    public Transform BackCoupling { get { return _backCoupling; } set { } }

    public Railcar railcar { get; set; }
    public float Distance { get; set; }

    public void Start()
    {
        railcar = new Railcar(FrontCoupling, BackCoupling);
    }


}
