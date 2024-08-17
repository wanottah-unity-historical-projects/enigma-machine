
using UnityEngine;


//
// Enigma Machine 2024.07.28
//
// v2024.08.16
//


public class EnigmaController : MonoBehaviour
{
    public static EnigmaController instance { get; private set; }



    public EnigmaMachine enigmaMachine { get; private set; }

    public DisplayInterface display { get; private set; }

    public Keyboard keyboard { get; private set; }

    public Plugboard plugboard { get; private set; }

    public Rotor rotor { get; private set; }

    public Reflector reflector { get; private set; }

    public Lampboard lampboard { get; private set; }

    public Encoder encoder { get; private set; }



    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);

            return;
        }

        instance = this;


        enigmaMachine = GetComponentInChildren<EnigmaMachine>();

        display = GetComponentInChildren<DisplayInterface>();

        keyboard = GetComponentInChildren<Keyboard>();

        plugboard = GetComponentInChildren<Plugboard>();

        rotor = GetComponentInChildren<Rotor>();

        reflector = GetComponentInChildren<Reflector>();

        lampboard = GetComponentInChildren<Lampboard>();

        encoder = GetComponentInChildren<Encoder>();
    }

}

// end of script
