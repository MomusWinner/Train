using UnityEngine;

[CreateAssetMenu(fileName = "New RailCar Data", menuName = "RailCar Data", order = 51)]
public class RailCarData : ScriptableObject
{
    [SerializeField] GameObject[] railcars;

    public GameObject[] Railcars { get { return railcars; } }


}
