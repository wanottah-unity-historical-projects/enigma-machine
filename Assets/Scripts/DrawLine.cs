
using UnityEngine;


//
// Enigma Machine 2024.07.28
//
// v2024.08.14
//


public class DrawLine : MonoBehaviour
{
    [SerializeField] private Transform[] points;

    [SerializeField] private LineController lineController;

    private void Start()
    {
        lineController.SetLineConnectorPoints(points);
    }

}

// end of script
