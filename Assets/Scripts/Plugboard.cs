
using UnityEngine;


//
// Enigma Machine 2024.07.28
//
// v2024.08.16
//


public class Plugboard : MonoBehaviour
{

    // transposed alphabet
    public string left;

    // standard alphabet
    public string right;


    public void Initialise_(string plugboardSetting)
    {
        EnigmaController.instance.enigmaMachine.plugboard_left = Settings.ALPHABET; //left = Settings.ALPHABET;

        EnigmaController.instance.enigmaMachine.plugboard_right = Settings.ALPHABET; //right = Settings.ALPHABET;

        string[] pairs = plugboardSetting.Split(',');

        foreach (string pair in pairs)
        {
            string A = pair[0].ToString();

            string B = pair[1].ToString();

            ///int posA = left.IndexOf(A);
            int posA = EnigmaController.instance.enigmaMachine.plugboard_left.IndexOf(A);

            ///int posB = left.IndexOf(B);
            int posB = EnigmaController.instance.enigmaMachine.plugboard_left.IndexOf(B);

            string transposedAlphabet;

            // get all the characters from the beginning of string 'left' (position 0) to position 'posA'
            // add character 'B'
            // then add the remaining characters from position 'posA + 1' to the end of string 'left'
            ///transposedAlphabet = left.Substring(0, posA) + B + left.Substring(posA + 1, left.Length - (posA + 1));
            transposedAlphabet = EnigmaController.instance.enigmaMachine.plugboard_left.Substring(0, posA) + B + EnigmaController.instance.enigmaMachine.plugboard_left.Substring(posA + 1, EnigmaController.instance.enigmaMachine.plugboard_left.Length - (posA + 1));

            ///left = transposedAlphabet;
            EnigmaController.instance.enigmaMachine.plugboard_left = transposedAlphabet;

            // get all the characters from the beginning of string 'left' (position 0) to position 'posB'
            // add character 'A'
            // then add the remaining characters from position 'posB + 1' to the end of string 'left'
            ///transposedAlphabet = left.Substring(0, posB) + A + left.Substring(posB + 1, left.Length - (posB + 1));
            transposedAlphabet = EnigmaController.instance.enigmaMachine.plugboard_left.Substring(0, posB) + A + EnigmaController.instance.enigmaMachine.plugboard_left.Substring(posB + 1, EnigmaController.instance.enigmaMachine.plugboard_left.Length - (posB + 1));

            ///left = transposedAlphabet;
            EnigmaController.instance.enigmaMachine.plugboard_left = transposedAlphabet;
        }
    }


    // forward
    public int Input_Signal_(int signal)
    {
        ///string letter = right[signal].ToString();
        string letter = EnigmaController.instance.enigmaMachine.plugboard_right[signal].ToString();

        ///signal = left.IndexOf(letter);
        signal = EnigmaController.instance.enigmaMachine.plugboard_left.IndexOf(letter);

        return signal;
    }


    // backward
    public int Output_Signal_(int signal)
    {
        ///string letter = left[signal].ToString();
        string letter = EnigmaController.instance.enigmaMachine.plugboard_left[signal].ToString();
        
        ///signal = right.IndexOf(letter);
        signal = EnigmaController.instance.enigmaMachine.plugboard_right.IndexOf(letter);

        return signal;
    }

}

// end of script
