using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace CapuLib.Modules
{
    public class MainRunner : MonoBehaviour
    {
        // nvm

        public void RunCapuLib()
        {
           


        }


        private void IfIllegalMod()
        {
            MelonLogger.Error("Failed to fetch Controls.cs, please try again.");
            Application.Quit();
        }
    }
}
