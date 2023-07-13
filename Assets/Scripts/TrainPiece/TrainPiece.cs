using UnityEngine;

public class TrainPiece 
{
    public Transform BackCoupling { get; set; }
    public Transform FrontCoupling { get; set;  }

    //The distance between this part of the train and the next
    public float Distans { get; set; }

    public TrainPiece(Transform backCoupling)
    {
        BackCoupling = backCoupling;
    }

}
