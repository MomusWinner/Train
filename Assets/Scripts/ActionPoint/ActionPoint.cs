using System.Xml.Serialization;
using UnityEngine;

public class ActionPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Train")
        {
            other.gameObject.GetComponent<TrainMovement>().StopMoving();
        }
    }

}
