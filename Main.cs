using System;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using ReflectionUtility;
using HarmonyLib;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using life;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Config;
using System.Reflection;
using UnityEngine.Tilemaps;
using System.IO;
 
namespace TechsMod{
    [ModEntry]
    class Main : MonoBehaviour{
        #region
        public static Main instance;
        #endregion
        internal static Harmony harmony;
        void Awake(){
         uEquipaments.init();
         uWeapons.init();
         uTechs.init();
         Projectiles.init();
         Clouds.init();
         uAmulet_Ring.init(); 
        }
    }
}
