using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueWriter : MonoBehaviour
{
    [Header("Data Refers")]
    [SerializeField] DialogueData[] dialogueDatas;
    [Space]
    [Header("UI Refers")]
    [SerializeField] Text nameText;
    [SerializeField] Text warningText;
    [SerializeField] Text dialogueText;
    [Space]
    [Header("For Debug")]
    [SerializeField] DialogueData nowData;
    [SerializeField] int dialogueIndex;
    [SerializeField] int warningIndex;
    [SerializeField] int dataIndex;
    public int GetDataIndex() => dataIndex;

    static DialogueWriter writer;
    static public DialogueWriter Writer() => writer;

    private void Awake()
    {
        writer = this;
    }

    private void Write(string s, Text text)
    {
        text.text = s;
    }

    private void WriteNext(string[] s, ref int i, Text text)
    {
        i += 1;
        Write(s[i], text);
    }

    public void WriteNextDialogue()
    {
        WriteNext(nowData.dialogue, ref dialogueIndex, dialogueText);
    }

    public void WriteNextWarning()
    {
        WriteNext(nowData.warnnig, ref warningIndex, warningText);
    }

    public bool CheckIsOver()
    {
        int i = dataIndex + 1;
        return i >= dialogueDatas.Length;
    }

    public void LoadDataAndWriteFirst(int index)
    {
        if(index >= dialogueDatas.Length)
        {
            Debug.LogError("Index over");
            return;
        }

        dataIndex = index;
        nowData = dialogueDatas[index];
        dialogueIndex = 0;
        warningIndex = 0;

        Write(nowData.name, nameText);
        Write(nowData.dialogue[dialogueIndex], dialogueText);
        Write(nowData.warnnig[warningIndex], warningText);
    }
}
