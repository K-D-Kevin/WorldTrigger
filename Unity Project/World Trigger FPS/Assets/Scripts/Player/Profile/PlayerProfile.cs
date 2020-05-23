using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProfile : ScriptableObject
{
    /// <summary>
    /// A Scriptable Object to keep all profile related data
    /// </summary>

    #region Character Settings

    #region Triggers

    #region MainTriggers
    public Trigger DefaultMainTrigger_1;
    [HideInInspector]
    public Trigger SavedMainTrigger_1 = null;

    public Trigger DefaultMainTrigger_2;
    [HideInInspector]
    public Trigger SavedMainTrigger_2 = null;

    public Trigger DefaultMainTrigger_3;
    [HideInInspector]
    public Trigger SavedMainTrigger_3 = null;

    public Trigger DefaultMainTrigger_4;
    [HideInInspector]
    public Trigger SavedMainTrigger_4 = null;

    #endregion

    #region SubTriggers
    public Trigger DefaultSubTrigger_1;
    [HideInInspector]
    public Trigger SavedSubTrigger_1 = null;

    public Trigger DefaultSubTrigger_2;
    [HideInInspector]
    public Trigger SavedSubTrigger_2 = null;

    public Trigger DefaultSubTrigger_3;
    [HideInInspector]
    public Trigger SavedSubTrigger_3 = null;

    public Trigger DefaultSubTrigger_4;
    [HideInInspector]
    public Trigger SavedSubTrigger_4 = null;
    #endregion

    #endregion

    #region Appearance
    #endregion

    #endregion

    #region Controls

    #region Keybinds
    #endregion

    #region Mouse Settings
    #endregion

    #region Controller Settings
    #endregion

    #region Trigger Specific Settings
    #endregion

    #endregion

    #region Video
    #endregion

    #region Audio
    #endregion
}
