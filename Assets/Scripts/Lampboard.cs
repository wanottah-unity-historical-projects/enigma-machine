
using UnityEngine;


//
// Enigma Machine 2024.07.28
//
// v2024.08.15
//


public class Lampboard : MonoBehaviour
{

    // backward
    public string Output_Letter_(int signal)
    {
        string letter = Settings.ALPHABET[signal].ToString();

        return letter;
    }

}

// end of script
