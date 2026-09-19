using System;
using System.Reflection;
using NCMS;
using UnityEngine;
using ReflectionUtility;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using NCMS.Utils;
using System.Runtime.CompilerServices;
using DG.Tweening;
using EpPathFinding.cs;
using life.taxi;
using SleekRender;
using tools.debug;
using UnityEngine.EventSystems;
using WorldBoxConsole;
using Newtonsoft.Json;
using UnityEngine.Scripting;
using System.ComponentModel;

namespace TechsMod
{
    class uTechs
    {
        public static void init()
        {
            Harmony harmony = new Harmony("Brug");
            MethodInfo original = AccessTools.Method(typeof(Culture), "haveRequiredTechFor");
            MethodInfo postfix = AccessTools.Method(typeof(uTechs), "haveRequiredTechFor_Postfix");
            harmony.Patch(original, null, new HarmonyMethod(postfix));

            CultureTechAsset BonesandWood_production = new CultureTechAsset();
            BonesandWood_production.id = "BonesandWood_production";
            BonesandWood_production.path_icon = "bones_production";
            BonesandWood_production.priority = false;
            BonesandWood_production.required_level = 5;
            BonesandWood_production.requirements = new List<string>();
            Localization.addLocalization("tech_BonesandWood_production", "Bones&Wood Weapon Production");
            AssetManager.culture_tech.add(BonesandWood_production);

            CultureTechAsset Crossbow_production = new CultureTechAsset();
            Crossbow_production.id = "Crossbow_production";
            Crossbow_production.path_icon = "crossbow_production";
            Crossbow_production.priority = false;
            Crossbow_production.required_level = 10;
            Crossbow_production.requirements = new List<string>();
            Localization.addLocalization("tech_Crossbow_production", "Crossbow Production");
            AssetManager.culture_tech.add(Crossbow_production);

            CultureTechAsset Shield_production = new CultureTechAsset();
            Shield_production.id = "Shield_production";
            Shield_production.path_icon = "shield_production";
            Shield_production.priority = false;
            Shield_production.required_level = 10;
            Shield_production.requirements = new List<string>();
            Localization.addLocalization("tech_Shield_production", "Shield Production");
            AssetManager.culture_tech.add(Shield_production);

            CultureTechAsset FireStaff = new CultureTechAsset();
            FireStaff.id = "FireStaff";
            FireStaff.path_icon = "FireStaff";
            FireStaff.priority = false;
            FireStaff.required_level = 50;
            FireStaff.requirements = new List<string>();
            Localization.addLocalization("tech_FireStaff", "Wizards Fire Staff Production");
            AssetManager.culture_tech.add(FireStaff);

            CultureTechAsset ThunderStaff = new CultureTechAsset();
            ThunderStaff.id = "ThunderStaff";
            ThunderStaff.path_icon = "ThunderStaff";
            ThunderStaff.priority = false;
            ThunderStaff.required_level = 50;
            ThunderStaff.requirements = new List<string>();
            Localization.addLocalization("tech_ThunderStaff", "Wizards Thunder Staff Production");
            AssetManager.culture_tech.add(ThunderStaff);

            CultureTechAsset FrostStaff = new CultureTechAsset();
            FrostStaff.id = "FrostStaff";
            FrostStaff.path_icon = "FrostStaff";
            FrostStaff.priority = false;
            FrostStaff.required_level = 50;
            FrostStaff.requirements = new List<string>();
            Localization.addLocalization("tech_FrostStaff", "Wizards Frost Staff Production");
            AssetManager.culture_tech.add(FrostStaff);

            CultureTechAsset MagicalRings_production = new CultureTechAsset();
            MagicalRings_production.id = "MagicalRings_production";
            MagicalRings_production.path_icon = "MagicalRings_production";
            MagicalRings_production.priority = false;
            MagicalRings_production.required_level = 30;
            MagicalRings_production.requirements = new List<string>();
            Localization.addLocalization("tech_MagicalRings_production", "Magical Rings Production");
            AssetManager.culture_tech.add(MagicalRings_production);

            CultureTechAsset MagicalAmulets_production = new CultureTechAsset();
            MagicalAmulets_production.id = "MagicalAmulets_production";
            MagicalAmulets_production.path_icon = "MagicalAmulets_production";
            MagicalAmulets_production.priority = false;
            MagicalAmulets_production.required_level = 30;
            MagicalAmulets_production.requirements = new List<string>();
            Localization.addLocalization("tech_MagicalAmulets_production", "Magical Amulets Production");
            AssetManager.culture_tech.add(MagicalAmulets_production);

      }




     
        public static void haveRequiredTechFor_Postfix(Culture __instance, ref bool __result, CultureTechAsset pTech){
            if (pTech.requirements == null) return;
                for (int i = 0; i < pTech.requirements.Count; ++i) {
                    string item = pTech.requirements[i];
                    if (!__instance.data.list_tech_ids.Contains(item[0] == '!' ? item.Substring(1) : item)) {
                        if (item[0] != '!') {
                            __result = false;
                            return;
                        }
                    } else {
                        if (item[0] == '!') {
                            __result = false;
                            return;
                        }
                    }
                }
        __result = true;

        
        }
    }
}