using CapuLib;
using CapuLib.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace CapuLib.Patches
{
    internal class GetObjects
    {
        public static void FetchRigidbody()
        {
            CapuLib.Modules.Player.PlayerRigidbody = GameObject.Find("Global/CapuchinPhysRig/XR Origin/CapuchinPlayer").GetComponent<Rigidbody>();
        }

        public static void GetCapuchinPlayer()
        {
            CapuLib.Modules.Player.CapuchinPlayer = GameObject.Find("Global/CapuchinPhysRig/XR Origin/CapuchinPlayer");
        }
    }
}
