using UnityEngine;

public enum ContainerType
{
    Refrigerator,
    Standard
}

public class Container : MonoBehaviour
{
    private Color _color;
    private int _size;
    private ContainerType _type;
}
