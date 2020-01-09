using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{
    [TextArea(10,14)] [SerializeField] string StoryText;
    [SerializeField] State[] NextStates;

    public string getStateStory()
    {
        return StoryText;
    }

    public State[] getNextStates()
    {
        return NextStates;           
    }
}
