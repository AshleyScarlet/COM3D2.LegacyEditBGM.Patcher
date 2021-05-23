using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace COM3D2.LegacyEditBGM.Patcher
{
    public static class Patcher
    {
        public static void Patch(AssemblyDefinition assembly)
        {
            AssemblyDefinition assemblyDefinition = AssemblyDefinition.ReadAssembly(Assembly.GetExecutingAssembly().Location);
            PatcherHelper.SetHook(PatcherHelper.HookType.ExPreCall, assembly, "SoundMgr.PlayBGM", assemblyDefinition, "COM3D2.LegacyEditBGM.Patcher.LegacyEditBGM.PlayBGM");
        }

        public static readonly string[] TargetAssemblyNames = new string[]
        {
            "Assembly-CSharp.dll",
        };
    }
}
