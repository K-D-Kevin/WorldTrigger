using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewEntry : MonoBehaviour
{
    [SerializeField]
    private Text EntryText;
    public string EntryString { get { return EntryText.text; } }

    public void SetEntryText(string text)
    {
        EntryText.text = text;
    }
}
