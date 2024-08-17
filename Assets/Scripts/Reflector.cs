
using UnityEngine;


//
// Enigma Machine 2024.07.28
//
// v2024.08.16
//


public class Reflector : MonoBehaviour
{

    public void Reflector_Initialise_(string reflectorWiring, int reflector)
    {
        EnigmaController.instance.enigmaMachine.reflector_left[reflector] = Settings.ALPHABET;

        EnigmaController.instance.enigmaMachine.reflector_right[reflector] = reflectorWiring;
    }


    public int Reflector_Reflected_Signal_(int reflector, int signal)
    {
        string left = EnigmaController.instance.enigmaMachine.reflector_left[reflector];

        string right = EnigmaController.instance.enigmaMachine.reflector_right[reflector];

        string letter = right[signal].ToString();

        signal = left.IndexOf(letter);

        return signal;
    }

}

// end of script
