// Decompiled with JetBrains decompiler
// Type: NachtsFOV.Style
// Assembly: NachtsFOV, Version=0.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8BE73195-5F92-4FC0-A913-783015E7CF73
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins\Nachts Mods (my mods)\NachtsFOV.dll

using UnityEngine;

#nullable disable
namespace NachtsFOV;

internal static class Style
{
  private static readonly Color bgTop = new Color(0.04f, 0.016f, 0.062f, 0.97f);
  private static readonly Color bgBottom = new Color(0.02f, 0.008f, 0.031f, 0.97f);
  private static readonly Color cardTop = new Color(0.075f, 0.036f, 0.11f, 1f);
  private static readonly Color cardBottom = new Color(0.058f, 0.028f, 0.088f, 1f);
  private static readonly Color edge = new Color(0.62f, 0.34f, 1f, 0.28f);
  private static readonly Color violet = new Color(0.56f, 0.26f, 1f, 1f);
  private static readonly Color pink = new Color(0.93f, 0.28f, 0.74f, 1f);
  private static readonly Color text = new Color(0.94f, 0.91f, 0.98f, 1f);
  private static readonly Color muted = new Color(0.56f, 0.49f, 0.68f, 1f);
  private static readonly Color clear = new Color(0.0f, 0.0f, 0.0f, 0.0f);
  public static GUIStyle Window;
  public static GUIStyle Heading;
  public static GUIStyle Hint;
  public static GUIStyle Small;
  public static GUIStyle Value;
  public static GUIStyle Label;
  public static GUIStyle Status;
  public static GUIStyle StatusOn;
  public static GUIStyle Card;
  public static GUIStyle Button;
  public static GUIStyle Ghost;
  public static GUIStyle SliderBlank;
  public static GUIStyle Thumb;
  public static GUIStyle Track;
  public static GUIStyle Fill;
  public static Texture2D Bar;
  public static Texture2D PillOn;
  public static Texture2D PillOff;
  public static Texture2D Knob;

  public static void Build()
  {
    Texture2D normal = Style.Make(64 /*0x40*/, 48 /*0x30*/, 11f, Style.violet, Style.pink, true, Style.clear);
    Texture2D hover1 = Style.Make(64 /*0x40*/, 48 /*0x30*/, 11f, Color.Lerp(Style.violet, Color.white, 0.15f), Color.Lerp(Style.pink, Color.white, 0.15f), true, Style.clear);
    Texture2D down = Style.Make(64 /*0x40*/, 48 /*0x30*/, 11f, Color.Lerp(Style.violet, Color.black, 0.25f), Color.Lerp(Style.pink, Color.black, 0.25f), true, Style.clear);
    Texture2D texture2D = Style.Make(64 /*0x40*/, 48 /*0x30*/, 11f, Style.cardTop, Style.cardBottom, false, Style.edge);
    Texture2D hover2 = Style.Make(64 /*0x40*/, 48 /*0x30*/, 11f, new Color(0.11f, 0.055f, 0.16f, 1f), new Color(0.09f, 0.045f, 0.13f, 1f), false, new Color(0.7f, 0.45f, 1f, 0.5f));
    Style.Bar = Style.Make(128 /*0x80*/, 2, 1f, Style.violet, new Color(Style.pink.r, Style.pink.g, Style.pink.b, 0.0f), true, Style.clear);
    Style.PillOn = Style.Make(42, 20, 10f, Style.violet, Style.pink, true, Style.clear);
    Style.PillOff = Style.Make(42, 20, 10f, Style.bgBottom, Style.bgBottom, false, Style.edge);
    Style.Knob = Style.Make(32 /*0x20*/, 32 /*0x20*/, 16f, Color.white, new Color(0.85f, 0.8f, 0.95f, 1f), false, Style.clear);
    Style.Window = new GUIStyle(GUI.skin.window);
    Style.Window.padding = new RectOffset(16 /*0x10*/, 16 /*0x10*/, 16 /*0x10*/, 14);
    Style.Window.border = new RectOffset(18, 18, 18, 18);
    Style.Window.alignment = (TextAnchor) 0;
    Style.Window.fontSize = 12;
    Style.Window.fontStyle = (FontStyle) 1;
    Style.Background(Style.Window, Style.Make(96 /*0x60*/, 96 /*0x60*/, 14f, Style.bgTop, Style.bgBottom, false, Style.edge));
    Style.TextColor(Style.Window, Style.muted);
    Style.Heading = Style.Text(17, (FontStyle) 1, (TextAnchor) 3, Style.text, false);
    Style.Hint = Style.Text(11, (FontStyle) 0, (TextAnchor) 3, Style.muted, true);
    Style.Small = Style.Text(10, (FontStyle) 0, (TextAnchor) 3, Style.muted, false);
    Style.Value = Style.Text(17, (FontStyle) 1, (TextAnchor) 5, Color.Lerp(Style.violet, Style.pink, 0.6f), false);
    Style.Label = Style.Text(12, (FontStyle) 1, (TextAnchor) 3, Style.text, false);
    Style.Status = Style.Text(10, (FontStyle) 0, (TextAnchor) 5, Style.muted, false);
    Style.StatusOn = Style.Text(10, (FontStyle) 1, (TextAnchor) 5, Style.pink, false);
    Style.Card = new GUIStyle(GUI.skin.box);
    Style.Card.padding = new RectOffset(14, 14, 10, 12);
    Style.Card.border = new RectOffset(12, 12, 12, 12);
    Style.Background(Style.Card, Style.Make(64 /*0x40*/, 64 /*0x40*/, 11f, Style.cardTop, Style.cardBottom, false, Style.edge));
    Style.Button = Style.MakeButton(normal, hover1, down, Color.white);
    Style.Ghost = Style.MakeButton(texture2D, hover2, texture2D, Style.text);
    Style.Track = new GUIStyle();
    Style.Track.border = new RectOffset(6, 6, 6, 6);
    Style.Track.normal.background = Style.Make(32 /*0x20*/, 12, 6f, Style.bgBottom, Style.bgBottom, false, Style.edge);
    Style.Fill = new GUIStyle();
    Style.Fill.border = new RectOffset(6, 6, 6, 6);
    Style.Fill.normal.background = Style.Make(32 /*0x20*/, 12, 6f, Style.violet, Style.pink, true, Style.clear);
    Style.SliderBlank = new GUIStyle(GUI.skin.horizontalSlider);
    Style.SliderBlank.border = new RectOffset();
    Style.SliderBlank.margin = new RectOffset();
    Style.SliderBlank.padding = new RectOffset();
    Style.SliderBlank.fixedHeight = 0.0f;
    Style.Background(Style.SliderBlank, (Texture2D) null);
    Style.Thumb = new GUIStyle(GUI.skin.horizontalSliderThumb);
    Style.Thumb.border = new RectOffset();
    Style.Thumb.margin = new RectOffset();
    Style.Thumb.padding = new RectOffset();
    Style.Thumb.fixedWidth = 20f;
    Style.Thumb.fixedHeight = 20f;
    Style.Background(Style.Thumb, Style.Knob);
  }

  private static Texture2D Make(
    int w,
    int h,
    float radius,
    Color a,
    Color b,
    bool horizontal,
    Color rim)
  {
    Color[] colorArray = new Color[w * h];
    float num1 = (float) w / 2f;
    float num2 = (float) h / 2f;
    float num3 = Mathf.Min(radius, Mathf.Min(num1, num2));
    for (int index1 = 0; index1 < h; ++index1)
    {
      for (int index2 = 0; index2 < w; ++index2)
      {
        float num4 = Mathf.Abs((float) index2 + 0.5f - num1) - (num1 - num3);
        float num5 = Mathf.Abs((float) index1 + 0.5f - num2) - (num2 - num3);
        Vector2 vector2 = new Vector2(Mathf.Max(num4, 0.0f), Mathf.Max(num5, 0.0f));
        float num6 = ((Vector2) ref vector2).magnitude + Mathf.Min(Mathf.Max(num4, num5), 0.0f) - num3;
        float num7 = horizontal ? ((float) index2 + 0.5f) / (float) w : (float) (1.0 - ((double) index1 + 0.5) / (double) h);
        Color color = Color.Lerp(a, b, num7);
        if ((double) rim.a > 0.0 && (double) num6 > -1.5)
          color = Color.Lerp(color, new Color(rim.r, rim.g, rim.b, color.a), rim.a);
        color.a *= Mathf.Clamp01(0.5f - num6);
        colorArray[index1 * w + index2] = color;
      }
    }
    Texture2D texture2D = new Texture2D(w, h, (TextureFormat) 4, false);
    ((Texture) texture2D).wrapMode = (TextureWrapMode) 1;
    ((Object) texture2D).hideFlags = (HideFlags) 61;
    texture2D.SetPixels(colorArray);
    texture2D.Apply();
    return texture2D;
  }

  private static GUIStyle Text(int size, FontStyle fs, TextAnchor anchor, Color c, bool wrap)
  {
    return new GUIStyle(GUI.skin.label)
    {
      fontSize = size,
      fontStyle = fs,
      alignment = anchor,
      wordWrap = wrap,
      normal = {
        textColor = c
      }
    };
  }

  private static GUIStyle MakeButton(Texture2D normal, Texture2D hover, Texture2D down, Color c)
  {
    GUIStyle s = new GUIStyle(GUI.skin.button);
    s.fontSize = 12;
    s.fontStyle = (FontStyle) 1;
    s.alignment = (TextAnchor) 4;
    s.padding = new RectOffset(12, 12, 8, 8);
    s.border = new RectOffset(11, 11, 11, 11);
    s.normal.background = normal;
    s.focused.background = normal;
    s.hover.background = hover;
    s.active.background = down;
    Style.TextColor(s, c);
    return s;
  }

  private static void Background(GUIStyle s, Texture2D t)
  {
    s.normal.background = s.hover.background = s.active.background = s.focused.background = t;
    s.onNormal.background = s.onHover.background = s.onActive.background = s.onFocused.background = t;
  }

  private static void TextColor(GUIStyle s, Color c)
  {
    s.normal.textColor = s.hover.textColor = s.active.textColor = s.focused.textColor = c;
    s.onNormal.textColor = s.onHover.textColor = s.onActive.textColor = s.onFocused.textColor = c;
  }
}
