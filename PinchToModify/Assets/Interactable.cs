using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    InteractableTextBehaviour currentInteractableText;


    // Update is called once per frame
    void Update()
    {
        // DetectMouseClick();
        DetectHandGestureClick();
    }


    void DetectHandGestureClick()
    {

        //All the information of the hand
        HandInfo detectedHand = ManomotionManager.Instance.Hand_infos[0].hand_info;

        //The click happens when I perform the Click Gesture : Open Pinch -> Closed Pinch -> Open Pinch 
        if (detectedHand.gesture_info.mano_gesture_trigger == ManoGestureTrigger.CLICK)
        {
            //Logic that should happen when I click
            if (currentInteractableText)
            {
                currentInteractableText.InteractWithText();
            }
        }

    }


    void DetectMouseClick()
    {

        //The click happens when I release the left mouse buttons
        if (Input.GetMouseButtonUp(0))
        {

            //Logic that should happen when I click.

            if (currentInteractableText)
            {
                currentInteractableText.InteractWithText();

            }

        }
    }

    //TODO Code Challenge: Use a smart & creative way to decide which object should be the currentInteractableCube.
    //TODO email abraham@manomotion.com with your ideas and code snipets :) 
    void FindWhichCubeShouldBetheCurrentInteractable()
    {

    }
}
