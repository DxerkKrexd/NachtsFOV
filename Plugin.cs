// Decompiled with JetBrains decompiler
// Type: NachtsFOV.Plugin
// Assembly: NachtsFOV, Version=0.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8BE73195-5F92-4FC0-A913-783015E7CF73
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\BepInEx\plugins\Nachts Mods (my mods)\NachtsFOV.dll

using BepInEx;
using HarmonyLib;
using UnityEngine;

#nullable disable
namespace NachtsFOV;

[BepInPlugin("nachts.fov", "Nachts FOV", "0.2.0")]
public class Plugin : BaseUnityPlugin
{
  public const string Guid = "nachts.fov";

  private void Awake()
  {
    new Harmony("nachts.fov").PatchAll();
    GameObject gameObject = new GameObject("NachtsFOV");
    gameObject.AddComponent<Menu>();
    Object.DontDestroyOnLoad((Object) gameObject);
  }
}
