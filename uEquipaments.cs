using System;
using NCMS;
using UnityEngine;
using ReflectionUtility;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using NCMS.Utils;

namespace TechsMod
{
    class uEquipaments
    {
        public static void init()
        {
 
          craftitems();

//Shields-----------------------------------------------------------------------------------------


          ItemAsset BoneLeatherShield = AssetManager.items.clone("BoneLeatherShield", "helmet");
          BoneLeatherShield.id = "BoneLeatherShield";
          BoneLeatherShield.materials = List.Of<string>(new string []{"leather"});
          BoneLeatherShield.base_stats[S.armor] = 5;
          BoneLeatherShield.base_stats[S.knockback_reduction] = 5f;
          BoneLeatherShield.base_stats[S.warfare] = 1;
          BoneLeatherShield.base_stats[S.speed] = -5;
          BoneLeatherShield.equipment_value = 45;
          BoneLeatherShield.quality = ItemQuality.Normal;
          BoneLeatherShield.tech_needed = "Shield_production";
          BoneLeatherShield.equipmentType = EquipmentType.Helmet;
          BoneLeatherShield.name_class = "item_class_armor";
          BoneLeatherShield.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          AssetManager.items.list.AddItem(BoneLeatherShield);
          Localization.addLocalization("item_BoneLeatherShield", "Bone&Leather Shield");


          ItemAsset CopperShield = AssetManager.items.clone("CopperShield", "helmet");
          CopperShield.id = "CopperShield";
          CopperShield.materials = List.Of<string>(new string []{"copper"});
/*
          CopperShield.base_stats[S.fertility] = 0.0f;
          CopperShield.base_stats[S.max_children] = 0f;
          CopperShield.base_stats[S.max_age] = 0f;
          CopperShield.base_stats[S.attack_speed] = 0;
          CopperShield.base_stats[S.damage] = 0;
          CopperShield.base_stats[S.health] = 0;
          CopperShield.base_stats[S.accuracy] = 0f;
          CopperShield.base_stats[S.range] = 0;
*/
          CopperShield.base_stats[S.armor] = 6;
          CopperShield.base_stats[S.knockback_reduction] = 5f;
          CopperShield.base_stats[S.warfare] = 2;
          CopperShield.base_stats[S.speed] = -5;
/*
          CopperShield.base_stats[S.scale] = 0.0f;
          CopperShield.base_stats[S.dodge] = 0f;
          CopperShield.base_stats[S.targets] = 0f;
          CopperShield.base_stats[S.critical_chance] = 0.0f;
          CopperShield.base_stats[S.knockback] = 0f;
          CopperShield.base_stats[S.intelligence] = 0;
          CopperShield.base_stats[S.diplomacy] = 0;
          CopperShield.base_stats[S.stewardship] = 0;
          CopperShield.base_stats[S.opinion] = 0f;
          CopperShield.base_stats[S.loyalty_traits] = 0f;
          CopperShield.base_stats[S.cities] = 0;
          CopperShield.base_stats[S.zone_range] = 0;
*/
          CopperShield.equipment_value = 50;
          CopperShield.quality = ItemQuality.Normal;
          CopperShield.tech_needed = "Shield_production";
          CopperShield.equipmentType = EquipmentType.Helmet;
          CopperShield.name_class = "item_class_armor";
          CopperShield.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          AssetManager.items.list.AddItem(CopperShield);
          Localization.addLocalization("item_CopperShield", "Copper Shield");

          ItemAsset BronzeShield = AssetManager.items.clone("BronzeShield", "helmet");
          BronzeShield.id = "BronzeShield";
          BronzeShield.materials = List.Of<string>(new string []{"bronze"});
          BronzeShield.base_stats[S.armor] = 7;
          BronzeShield.base_stats[S.knockback_reduction] = 5f;
          BronzeShield.base_stats[S.warfare] = 3;
          BronzeShield.base_stats[S.speed] = -5;
          BronzeShield.equipment_value = 55;
          BronzeShield.quality = ItemQuality.Normal;
          BronzeShield.tech_needed = "Shield_production";
          BronzeShield.equipmentType = EquipmentType.Helmet;
          BronzeShield.name_class = "item_class_armor";
          BronzeShield.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          AssetManager.items.list.AddItem(BronzeShield);
          Localization.addLocalization("item_BronzeShield", "Bronze Shield");

          ItemAsset SilverShield = AssetManager.items.clone("SilverShield", "helmet");
          SilverShield.id = "SilverShield";
          SilverShield.materials = List.Of<string>(new string []{"silver"});
          SilverShield.base_stats[S.armor] = 8;
          SilverShield.base_stats[S.knockback_reduction] = 5f;
          SilverShield.base_stats[S.warfare] = 4;
          SilverShield.base_stats[S.speed] = -5;
          SilverShield.equipment_value = 60;
          SilverShield.quality = ItemQuality.Normal;
          SilverShield.tech_needed = "Shield_production";
          SilverShield.equipmentType = EquipmentType.Helmet;
          SilverShield.name_class = "item_class_armor";
          SilverShield.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          AssetManager.items.list.AddItem(SilverShield);
          Localization.addLocalization("item_SilverShield", "Silver Shield");

          ItemAsset IronShield = AssetManager.items.clone("IronShield", "helmet");
          IronShield.id = "IronShield";
          IronShield.materials = List.Of<string>(new string []{"iron"});
          IronShield.base_stats[S.armor] = 9;
          IronShield.base_stats[S.knockback_reduction] = 5f;
          IronShield.base_stats[S.warfare] = 5;
          IronShield.base_stats[S.speed] = -5;
          IronShield.equipment_value = 65;
          IronShield.quality = ItemQuality.Normal;
          IronShield.tech_needed = "Shield_production";
          IronShield.equipmentType = EquipmentType.Helmet;
          IronShield.name_class = "item_class_armor";
          IronShield.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          AssetManager.items.list.AddItem(IronShield);
          Localization.addLocalization("item_IronShield", "Iron Shield");

          ItemAsset SteelShield = AssetManager.items.clone("SteelShield", "helmet");
          SteelShield.id = "SteelShield";
          SteelShield.materials = List.Of<string>(new string []{"steel"});
          SteelShield.base_stats[S.armor] = 10;
          SteelShield.base_stats[S.knockback_reduction] = 5f;
          SteelShield.base_stats[S.warfare] = 6;
          SteelShield.base_stats[S.speed] = -5;
          SteelShield.equipment_value = 70;
          SteelShield.quality = ItemQuality.Normal;
          SteelShield.tech_needed = "Shield_production";
          SteelShield.equipmentType = EquipmentType.Helmet;
          SteelShield.name_class = "item_class_armor";
          SteelShield.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          AssetManager.items.list.AddItem(SteelShield);
          Localization.addLocalization("item_SteelShield", "Steel Shield");

          ItemAsset MythrilShield = AssetManager.items.clone("MythrilShield", "helmet");
          MythrilShield.id = "MythrilShield";
          MythrilShield.materials = List.Of<string>(new string []{"mythril"});
          MythrilShield.base_stats[S.armor] = 12;
          MythrilShield.base_stats[S.knockback_reduction] = 5f;
          MythrilShield.base_stats[S.warfare] = 7;
          MythrilShield.base_stats[S.speed] = -5;
          MythrilShield.equipment_value = 75;
          MythrilShield.quality = ItemQuality.Normal;
          MythrilShield.tech_needed = "Shield_production";
          MythrilShield.equipmentType = EquipmentType.Helmet;
          MythrilShield.name_class = "item_class_armor";
          MythrilShield.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          AssetManager.items.list.AddItem(MythrilShield);
          Localization.addLocalization("item_MythrilShield", "Mythril Shield");

          ItemAsset AdamantineShield = AssetManager.items.clone("AdamantineShield", "helmet");
          AdamantineShield.id = "AdamantineShield";
          AdamantineShield.materials = List.Of<string>(new string []{"adamantine"});
          AdamantineShield.base_stats[S.armor] = 13;
          AdamantineShield.base_stats[S.knockback_reduction] = 5f;
          AdamantineShield.base_stats[S.warfare] = 7;
          AdamantineShield.base_stats[S.speed] = -5;
          AdamantineShield.equipment_value = 75;
          AdamantineShield.quality = ItemQuality.Normal;
          AdamantineShield.tech_needed = "Shield_production";
          AdamantineShield.equipmentType = EquipmentType.Helmet;
          AdamantineShield.name_class = "item_class_armor";
          AdamantineShield.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          AssetManager.items.list.AddItem(AdamantineShield);
          Localization.addLocalization("item_AdamantineShield", "Adamantine Shield");

//-----------------------------------------------------------------------------------------
 
          static void craftitems() {
 
          Race human = AssetManager.raceLibrary.get("human");
          Race orc = AssetManager.raceLibrary.get("orc");
          Race dwarf = AssetManager.raceLibrary.get("dwarf");
          Race elf = AssetManager.raceLibrary.get("elf");

          
          human.preferred_weapons.Add("BoneLeatherShield");
          elf.preferred_weapons.Add("BoneLeatherShield");
          dwarf.preferred_weapons.Add("BoneLeatherShield");
          orc.preferred_weapons.Add("BoneLeatherShield");

human.preferred_weapons.Add("CopperShield");
          elf.preferred_weapons.Add("CopperShield");
          dwarf.preferred_weapons.Add("CopperShield");
          orc.preferred_weapons.Add("CopperShield");

human.preferred_weapons.Add("BronzeShield");
          elf.preferred_weapons.Add("BronzeShield");
          dwarf.preferred_weapons.Add("BronzeShield");
          orc.preferred_weapons.Add("BronzeShield");

human.preferred_weapons.Add("SilverShield");
          elf.preferred_weapons.Add("SilverShield");
          dwarf.preferred_weapons.Add("SilverShield");
          orc.preferred_weapons.Add("SilverShield");

human.preferred_weapons.Add("IronShield");
          elf.preferred_weapons.Add("IronShield");
          dwarf.preferred_weapons.Add("IronShield");
          orc.preferred_weapons.Add("IronShield");

human.preferred_weapons.Add("SteelShield");
          elf.preferred_weapons.Add("SteelShield");
          dwarf.preferred_weapons.Add("SteelShield");
          orc.preferred_weapons.Add("SteelShield");

human.preferred_weapons.Add("MythrilShield");
          elf.preferred_weapons.Add("MythrilShield");
          dwarf.preferred_weapons.Add("MythrilShield");
          orc.preferred_weapons.Add("MythrilShield");

human.preferred_weapons.Add("AdamantineShield");
          elf.preferred_weapons.Add("AdamantineShield");
          dwarf.preferred_weapons.Add("AdamantineShield");
          orc.preferred_weapons.Add("AdamantineShield");
         
         }
 
        }
        public static bool NoneAttackSomeoneAction(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
 
             return false;
 
        }
        public static bool NoneRegularAction(BaseSimObject pTarget, WorldTile pTile = null)
        {
 
             return false;
 
        }
        public static bool NoneGetAttackedAction(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
        {
 
             return false;
 
        }
        public static bool NoneDeathAction(BaseSimObject pTarget, WorldTile pTile = null)
        {
 
             return false;
        
 
            }
            static void addWeaponsSprite(string id, string material)
            {
              var dictItems = Reflection.GetField(typeof(ActorAnimationLoader), null, "dictItems") as Dictionary<string, Sprite>;
              var sprite = Resources.Load<Sprite>("Weapons/w_" + id + "_" + material);
              dictItems.Add(sprite.name, sprite);
            }
        }
    }
