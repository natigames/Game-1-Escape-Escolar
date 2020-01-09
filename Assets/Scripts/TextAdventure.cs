using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAdventure : MonoBehaviour
{

    [SerializeField] Text TextComponent;
    [SerializeField] State StartingState;

    State State;


    // Start is called before the first frame update
    void Start()
    {
        State = StartingState;
        TextComponent.text = State.getStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {

        var nextStates = State.getNextStates();

        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 +index))
            {
                State = nextStates[index];
            }
        }

        TextComponent.text = State.getStateStory();
    }
}
