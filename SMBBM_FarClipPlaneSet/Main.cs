using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flash2;
using UnhollowerRuntimeLib;
using UnityEngine;
using Object = UnityEngine.Object;

namespace SMBBM_FarClipPlane
{
    public static class Main
    {
        private static float farClipPlane = 300;
        private static MgMapCamera mapCam = null;

        public static void OnModLoad(Dictionary<string, object> settings)
        {
            farClipPlane = (float) settings["farClipPlane"];
        }

        public static void OnModUpdate()
        {
            // change map camera settings
            if (mapCam != null)
            {
                mapCam.m_Camera.farClipPlane = farClipPlane;
            }
            // look for map camera
            else
            {
                mapCam = Object.FindObjectOfType<MgMapCamera>();
            }
        }
    }
}   
