using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    private List<Vector3> positions = new List<Vector3>();
    private LineRenderer _lineRenderer;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            positions.Add(worldPosition);

            // Преобразование списка в массив перед передачей в SetPositions
            Vector3[] positionsArray = positions.ToArray();

            _lineRenderer.positionCount = positionsArray.Length;
            _lineRenderer.SetPositions(positionsArray);
        }
        else
        {
            positions.Clear();
            Vector3[] positionsArray = positions.ToArray();
            _lineRenderer.SetPositions(positionsArray);
        }
        
    }
}
