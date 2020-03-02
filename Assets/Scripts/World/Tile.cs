using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField]
    private Vector2 coordinates;
    private int type;
    private string tileName;

    public void SetValues(float xCoord, float yCoord)
    {
        coordinates.x = xCoord;
        coordinates.y = yCoord;

        type = 0;
        tileName = "Basic";
    }
}
