
using UnityEngine;


//
// Enigma Machine 2024.07.28
//
// v2024.08.16
//


public class Rotor : MonoBehaviour
{

    // rotor
    public void Rotor_Initialise_(int rotor, string rotor_configuration) // string rotorWiring, string rotorTurnoverNotch)
    {
        string[] rotor_setting = rotor_configuration.Split(',');

        string rotorWiring = rotor_setting[0];

        string rotorTurnoverNotch = rotor_setting[1];

        EnigmaController.instance.enigmaMachine.rotor_left[rotor] = Settings.ALPHABET;

        EnigmaController.instance.enigmaMachine.rotor_right[rotor] = rotorWiring;

        EnigmaController.instance.enigmaMachine.rotor_notch[rotor] = rotorTurnoverNotch;
    }

    // forward
    public int Rotor_Input_Signal_(int rotor, int signal)
    {
        string left = EnigmaController.instance.enigmaMachine.rotor_left[rotor];

        string right = EnigmaController.instance.enigmaMachine.rotor_right[rotor];

        string letter = right[signal].ToString();

        signal = left.IndexOf(letter);

        return signal;
    }

    // backward
    public int Rotor_Output_Signal_(int rotor, int signal)
    {
        string left = EnigmaController.instance.enigmaMachine.rotor_left[rotor];

        string right = EnigmaController.instance.enigmaMachine.rotor_right[rotor];

        string letter = left[signal].ToString();

        signal = right.IndexOf(letter);

        return signal;
    }

    // rotate the rotors
    public void Rotor_Rotate_Rotor_(int rotor, int n = 1, bool rotatingRotorForward = true)
    {
        string rotatedAlphabet;

        for (int i = 0; i < n; i++)
        {
            // if we are rotating the rotor forward
            if (rotatingRotorForward)
            {
                // get all characters from the second position of string 'left' (position 1) to the end of string 'left' 
                // add the first character to the end of string 'left'
                //rotatedAlphabet = left.Substring(1, left.Length - 1) + left.Substring(0, 1);
                rotatedAlphabet = EnigmaController.instance.enigmaMachine.rotor_left[rotor].Substring(Settings.letterB, EnigmaController.instance.enigmaMachine.rotor_left[rotor].Length - 1) +
                                  EnigmaController.instance.enigmaMachine.rotor_left[rotor].Substring(Settings.letterA, 1);

                EnigmaController.instance.enigmaMachine.rotor_left[rotor] = rotatedAlphabet;

                // get all characters from the second position of string 'right' (position 1) to the end of string 'right' 
                // add the first character to the end of string 'right'
                rotatedAlphabet = EnigmaController.instance.enigmaMachine.rotor_right[rotor].Substring(Settings.letterB, EnigmaController.instance.enigmaMachine.rotor_right[rotor].Length - 1) +
                                  EnigmaController.instance.enigmaMachine.rotor_right[rotor].Substring(Settings.letterA, 1);

                EnigmaController.instance.enigmaMachine.rotor_right[rotor] = rotatedAlphabet;
            }

            else
            {
                // get all characters from the second position of string 'left' (position 1) to the end of string 'left' 
                // add the first character to the end of string 'left'
                rotatedAlphabet = EnigmaController.instance.enigmaMachine.rotor_left[rotor].Substring(Settings.letterZ, 1) +
                                  EnigmaController.instance.enigmaMachine.rotor_left[rotor].Substring(EnigmaController.instance.enigmaMachine.rotor_left[rotor].Length - 1, 1);

                EnigmaController.instance.enigmaMachine.rotor_left[rotor] = rotatedAlphabet;

                // get all characters from the second position of string 'right' (position 1) to the end of string 'right' 
                // add the first character to the end of string 'right'
                rotatedAlphabet = EnigmaController.instance.enigmaMachine.rotor_right[rotor].Substring(Settings.letterZ, 1) +
                                  EnigmaController.instance.enigmaMachine.rotor_right[rotor].Substring(EnigmaController.instance.enigmaMachine.rotor_right[rotor].Length - 1, 1);

                EnigmaController.instance.enigmaMachine.rotor_right[rotor] = rotatedAlphabet;
            }
        }
    }


    // set rotor ring position
    public void Rotor_Set_Rotor_Ring_Position_(int rotor, int n)
    {
        // rotate the rotor backwards
        bool rotatingRotorForward = false;

        Rotor_Rotate_Rotor_(rotor, n - 1, rotatingRotorForward);

        int n_notch = Settings.ALPHABET.IndexOf(EnigmaController.instance.enigmaMachine.rotor_notch[rotor]);

        EnigmaController.instance.enigmaMachine.rotor_notch[rotor] = Settings.ALPHABET[(n_notch - n) % Settings.NUMBER_OF_LETTERS].ToString();
    }


    // set message cipher key
    public void Rotor_Set_Cipher_Key_(int rotor, string letter)
    {
        // get the position of the letter to rotate the rotor to
        int n = Settings.ALPHABET.IndexOf(letter);

        Rotor_Rotate_Rotor_(rotor, n);
    }

}

// end of script
