using System.Xml.Serialization;
using UnityEngine;

public class ActionPoint : MonoBehaviour
{
    GameObject train;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Train")
        {
            train = other.gameObject;
            other.gameObject.GetComponent<TrainMovement>().StopMoving();
        }
    }

    private void OnMouseDown()
    {
        train.GetComponent<TrainMovement>().StartMoving();
    }

}
