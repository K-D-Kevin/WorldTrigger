using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GUIExtensions;

[CreateAssetMenu]
public class SceneLoadTipsScriptableObject : ScriptableObject
{
    public int NumberOfTipsToRemember = 5;
    /*[Table] */public LoadingTip[] LoadingTips;

    [HideInInspector]
    public Queue<LoadingTip> LoadingTipQueue = new Queue<LoadingTip>();
    [HideInInspector]
    public Queue<LoadingTip> OldTipQueue = new Queue<LoadingTip>();

    public LoadingTip GetRandomTip()
    {
        if (LoadingTipQueue.Count == 0)
        {
            while (LoadingTipQueue.Count < NumberOfTipsToRemember + 1)
            {
                int RandomInt = UnityEngine.Random.Range(0, LoadingTips.Length);
                LoadingTip PotentialTip = LoadingTips[RandomInt];
                if (!OldTipQueue.Contains(PotentialTip))
                {
                    LoadingTipQueue.Enqueue(PotentialTip);
                }
            }
            OldTipQueue.Clear();
            LoadingTip ReturnTip = LoadingTipQueue.Dequeue();
            OldTipQueue.Enqueue(ReturnTip);
            return ReturnTip;
        }
        else
        {
            LoadingTip ReturnTip = LoadingTipQueue.Dequeue();
            OldTipQueue.Enqueue(ReturnTip);
            return ReturnTip;
        }
    }
}

[Serializable]
public class LoadingTip
{
    public string Tip;
    public Sprite TipImage;
}

