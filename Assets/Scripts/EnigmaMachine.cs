
using UnityEngine;

using TMPro;


//
// Enigma Machine 2024.07.28
//
// v2024.08.26
//


public class EnigmaMachine : MonoBehaviour
{

    // plugboard
    [Header("--- PLUGBOARD ---")]
    public string PLUGBOARD;
    public string plugboard_left;
    public string plugboard_right;


    private string ROTOR_I;
    private string ROTOR_II;
    private string ROTOR_III;
    private string ROTOR_IV;
    private string ROTOR_V;

    public int rotor_i;
    public int rotor_ii;
    public int rotor_iii;

    [Header("--- ROTORS ---")]
    public string[] ROTOR;
    public string[] rotor_left;
    public string[] rotor_right;
    public string[] rotor_notch;


    // reflector
    private string REFLECTOR_A;
    private string REFLECTOR_B;
    private string REFLECTOR_C;
    public int reflector_type;

    [Header("--- REFLECTOR ---")]
    public string[] REFLECTOR;
    public string[] reflector_left;
    public string[] reflector_right;


    // encoder
    public string inputLetter;
    public string outputLetter;
    public string cipher;
    public int signal;
    public bool canInput;


    // ui components
    [Header("--- UI ---")]
    public TMP_InputField input;
    public TMP_Text messageText;
    public TMP_Text cipherText;

    [Header("--- ENIGMA COMPONENTS ---")]
    public TMP_Text[] keyboard_Alphabet;

    public TMP_Text[] plugboard_LeftAlphabet;
    public TMP_Text[] plugboard_RightAlphabet;

    public TMP_Text[] rotorI_LeftAlphabet;
    public TMP_Text[] rotorI_RightAlphabet;

    public TMP_Text[] rotorII_LeftAlphabet;
    public TMP_Text[] rotorII_RightAlphabet;

    public TMP_Text[] rotorIII_LeftAlphabet;
    public TMP_Text[] rotorIII_RightAlphabet;

    public TMP_Text[] reflector_LeftAlphabet;
    public TMP_Text[] reflector_RightAlphabet;

    public TMP_Text[] lampboard_Alphabet;

    // ui signal connectors
    [Header("--- SIGNAL CONNECTORS ---")]
    public Transform[] signalPath;

    public Transform[] keyboard_SignalConnectorPoints;

    public Transform[] plugboard_LeftSignalConnectorPoints;
    public Transform[] plugboard_RightSignalConnectorPoints;

    public Transform[] rotorI_LeftSignalConnectorPoints;
    public Transform[] rotorI_RightSignalConnectorPoints;

    public Transform[] rotorII_LeftSignalConnectorPoints;
    public Transform[] rotorII_RightSignalConnectorPoints;

    public Transform[] rotorIII_LeftSignalConnectorPoints;
    public Transform[] rotorIII_RightSignalConnectorPoints;

    public Transform[] reflector_LeftSignalConnectorPoints;
    public Transform[] reflector_RightSignalConnectorPoints;

    public Transform[] lampboard_SignalConnectorPoints;



    private void Awake()
    {
        input.ActivateInputField();
    }


    private void Start()
    {
        Initialise();

        Enigma_Machine_Initialise();
    }


    private void Update()
    {
        Manual_Input_();
    }


    private void Manual_Input_()
    {
        if (canInput)
        {
            input.text = input.text.ToUpper();

            inputLetter = input.text;

            input.text = "";

            messageText.text += inputLetter;

            if (inputLetter == Settings.SPACE)
            {
                canInput = false;

                return;
            }

            Message_Output_();
        }
    }


    public void Input_Listener_()
    {
        canInput = true;
    }


    private void Message_Output_()
    {
        outputLetter = EnigmaController.instance.encoder.Encoder_Encipher_Message_(inputLetter);

        cipher = outputLetter;

        cipherText.text += cipher;

        canInput = false;
    }


    private void Read_Enciphered_File_()
    {

    }


    private void Write_Enciphered_File_()
    {

    }


    // general initialisation
    private void Initialise()
    {
        // rotors
        ROTOR = new string[Settings.NUMBER_OF_ROTORS];

        rotor_left = new string[Settings.NUMBER_OF_ROTORS];
        rotor_right = new string[Settings.NUMBER_OF_ROTORS];
        rotor_notch = new string[Settings.NUMBER_OF_ROTORS];

        rotor_i = 0;
        rotor_ii = 1;
        rotor_iii = 2;


        // reflectors
        REFLECTOR = new string[Settings.NUMBER_OF_REFLECTORS];

        reflector_left = new string[Settings.NUMBER_OF_REFLECTORS];
        reflector_right = new string[Settings.NUMBER_OF_REFLECTORS];


        // signal path
        signalPath = new Transform[Settings.NUMBER_OF_SIGNAL_CONNECTOR_POINTS];
    }


    // enigma machine
    private void Enigma_Machine_Initialise()
    {
        // set rotor wiring
        ROTOR[0] = Settings.ROTOR_I_WIRING + "," + Settings.ROTOR_I_TURNOVER_NOTCH_POSITION;
        ROTOR[1] = Settings.ROTOR_II_WIRING + "," + Settings.ROTOR_II_TURNOVER_NOTCH_POSITION;
        ROTOR[2] = Settings.ROTOR_III_WIRING + "," + Settings.ROTOR_III_TURNOVER_NOTCH_POSITION;
        ROTOR[3] = Settings.ROTOR_IV_WIRING + "," + Settings.ROTOR_IV_TURNOVER_NOTCH_POSITION;
        ROTOR[4] = Settings.ROTOR_V_WIRING + "," + Settings.ROTOR_V_TURNOVER_NOTCH_POSITION;

        ROTOR_I = ROTOR[0];
        ROTOR_II = ROTOR[1];
        ROTOR_III = ROTOR[2];
        ROTOR_IV = ROTOR[3];
        ROTOR_V = ROTOR[4];

        // set reflector wiring
        REFLECTOR[0] = Settings.REFLECTOR_A_WIRING + "," + Settings.REFLECTOR_TYPE_A;
        REFLECTOR[1] = Settings.REFLECTOR_B_WIRING + "," + Settings.REFLECTOR_TYPE_B;
        REFLECTOR[2] = Settings.REFLECTOR_C_WIRING + "," + Settings.REFLECTOR_TYPE_C;

        REFLECTOR_A = REFLECTOR[0];
        REFLECTOR_B = REFLECTOR[1];
        REFLECTOR_C = REFLECTOR[2];

        // initialise plugboard
        PLUGBOARD = "AR,GK,OX";


        // initialise encoder
        EnigmaController.instance.encoder.Encoder_Initialise_(REFLECTOR_B, ROTOR_I, ROTOR_II, ROTOR_III, PLUGBOARD);

        // set encoder ring positions
        EnigmaController.instance.encoder.Encoder_Set_Rotor_Ring_Positions_("A,A,A");

        // set encoder message cipher key
        EnigmaController.instance.encoder.Encoder_Set_Message_Cipher_Key_("A,A,A");


        // initialise user interface
        EnigmaController.instance.display.User_Interface_();
    }

}

// end of script
