
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
    private Transform[] lineConnectorPoints;


    // set reference to line renderer
    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }


    private void Update()
    {
        for (int i = 0; i < lineConnectorPoints.Length; i++ )
        {
            lineRenderer.SetPosition(i, lineConnectorPoints[i].position);
        }
    }


    // store points to draw line
    public void SetLineConnectorPoints(Transform[] signalPathPoints)
    {
        lineRenderer.positionCount = signalPathPoints.Length;

        lineConnectorPoints = signalPathPoints;
    }

}

// end of script
