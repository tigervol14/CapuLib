using CapuLib;
using Il2CppInterop.Runtime.Injection;
using CapuLib.Modules;
using MelonLoader;
using UnityEngine;

[assembly : MelonInfo(typeof(MainMod), ModInfo.NAME, ModInfo.VERSION, ModInfo.AUTHOR)]

namespace CapuLib
{
    public class MainMod : MelonMod
    {

        public override void OnInitializeMelon()
        {
            // get shit lol
            CapuLib.Patches.GetObjects.FetchRigidbody();
            CapuLib.Patches.GetObjects.GetCapuchinPlayer();
            LoggerInstance.Msg("Capulib Initialized.");
        }

    }
}