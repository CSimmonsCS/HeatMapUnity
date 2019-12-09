using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour
{
    [SerializeField] private HeatMapVisual heatMapVisual;
    private Grid grid;

    private void Start()
    {
        grid = new Grid(100, 100, 4f, Vector3.zero);

        heatMapVisual.SetGrid(grid);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = UtilsClass.GetMouseWorldPosition();
            //int value = grid.GetValue(position);
            //grid.SetValue(position, value + 5);
            grid.AddValue(position, 100, 2, 20);
        }
    }
}
