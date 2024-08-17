
using UnityEngine;


//
// Enigma Machine 2024.07.28
//
// v2024.08.14
//


public class LineController : MonoBehaviour
{
    // reference to line renderer component
    private LineRenderer lineRenderer;

    // line renderer connector points
    private Transform[] points;


    // set reference to line renderer
    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }


    private void Update()
    {
        for (int i = 0; i < points.Length; i++ )
        {
            lineRenderer.SetPosition(i, points[i].position);
        }
    }


    // store points to draw line
    public void SetLineConnectorPoints(Transform[] points)
    {
        lineRenderer.positionCount = points.Length;

        this.points = points;
    }

}

// end of script
