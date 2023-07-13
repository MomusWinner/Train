using UnityEngine;

public interface ITrainPiece
{
    public Transform FrontCoupling { get; set; }
    public Transform BackCoupling { get; set; }


    //The distance between this part of the train and the next
    public float Distance { get; set; }
}
