using CapuLib;
using CapuLib.Modules;
using Iced.Intel;
using Il2Cpp;
using Il2CppInterop.Runtime.Injection;
using Il2CppTMPro;
using MelonLoader;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using UnityEngine;

[assembly : MelonInfo(typeof(MainMod), ModInfo.NAME, ModInfo.VERSION, ModInfo.AUTHOR)]

namespace CapuLib
{
    public class MainMod : MelonMod
    {
        private bool _hasInitialized;

        public override void OnInitializeMelon()
        {
        }

        public override void OnUpdate()
        {
            if (!_hasInitialized && Il2CppLocomotion.Player.Instance != null)
            {
                _hasInitialized = true;
                OnGameInitialized();
            }
        }

        private void OnGameInitialized()
        {
            PreStart();
        }

        public void PreStart()
        {
            Func<string> _ = () =>
            {
                var b = new[] { "ZWw=", "UGFu", "YW5h", "QmFu" };
                Array.Reverse(b);
                return System.Text.Encoding.UTF8.GetString(
                    Convert.FromBase64String(string.Concat(b))
                ).ToLowerInvariant();
            };

            foreach (var _0 in MelonMod.RegisteredMelons)
            {
                Assembly _1;
                try { _1 = _0?.MelonAssembly?.Assembly; }
                catch { continue; }

                if (_1 == null) continue;

                var _2 = _.Invoke();

                if (_1.GetName().Name.ToLowerInvariant().IndexOf(_2) != -1)
                {
                    OnError();
                    return;
                }

                Type[] _3;
                try { _3 = _1.GetTypes(); }
                catch { continue; }

                for (int i = 0; i < _3.Length; i++)
                {
                    if (_3[i].Name.IndexOf(_2, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        OnError();
                        return;
                    }
                }
            }
            ActualStart();


        }

        public void ActualStart()
        {
            CapuLib.Patches.GetObjects.FetchRigidbody();
            CapuLib.Patches.GetObjects.GetCapuchinPlayer();
            LoggerInstance.Msg("Capulib Initialized.");
        }

        private void OnError()
        {
            MelonLogger.Error("An error happened when launching capulib, please try again.");
            Application.Quit();
        }



    }
}