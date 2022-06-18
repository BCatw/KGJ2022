using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Dialogue_", menuName = "ScriptableObj/Dialogue")]
public class DialogueData : ScriptableObject
{
    public string name;
    [TextArea] public string[] warnnig;
    [TextArea] public string[] dialogue;
}