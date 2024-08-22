
using System.Collections.Generic;
using UnityEngine;


//
// Enigma Machine 2024.07.28
//
// v2024.08.22
//


public class DrawSignal : MonoBehaviour
{
    //public List<Transform> lineConnectorPoints;

    public SignalController signalController;


    private void Start()
    {
        signalController.SetLineConnectorPoints(Settings.PATH); // lineConnectorPoints);    
    }

}

// end of script
