// Decompiled with JetBrains decompiler
// Type: NachtsFOV.Fov
// Assembly: NachtsFOV, Version=0.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8BE73195-5F92-4FC0-A913-783015E7CF73
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins\Nachts Mods (my mods)\NachtsFOV.dll

using System;
using UnityEngine;

#nullable disable
namespace NachtsFOV;

public static class Fov
{
  public static float LastHit = -10f;

  public static bool Working
  {
    get => Settings.Enabled && (double) Time.realtimeSinceStartup - (double) Fov.LastHit < 0.5;
  }

  public static Matrix4x4 Widen(Matrix4x4 m, float vfov)
  {
    if ((double) m.m00 == 0.0 || (double) m.m11 == 0.0)
      return m;
    float num1 = Mathf.Abs((1f + m.m12) / m.m11);
    float num2 = Mathf.Abs((1f - m.m12) / m.m11);
    float num3 = (float) (((double) Mathf.Atan(num1) + (double) Mathf.Atan(num2)) * 57.295780181884766);
    if ((double) num3 < 1.0)
      return m;
    float num4 = Mathf.Tan((float) ((double) vfov * 0.5 * (Math.PI / 180.0))) / Mathf.Tan((float) ((double) num3 * 0.5 * (Math.PI / 180.0)));
    m.m00 /= num4;
    m.m11 /= num4;
    return m;
  }
}
