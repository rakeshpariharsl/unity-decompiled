﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.AnimationTriggers
// Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2216A18B-AF52-44A5-85A0-A1CAA19C1090
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.UI.dll

using System;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
  /// <summary>
  ///   <para>Structure to store the state of an animation transition on a Selectable.</para>
  /// </summary>
  [Serializable]
  public class AnimationTriggers
  {
    [FormerlySerializedAs("normalTrigger")]
    [SerializeField]
    private string m_NormalTrigger = "Normal";
    [FormerlySerializedAs("highlightedTrigger")]
    [FormerlySerializedAs("m_SelectedTrigger")]
    [SerializeField]
    private string m_HighlightedTrigger = "Highlighted";
    [SerializeField]
    [FormerlySerializedAs("pressedTrigger")]
    private string m_PressedTrigger = "Pressed";
    [SerializeField]
    [FormerlySerializedAs("disabledTrigger")]
    private string m_DisabledTrigger = "Disabled";
    private const string kDefaultNormalAnimName = "Normal";
    private const string kDefaultSelectedAnimName = "Highlighted";
    private const string kDefaultPressedAnimName = "Pressed";
    private const string kDefaultDisabledAnimName = "Disabled";

    /// <summary>
    ///   <para>Trigger to send to animator when entering normal state.</para>
    /// </summary>
    public string normalTrigger
    {
      get
      {
        return this.m_NormalTrigger;
      }
      set
      {
        this.m_NormalTrigger = value;
      }
    }

    /// <summary>
    ///   <para>Trigger to send to animator when entering highlighted state.</para>
    /// </summary>
    public string highlightedTrigger
    {
      get
      {
        return this.m_HighlightedTrigger;
      }
      set
      {
        this.m_HighlightedTrigger = value;
      }
    }

    /// <summary>
    ///   <para>Trigger to send to animator when entering pressed state.</para>
    /// </summary>
    public string pressedTrigger
    {
      get
      {
        return this.m_PressedTrigger;
      }
      set
      {
        this.m_PressedTrigger = value;
      }
    }

    /// <summary>
    ///   <para>Trigger to send to animator when entering disabled state.</para>
    /// </summary>
    public string disabledTrigger
    {
      get
      {
        return this.m_DisabledTrigger;
      }
      set
      {
        this.m_DisabledTrigger = value;
      }
    }
  }
}
