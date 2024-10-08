﻿
using System.Collections.Generic;
using UnityEngine;


// Enigma Machine 2024.07.28
//
// v2024.08.26
//


public class Encoder : MonoBehaviour
{

    // encoder
    public void Encoder_Initialise_(string reflector, string rotor_1, string rotor_2, string rotor_3, string plugboard)
    {
        string[] reflector_setting = reflector.Split(',');

        string wiring = reflector_setting[0];

        bool type = int.TryParse(reflector_setting[1], out EnigmaController.instance.enigmaMachine.reflector_type);

        EnigmaController.instance.plugboard.Initialise_(plugboard);

        EnigmaController.instance.rotor.Rotor_Initialise_(EnigmaController.instance.enigmaMachine.rotor_i, rotor_1);
        EnigmaController.instance.rotor.Rotor_Initialise_(EnigmaController.instance.enigmaMachine.rotor_ii, rotor_2);
        EnigmaController.instance.rotor.Rotor_Initialise_(EnigmaController.instance.enigmaMachine.rotor_iii, rotor_3);

        EnigmaController.instance.reflector.Reflector_Initialise_(wiring, EnigmaController.instance.enigmaMachine.reflector_type);
    }


    public void Encoder_Set_Rotor_Ring_Positions_(string ringPositions)
    {
        string[] ringPosition = ringPositions.Split(',');

        int ring_I = Settings.ALPHABET.IndexOf(ringPosition[0]) + 1;

        EnigmaController.instance.rotor.Rotor_Set_Rotor_Ring_Position_(EnigmaController.instance.enigmaMachine.rotor_i, ring_I);


        int ring_II = Settings.ALPHABET.IndexOf(ringPosition[1]) + 1;

        EnigmaController.instance.rotor.Rotor_Set_Rotor_Ring_Position_(EnigmaController.instance.enigmaMachine.rotor_ii, ring_II);


        int ring_III = Settings.ALPHABET.IndexOf(ringPosition[2]) + 1;

        EnigmaController.instance.rotor.Rotor_Set_Rotor_Ring_Position_(EnigmaController.instance.enigmaMachine.rotor_iii, ring_III);
    }


    public void Encoder_Set_Message_Cipher_Key_(string messageKey)
    {
        string[] key = messageKey.Split(',');

        EnigmaController.instance.rotor.Rotor_Set_Cipher_Key_(EnigmaController.instance.enigmaMachine.rotor_i, key[0]);

        EnigmaController.instance.rotor.Rotor_Set_Cipher_Key_(EnigmaController.instance.enigmaMachine.rotor_ii, key[1]);

        EnigmaController.instance.rotor.Rotor_Set_Cipher_Key_(EnigmaController.instance.enigmaMachine.rotor_iii, key[2]);
    }


    public string Encoder_Encipher_Message_(string letter)
    {
        //canInput = false;

        // rotate rotors
        Encoder_Rotate_Rotors_();


        // initialise line position index
        //int positionIndex = -1;


        // keyboard input
        EnigmaController.instance.enigmaMachine.signal = EnigmaController.instance.keyboard.Input_Letter_(letter);


        /*positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.keyboard_SignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);

        positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.plugboard_RightSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);*/


        // plugboard input
        EnigmaController.instance.enigmaMachine.signal = EnigmaController.instance.plugboard.Input_Signal_(EnigmaController.instance.enigmaMachine.signal);


        /*positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;
        
        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.plugboard_LeftSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);

        positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.rotorIII_RightSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);*/


        // rotors input
        EnigmaController.instance.enigmaMachine.signal = EnigmaController.instance.rotor.Rotor_Input_Signal_(EnigmaController.instance.enigmaMachine.rotor_iii, EnigmaController.instance.enigmaMachine.signal);


        /*positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.rotorIII_LeftSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);


        positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.rotorII_RightSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);*/


        EnigmaController.instance.enigmaMachine.signal = EnigmaController.instance.rotor.Rotor_Input_Signal_(EnigmaController.instance.enigmaMachine.rotor_ii, EnigmaController.instance.enigmaMachine.signal);


        /*positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.rotorII_LeftSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);

        positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.rotorI_RightSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);*/


        EnigmaController.instance.enigmaMachine.signal = EnigmaController.instance.rotor.Rotor_Input_Signal_(EnigmaController.instance.enigmaMachine.rotor_i, EnigmaController.instance.enigmaMachine.signal);


        /*positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.rotorI_LeftSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);

        positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.reflector_RightSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);*/


        // reflector input / output
        EnigmaController.instance.enigmaMachine.signal = EnigmaController.instance.reflector.Reflector_Reflected_Signal_(EnigmaController.instance.enigmaMachine.reflector_type, EnigmaController.instance.enigmaMachine.signal);


        /*positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.reflector_LeftSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);

        positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.reflector_RightSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);

        positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.rotorI_LeftSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);*/


        // rotors output
        EnigmaController.instance.enigmaMachine.signal = EnigmaController.instance.rotor.Rotor_Output_Signal_(EnigmaController.instance.enigmaMachine.rotor_i, EnigmaController.instance.enigmaMachine.signal);


        /*positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.rotorI_RightSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);

        positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.rotorII_LeftSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);*/


        EnigmaController.instance.enigmaMachine.signal = EnigmaController.instance.rotor.Rotor_Output_Signal_(EnigmaController.instance.enigmaMachine.rotor_ii, EnigmaController.instance.enigmaMachine.signal);


        /*positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.rotorII_RightSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);

        positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.rotorIII_LeftSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);*/


        EnigmaController.instance.enigmaMachine.signal = EnigmaController.instance.rotor.Rotor_Output_Signal_(EnigmaController.instance.enigmaMachine.rotor_iii, EnigmaController.instance.enigmaMachine.signal);


        /*positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.rotorIII_RightSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);

        positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.plugboard_LeftSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);*/


        // plugboard output
        EnigmaController.instance.enigmaMachine.signal = EnigmaController.instance.plugboard.Output_Signal_(EnigmaController.instance.enigmaMachine.signal);


        /*positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.plugboard_RightSignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);*/


        // lampboard output
        EnigmaController.instance.enigmaMachine.outputLetter = EnigmaController.instance.lampboard.Output_Letter_(EnigmaController.instance.enigmaMachine.signal);

        /*positionIndex += 1;
        EnigmaController.instance.signalController.lineRenderer.positionCount = positionIndex + 1;

        EnigmaController.instance.signalController.lineRenderer.SetPosition
            (positionIndex, EnigmaController.instance.enigmaMachine.lampboard_SignalConnectorPoints[EnigmaController.instance.enigmaMachine.signal].position);*/


        // set the signal colour
        //Set_Signal_Colour();


        return EnigmaController.instance.enigmaMachine.outputLetter;
    }


    // checks to see if a rotor has reached its turnover notch position
    // and rotates the required rotors
    public void Encoder_Rotate_Rotors_()
    {
        string rotor_2 = EnigmaController.instance.enigmaMachine.rotor_left[EnigmaController.instance.enigmaMachine.rotor_ii];
        string rotor_3 = EnigmaController.instance.enigmaMachine.rotor_left[EnigmaController.instance.enigmaMachine.rotor_iii];

        /* if
        // the first character in string 'left' of Rotor_II is equal to Rotor_IIs turnover notch position
        // and
        // the first character in string 'left' of Rotor_III is equal to Rotor_IIIs turnover notch position*/
        if (rotor_2[0].ToString() == EnigmaController.instance.enigmaMachine.rotor_notch[EnigmaController.instance.enigmaMachine.rotor_ii] && rotor_3[0].ToString() == EnigmaController.instance.enigmaMachine.rotor_notch[EnigmaController.instance.enigmaMachine.rotor_iii])
        {
            // rotate all three rotors
            EnigmaController.instance.rotor.Rotor_Rotate_Rotor_(EnigmaController.instance.enigmaMachine.rotor_i);
            EnigmaController.instance.rotor.Rotor_Rotate_Rotor_(EnigmaController.instance.enigmaMachine.rotor_ii);
            EnigmaController.instance.rotor.Rotor_Rotate_Rotor_(EnigmaController.instance.enigmaMachine.rotor_iii);
        }

        // or
        // if the first character in string 'left' of Rotor_II is equal to Rotor_IIs turnover notch position
        else if (rotor_2[0].ToString() == EnigmaController.instance.enigmaMachine.rotor_notch[EnigmaController.instance.enigmaMachine.rotor_ii])
        {
            // rotate all three rotors
            EnigmaController.instance.rotor.Rotor_Rotate_Rotor_(EnigmaController.instance.enigmaMachine.rotor_i);
            EnigmaController.instance.rotor.Rotor_Rotate_Rotor_(EnigmaController.instance.enigmaMachine.rotor_ii);
            EnigmaController.instance.rotor.Rotor_Rotate_Rotor_(EnigmaController.instance.enigmaMachine.rotor_iii);
        }

        // else
        // if the first character in string 'left' of Rotor_III is equal to Rotor_IIIs turnover notch position
        else if (rotor_3[0].ToString() == EnigmaController.instance.enigmaMachine.rotor_notch[EnigmaController.instance.enigmaMachine.rotor_iii])
        {
            // rotate rotor_II and rotor_III
            EnigmaController.instance.rotor.Rotor_Rotate_Rotor_(EnigmaController.instance.enigmaMachine.rotor_ii);
            EnigmaController.instance.rotor.Rotor_Rotate_Rotor_(EnigmaController.instance.enigmaMachine.rotor_iii);
        }

        // otherwise, just rotate rotor_III
        else
        {
            EnigmaController.instance.rotor.Rotor_Rotate_Rotor_(EnigmaController.instance.enigmaMachine.rotor_iii);
        }
    }


    // set the signal line colour
    private void Set_Signal_Colour()
    {
        float alpha = 1.0f;

        Gradient gradient = new Gradient();

        gradient.SetKeys(
                            new GradientColorKey[] 
                            { 
                                new GradientColorKey(Settings.INPUT_SIGNAL_COLOUR, 0.0f), 
                                new GradientColorKey(Settings.REFLECTOR_SIGNAL_COLOUR, 0.5f), 
                                new GradientColorKey(Settings.OUTPUT_SIGNAL_COLOUR, 1.0f) 
                            },
            
                            new GradientAlphaKey[] 
                            { 
                                //new GradientAlphaKey(alpha, 0.0f), 
                                new GradientAlphaKey(alpha, 1.0f) 
                            }
                        );

        EnigmaController.instance.signalController.lineRenderer.colorGradient = gradient;
    }

}

// end of script
