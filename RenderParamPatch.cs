// Decompiled with JetBrains decompiler
// Type: NachtsFOV.RenderParamPatch
// Assembly: NachtsFOV, Version=0.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8BE73195-5F92-4FC0-A913-783015E7CF73
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins\Nachts Mods (my mods)\NachtsFOV.dll

using HarmonyLib;
using UnityEngine;
using UnityEngine.XR;

#nullable disable
namespace NachtsFOV;

[HarmonyPatch(typeof (XRDisplaySubsystem.XRRenderPass), "GetRenderParameter")]
internal static class RenderParamPatch
{
  private static void Postfix(
    ref XRDisplaySubsystem.XRRenderParameter renderParameter)
  {
    if (!Settings.Enabled)
      return;
    renderParameter.projection = Fov.Widen(renderParameter.projection, Settings.Fov);
    Fov.LastHit = Time.realtimeSinceStartup;
  }
}
