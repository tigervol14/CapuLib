using CapuLib;
using CapuLib.Modules;
using Il2Cpp;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Injection;
using MelonLoader;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.XR;



namespace CapuLib.Modules
{
    internal class Player
    {

        public static Rigidbody PlayerRigidbody = null!;
        public static GameObject CapuchinPlayer = null!;

        public static void ChangeBounce(float bounce)
        {
            Il2CppLocomotion.Player.Instance.climbDrag = bounce;
        }

        public static void ChangeSize(float size)
        {
            Il2CppLocomotion.Player.Instance.scale = size;
        }

        public static void SendVibration(bool Left)
        {
            Il2CppLocomotion.Player.Instance.VibrateController(Left);
        }

        public static void ClickSound(bool Left, int type)
        {
            Il2CppLocomotion.Player.Instance.clickSound(Left, 0);
        }

        public static void DisableMovement(bool enable)
        {
            if (enable)
            {
                Il2CppLocomotion.Player.Instance.disableMovement = false;
            }
            else
            {
                Il2CppLocomotion.Player.Instance.disableMovement = true;
            }
        }

        public static void ChangeHealth(int health)
        {
            Il2CppLocomotion.Player.Instance.health = health;
        }

        public static void ControlGravity(bool enable)
        {
            if (enable)
            {
                PlayerRigidbody.useGravity = true;
            }
            else
            {
                PlayerRigidbody.useGravity = false;
            }
        }

        public static void ControlPhysics(bool enable)
        {
            if (enable)
            {
                PlayerRigidbody.isKinematic = true;
            }
            else
            {
                PlayerRigidbody.isKinematic = false;
            }
        }


    }
}