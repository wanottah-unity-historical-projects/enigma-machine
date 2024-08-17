
using UnityEngine;


//
// Enigma Machine 2024.07.28
//
// v2024.08.17
//


public class DisplayInterface : MonoBehaviour
{

    public void User_Interface_()
    {
        for (int character = 0; character < Settings.ALPHABET.Length; character++)
        {
            EnigmaController.instance.enigmaMachine.keyboard_Alphabet[character].text = Settings.ALPHABET[character].ToString();
        }

        for (int character = 0; character < Settings.ALPHABET.Length; character++)
        {
            EnigmaController.instance.enigmaMachine.lampboard_Alphabet[character].text = Settings.ALPHABET[character].ToString();
        }

        for (int character = 0; character < EnigmaController.instance.enigmaMachine.plugboard_left.Length; character++)
        {
            EnigmaController.instance.enigmaMachine.plugboard_LeftAlphabet[character].text = EnigmaController.instance.enigmaMachine.plugboard_left[character].ToString();
        }

        for (int character = 0; character < EnigmaController.instance.enigmaMachine.plugboard_right.Length; character++)
        {
            EnigmaController.instance.enigmaMachine.plugboard_RightAlphabet[character].text = EnigmaController.instance.enigmaMachine.plugboard_right[character].ToString();
        }

        for (int character = 0; character < EnigmaController.instance.enigmaMachine.rotor_left[EnigmaController.instance.enigmaMachine.rotor_iii].Length; character++)
        {
            string left_letter = EnigmaController.instance.enigmaMachine.rotor_left[EnigmaController.instance.enigmaMachine.rotor_iii];

            EnigmaController.instance.enigmaMachine.rotorIII_LeftAlphabet[character].text = left_letter[character].ToString();
        }

        for (int character = 0; character < EnigmaController.instance.enigmaMachine.rotor_right[EnigmaController.instance.enigmaMachine.rotor_iii].Length; character++)
        {
            string right_letter = EnigmaController.instance.enigmaMachine.rotor_right[EnigmaController.instance.enigmaMachine.rotor_iii];

            EnigmaController.instance.enigmaMachine.rotorIII_RightAlphabet[character].text = right_letter[character].ToString();
        }

        for (int character = 0; character < EnigmaController.instance.enigmaMachine.rotor_left[EnigmaController.instance.enigmaMachine.rotor_ii].Length; character++)
        {
            string left_letter = EnigmaController.instance.enigmaMachine.rotor_left[EnigmaController.instance.enigmaMachine.rotor_ii];

            EnigmaController.instance.enigmaMachine.rotorII_LeftAlphabet[character].text = left_letter[character].ToString();
        }

        for (int character = 0; character < EnigmaController.instance.enigmaMachine.rotor_right[EnigmaController.instance.enigmaMachine.rotor_ii].Length; character++)
        {
            string right_letter = EnigmaController.instance.enigmaMachine.rotor_right[EnigmaController.instance.enigmaMachine.rotor_ii];

            EnigmaController.instance.enigmaMachine.rotorII_RightAlphabet[character].text = right_letter[character].ToString();
        }

        for (int character = 0; character < EnigmaController.instance.enigmaMachine.rotor_left[EnigmaController.instance.enigmaMachine.rotor_i].Length; character++)
        {
            string left_letter = EnigmaController.instance.enigmaMachine.rotor_left[EnigmaController.instance.enigmaMachine.rotor_i];

            EnigmaController.instance.enigmaMachine.rotorI_LeftAlphabet[character].text = left_letter[character].ToString();
        }

        for (int character = 0; character < EnigmaController.instance.enigmaMachine.rotor_right[EnigmaController.instance.enigmaMachine.rotor_i].Length; character++)
        {
            string right_letter = EnigmaController.instance.enigmaMachine.rotor_right[EnigmaController.instance.enigmaMachine.rotor_i];

            EnigmaController.instance.enigmaMachine.rotorI_RightAlphabet[character].text = right_letter[character].ToString();
        }

        for (int character = 0; character < EnigmaController.instance.enigmaMachine.reflector_left[EnigmaController.instance.enigmaMachine.reflector_type].Length; character++)
        {
            string left_letter = EnigmaController.instance.enigmaMachine.reflector_left[EnigmaController.instance.enigmaMachine.reflector_type];

            EnigmaController.instance.enigmaMachine.reflector_LeftAlphabet[character].text = left_letter[character].ToString();
        }

        for (int character = 0; character < EnigmaController.instance.enigmaMachine.reflector_right[EnigmaController.instance.enigmaMachine.reflector_type].Length; character++)
        {
            string right_letter = EnigmaController.instance.enigmaMachine.reflector_right[EnigmaController.instance.enigmaMachine.reflector_type];

            EnigmaController.instance.enigmaMachine.reflector_RightAlphabet[character].text = right_letter[character].ToString();
        }
    }

}

// end of script
