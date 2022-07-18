using UnityEngine;

public class Inventory
{
    public enum Colors
    {
        Tile1, Tile2, Tile3, Tile4
    }

    private static Inventory _instance = null;

    public static Inventory Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Inventory();
            return _instance;
        }
    }

    public Color GetColor(Colors color)
    {
        return Color.cyan;
    }
}