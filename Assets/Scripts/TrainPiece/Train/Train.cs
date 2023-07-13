using System.Collections.Generic;
using UnityEngine;

public class Train : TrainPiece
{
    public List<GameObject> Railcars { get; set; }

    public Train(Transform backCoupling) : base(backCoupling)
    {
        Railcars = new List<GameObject>();
    }

    public GameObject[] GetRailcarGameObjects() 
    {    
        GameObject[] gameObjects = new GameObject[Railcars.Count];

        for (int i = 0; i < Railcars.Count; i++)
        {
            gameObjects[i] = Railcars[i];
        }

        return gameObjects;
    }
}
