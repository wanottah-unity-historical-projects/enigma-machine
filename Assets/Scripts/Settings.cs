﻿
using UnityEngine;


//
// Enigma Machine 2024.07.28
//
// v2024.08.17
//


public class Settings : MonoBehaviour
{
    // number of enigma components
    public const int ENIGMA_COMPONENTS = 7; // 6
    // COMPONENT_NAMES = ["Reflector", "Left", "Middle", "Right", "Plugboard", "Lampboard", "Keyboard"];


    // standard alphabet
    public const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public const int NUMBER_OF_LETTERS = 26;
    

    // index position for letters
    public const int letterA = 0;
    public const int letterB = 1;
    public const int letterZ = 25;


    // rotors
    public const int NUMBER_OF_ROTORS = 5;

    // rotor wiring configurations
    public const string ROTOR_I_WIRING = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
    public const string ROTOR_II_WIRING = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
    public const string ROTOR_III_WIRING = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
    public const string ROTOR_IV_WIRING = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
    public const string ROTOR_V_WIRING = "VZBRGITYUPSDNHLXAWMJQOFECK";

    // rotor turnover notch positions
    public const string ROTOR_I_TURNOVER_NOTCH_POSITION = "Q";
    public const string ROTOR_II_TURNOVER_NOTCH_POSITION = "E";
    public const string ROTOR_III_TURNOVER_NOTCH_POSITION = "V";
    public const string ROTOR_IV_TURNOVER_NOTCH_POSITION = "J";
    public const string ROTOR_V_TURNOVER_NOTCH_POSITION = "Z";


    // reflectors wiring configurations
    public const int NUMBER_OF_REFLECTORS = 3;

    // reflector wiring configurations
    public const string REFLECTOR_A_WIRING = "EJMZALYXVBWFCRQUONTSPIKHGD";
    public const string REFLECTOR_B_WIRING = "YRUHQSLDPXNGOKMIEBFZCWVJAT";
    public const string REFLECTOR_C_WIRING = "FVPJIAOYEDRZXWGCTKUQSBNMHL";

    // reflector type
    public const string REFLECTOR_TYPE_A = "A";
    public const string REFLECTOR_TYPE_B = "B";
    public const string REFLECTOR_TYPE_C = "C";


    // pygame
    // SCREEN_WIDTH = 1600;
    // SCREEN_HEIGHT = 900;
    // TEXT_MARGIN = {"top": 200, "bottom": 100, "left": 100, "right": 100};
    // COMPONENT_SPACING = 100;


    // signal display
    public const string INPUT = "";
    public const string OUTPUT = "";
    public const string SPACE = " ";
    // PATH = [];
    public const int CIPHER_CHARACTERS = 5;  // 4;
    public const string CIPHER = "";


    // write file
    public const string INTERCEPT_OUTPUT = "";
    // public const string NEWLINE = '\n';
    public const int INTERCEPT_COLUMNS = 4;
    public const int INTERCEPT_SPACES = 3;
    public const int INTERCEPT_LINE_LENGTH = CIPHER_CHARACTERS * INTERCEPT_COLUMNS + INTERCEPT_SPACES;


    // read file
    public const string INTERCEPT_INPUT = "";
    // public const EMPTY_PATH = [];

}

// end of script
