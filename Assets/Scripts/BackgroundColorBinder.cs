using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColorBinder : MonoBehaviour
{
    void Start()
    {
        Camera.main.backgroundColor = Inventory.Instance.GetColor(Inventory.Colors.Tile1);
    }
}
