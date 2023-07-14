using UnityEngine;

public enum RailcarType
{
    platform,
    tank
}


public class Railcar : TrainPiece
{
    public float MaximumWeight { get; set; }
    public GameObject railcarObject { get; set; }


    public Railcar(Transform frontCoupling, Transform backCoupling) : base(backCoupling) 
    {
        FrontCoupling = frontCoupling;
        BackCoupling = backCoupling;
    }

}
