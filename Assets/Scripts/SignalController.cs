
using System.Collections.Generic;
using UnityEngine;


//
// Enigma Machine 2024.07.28
//
// v2024.08.22
//


public class SignalController : MonoBehaviour
{
    // reference to line renderer component
    [HideInInspector] public LineRenderer lineRenderer;

    // line renderer connector points
    //private Transform[] lineConnectorPoints;
    public List<Transform> lineConnectorPoints; // = new List<Transform>();


    // set reference to line renderer
    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }


    private void Update()
    {
        //Debug.Log("lineConnectorPoints = " + lineConnectorPoints.Count);
        //Debug.Log("lineConnectorPoints[0] = " + lineConnectorPoints[0].position);
        //for (int i = 0; i < lineConnectorPoints.Length; i++ )
        /*for (int i = 0; i < lineConnectorPoints.Count; i++)
        {
            Debug.Log("i = " + i);
            lineRenderer.SetPosition(i, lineConnectorPoints[i].position);
        }*/

        if (lineConnectorPoints.Count == 2)
        {
            //Debug.Log(lineConnectorPoints[1].position);
        }
    }


    // store points to draw line
    //public void SetLineConnectorPoints(Transform[] signalPathPoints)
    public void SetLineConnectorPoints(List<Transform> signalPathPoints)
    {
        //lineRenderer.positionCount = signalPathPoints.Length;
        lineRenderer.positionCount = signalPathPoints.Count;

        lineConnectorPoints = signalPathPoints;
    }

}

// end of script
