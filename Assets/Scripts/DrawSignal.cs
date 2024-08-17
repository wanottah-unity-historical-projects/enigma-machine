
using UnityEngine;


//
// Enigma Machine 2024.07.28
//
// v2024.08.17
//


public class DrawSignal : MonoBehaviour
{
    //public Transform[] signalPath = new Transform[Settings.NUMBER_OF_SIGNAL_CONNECTOR_POINTS];

    [SerializeField] private LineController lineController;

    private void Start()
    {
        lineController.SetLineConnectorPoints(EnigmaController.instance.enigmaMachine.signalPath);
    }

}

// end of script
