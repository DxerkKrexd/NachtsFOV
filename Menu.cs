// Decompiled with JetBrains decompiler
// Type: NachtsFOV.Menu
// Assembly: NachtsFOV, Version=0.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8BE73195-5F92-4FC0-A913-783015E7CF73
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins\Nachts Mods (my mods)\NachtsFOV.dll

using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

#nullable disable
namespace NachtsFOV;

public class Menu : MonoBehaviour
{
  public const float ThumbSize = 20f;
  private Rect rect = new Rect(250f, 250f, 380f, 0.0f);
  private bool open;
  private bool built;

  private void Update()
  {
    Keyboard current = Keyboard.current;
    if (current == null || !((ButtonControl) current.fKey).wasPressedThisFrame)
      return;
    this.open = !this.open;
  }

  private void OnGUI()
  {
    if (!this.built)
    {
      Style.Build();
      this.built = true;
    }
    if (!this.open)
      return;
    // ISSUE: method pointer
    this.rect = GUILayout.Window(5120331, this.rect, new GUI.WindowFunction((object) this, __methodptr(Draw)), "NACHTS FOV", Style.Window, Array.Empty<GUILayoutOption>());
  }

  private void Draw(int id)
  {
    GUILayout.Space(4f);
    GUILayout.Label("Field of view", Style.Heading, Array.Empty<GUILayoutOption>());
    GUILayout.Label("See more of the map without turning your head.", Style.Hint, Array.Empty<GUILayoutOption>());
    GUILayout.Space(8f);
    Menu.Divider();
    GUILayout.Space(10f);
    GUILayout.BeginVertical(Style.Card, Array.Empty<GUILayoutOption>());
    GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
    GUILayout.Label("Vertical FOV", Style.Hint, new GUILayoutOption[1]
    {
      GUILayout.ExpandWidth(true)
    });
    GUILayout.Label(Settings.Fov.ToString("0") + "°", Style.Value, new GUILayoutOption[1]
    {
      GUILayout.Width(80f)
    });
    GUILayout.EndHorizontal();
    GUILayout.Space(4f);
    Settings.Fov = Menu.Slider(Settings.Fov, 40f, 170f);
    GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
    GUILayout.Label("40°", Style.Small, Array.Empty<GUILayoutOption>());
    GUILayout.FlexibleSpace();
    GUILayout.Label("170°", Style.Small, Array.Empty<GUILayoutOption>());
    GUILayout.EndHorizontal();
    GUILayout.EndVertical();
    GUILayout.Space(12f);
    GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
    Settings.Enabled = Menu.Switch("Enabled", Settings.Enabled);
    GUILayout.FlexibleSpace();
    GUILayout.Label(!Settings.Enabled ? "off" : (Fov.Working ? "active" : "waiting for headset"), Fov.Working ? Style.StatusOn : Style.Status, new GUILayoutOption[1]
    {
      GUILayout.MaxWidth(160f)
    });
    GUILayout.EndHorizontal();
    GUILayout.Space(12f);
    GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
    if (GUILayout.Button("Reset to 140°", Style.Button, new GUILayoutOption[1]
    {
      GUILayout.Height(34f)
    }))
      Settings.Fov = 140f;
    GUILayout.Space(8f);
    if (GUILayout.Button("Close", Style.Ghost, new GUILayoutOption[1]
    {
      GUILayout.Height(34f)
    }))
      this.open = false;
    GUILayout.EndHorizontal();
    GUILayout.Space(6f);
    GUILayout.Label("F toggles this window", Style.Small, Array.Empty<GUILayoutOption>());
    GUI.DragWindow(new Rect(0.0f, 0.0f, ((Rect) ref this.rect).width, 30f));
  }

  private static void Divider()
  {
    Rect rect = GUILayoutUtility.GetRect(1f, 2f, new GUILayoutOption[1]
    {
      GUILayout.ExpandWidth(true)
    });
    if (Event.current.type != 7)
      return;
    GUI.DrawTexture(rect, (Texture) Style.Bar);
  }

  private static float Slider(float value, float min, float max)
  {
    Rect rect1 = GUILayoutUtility.GetRect(10f, 24f, new GUILayoutOption[1]
    {
      GUILayout.ExpandWidth(true)
    });
    if (Event.current.type == 7)
    {
      float num1 = Mathf.InverseLerp(min, max, value);
      Rect rect2;
      // ISSUE: explicit constructor call
      ((Rect) ref rect2).\u002Ector(((Rect) ref rect1).x, ((Rect) ref rect1).y + (float) (((double) ((Rect) ref rect1).height - 12.0) * 0.5), ((Rect) ref rect1).width, 12f);
      Style.Track.Draw(rect2, GUIContent.none, false, false, false, false);
      float num2 = (float) (10.0 + (double) num1 * ((double) ((Rect) ref rect1).width - 20.0));
      Style.Fill.Draw(new Rect(((Rect) ref rect2).x, ((Rect) ref rect2).y, Mathf.Max(num2, 12f), ((Rect) ref rect2).height), GUIContent.none, false, false, false, false);
    }
    return GUI.HorizontalSlider(rect1, value, min, max, Style.SliderBlank, Style.Thumb);
  }

  private static bool Switch(string label, bool on)
  {
    Rect rect1 = GUILayoutUtility.GetRect(150f, 26f, new GUILayoutOption[1]
    {
      GUILayout.Width(150f)
    });
    on = GUI.Toggle(rect1, on, GUIContent.none, GUIStyle.none);
    if (Event.current.type == 7)
    {
      Rect rect2;
      // ISSUE: explicit constructor call
      ((Rect) ref rect2).\u002Ector(((Rect) ref rect1).x, ((Rect) ref rect1).y + 3f, 42f, 20f);
      GUI.DrawTexture(rect2, on ? (Texture) Style.PillOn : (Texture) Style.PillOff);
      GUI.DrawTexture(new Rect(on ? ((Rect) ref rect2).xMax - 18f : ((Rect) ref rect2).x + 2f, ((Rect) ref rect2).y + 2f, 16f, 16f), (Texture) Style.Knob);
    }
    GUI.Label(new Rect(((Rect) ref rect1).x + 52f, ((Rect) ref rect1).y, ((Rect) ref rect1).width - 52f, ((Rect) ref rect1).height), label, Style.Label);
    return on;
  }
}
