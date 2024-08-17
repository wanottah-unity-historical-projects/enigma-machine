
using UnityEngine;


//
// Enigma Machine 2024.07.28
//
// v2024.08.16
//


public class Keyboard : MonoBehaviour
{

    // forward
    public int Input_Letter_(string letter)
    {
        int signal = Settings.ALPHABET.IndexOf(letter);
        
        return signal;
    }

}

// end of script
