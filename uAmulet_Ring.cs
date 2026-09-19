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
    class uAmulet_Ring
    {
        public static void init()
        {
 
          craftitems();
     
//EnchantedRings-----------------------------------------------------------------------------------------

          ItemAsset Ring2 = AssetManager.items.clone("Ring2", "ring");
          Ring2.id = "Ring2";
          Ring2.materials = List.Of<string>(new string []{"copper"});
/*
          Ring2.base_stats[S.fertility] = 0.0f;
          Ring2.base_stats[S.max_children] = 0f;
          Ring2.base_stats[S.max_age] = 0f;
          Ring2.base_stats[S.speed] = 0f;
          Ring2.base_stats[S.range] = 0;
*/
          Ring2.base_stats[S.armor] = 2;
          Ring2.base_stats[S.critical_chance] = 0.3f;
          Ring2.base_stats[S.warfare] = 3;
          Ring2.base_stats[S.health] = 100;
          Ring2.base_stats[S.accuracy] = 0.5f;
          Ring2.base_stats[S.damage] = 1;
          Ring2.base_stats[S.attack_speed] = 1;
/*
          Ring2.base_stats[S.scale] = 0.0f;
          Ring2.base_stats[S.dodge] = 0f;
          Ring2.base_stats[S.targets] = 0f;
          Ring2.base_stats[S.knockback] = 0f;
          Ring2.base_stats[S.knockback_reduction] = 0f;
          Ring2.base_stats[S.intelligence] = 0;
          Ring2.base_stats[S.diplomacy] = 0;
          Ring2.base_stats[S.stewardship] = 0;
          Ring2.base_stats[S.opinion] = 0f;
          Ring2.base_stats[S.loyalty_traits] = 0f;
          Ring2.base_stats[S.cities] = 0;
          Ring2.base_stats[S.zone_range] = 0;
*/
          Ring2.equipment_value = 100;
          Ring2.quality = ItemQuality.Normal;
          Ring2.tech_needed = "MagicalRings_production";
          Ring2.equipmentType = EquipmentType.Ring;
          Ring2.name_class = "item_class_accessory";
          Ring2.name_templates = List.Of<string>(new string[]{ "ring_name" });
          AssetManager.items.list.AddItem(Ring2);
          Localization.addLocalization("item_Ring2", "Enchanted Ring I");


          ItemAsset Ring3 = AssetManager.items.clone("Ring3", "ring");
          Ring3.id = "Ring3";
          Ring3.materials = List.Of<string>(new string []{"bronze"});
          Ring3.base_stats[S.armor] = 3;
          Ring3.base_stats[S.critical_chance] = 0.5f;
          Ring3.base_stats[S.warfare] = 5;
          Ring3.base_stats[S.health] = 150;
          Ring3.base_stats[S.accuracy] = 0.10f;
          Ring3.base_stats[S.damage] = 2;
          Ring3.base_stats[S.attack_speed] = 3;
          Ring3.equipment_value = 110;
          Ring3.quality = ItemQuality.Normal;
          Ring3.tech_needed = "MagicalRings_production";
          Ring3.equipmentType = EquipmentType.Ring;
          Ring3.name_class = "item_class_accessory";
          Ring3.name_templates = List.Of<string>(new string[]{ "ring_name" });
          AssetManager.items.list.AddItem(Ring3);
          Localization.addLocalization("item_Ring3", "Enchanted Ring II");

          
          ItemAsset Ring4 = AssetManager.items.clone("Ring4", "ring");
          Ring4.id = "Ring4";
          Ring4.materials = List.Of<string>(new string []{"silver"});
          Ring4.base_stats[S.armor] = 4;
          Ring4.base_stats[S.critical_chance] = 0.7f;
          Ring4.base_stats[S.warfare] = 7;
          Ring4.base_stats[S.health] = 200;
          Ring4.base_stats[S.accuracy] = 0.15f;
          Ring4.base_stats[S.damage] = 3;
          Ring4.base_stats[S.attack_speed] = 5;
          Ring4.equipment_value = 120;
          Ring4.quality = ItemQuality.Normal;
          Ring4.tech_needed = "MagicalRings_production";
          Ring4.equipmentType = EquipmentType.Ring;
          Ring4.name_class = "item_class_accessory";
          Ring4.name_templates = List.Of<string>(new string[]{ "ring_name" });
          AssetManager.items.list.AddItem(Ring4);
          Localization.addLocalization("item_Ring4", "Enchanted Ring III");

      
          ItemAsset Ring5 = AssetManager.items.clone("Ring5", "ring");
          Ring5.id = "Ring5";
          Ring5.materials = List.Of<string>(new string []{"iron"});
          Ring5.base_stats[S.armor] = 5;
          Ring5.base_stats[S.critical_chance] = 0.9f;
          Ring5.base_stats[S.warfare] = 9;
          Ring5.base_stats[S.health] = 250;
          Ring5.base_stats[S.accuracy] = 0.20f;
          Ring5.base_stats[S.damage] = 4;
          Ring5.base_stats[S.attack_speed] = 7;
          Ring5.equipment_value = 130;
          Ring5.quality = ItemQuality.Normal;
          Ring5.tech_needed = "MagicalRings_production";
          Ring5.equipmentType = EquipmentType.Ring;
          Ring5.name_class = "item_class_accessory";
          Ring5.name_templates = List.Of<string>(new string[]{ "ring_name" });
          AssetManager.items.list.AddItem(Ring5);
          Localization.addLocalization("item_Ring5", "Enchanted Ring IV");


          ItemAsset Ring6 = AssetManager.items.clone("Ring6", "ring");
          Ring6.id = "Ring6";
          Ring6.materials = List.Of<string>(new string []{"steel"});
          Ring6.base_stats[S.armor] = 6;
          Ring6.base_stats[S.critical_chance] = 0.11f;
          Ring6.base_stats[S.warfare] = 11;
          Ring6.base_stats[S.health] = 300;
          Ring6.base_stats[S.accuracy] = 0.25f;
          Ring6.base_stats[S.damage] = 5;
          Ring6.base_stats[S.attack_speed] = 9;
          Ring6.equipment_value = 140;
          Ring6.quality = ItemQuality.Normal;
          Ring6.tech_needed = "MagicalRings_production";
          Ring6.equipmentType = EquipmentType.Ring;
          Ring6.name_class = "item_class_accessory";
          Ring6.name_templates = List.Of<string>(new string[]{ "ring_name" });
          AssetManager.items.list.AddItem(Ring6);
          Localization.addLocalization("item_Ring6", "Enchanted Ring V");


          ItemAsset Ring7 = AssetManager.items.clone("Ring7", "ring");
          Ring7.id = "Ring7";
          Ring7.materials = List.Of<string>(new string []{"mythril"});
          Ring7.base_stats[S.armor] = 7;
          Ring7.base_stats[S.critical_chance] = 0.13f;
          Ring7.base_stats[S.warfare] = 13;
          Ring7.base_stats[S.health] = 350;
          Ring7.base_stats[S.accuracy] = 0.30f;
          Ring7.base_stats[S.damage] = 6;
          Ring7.base_stats[S.attack_speed] = 11;
          Ring7.equipment_value = 150;
          Ring7.quality = ItemQuality.Normal;
          Ring7.tech_needed = "MagicalRings_production";
          Ring7.equipmentType = EquipmentType.Ring;
          Ring7.name_class = "item_class_accessory";
          Ring7.name_templates = List.Of<string>(new string[]{ "ring_name" });
          AssetManager.items.list.AddItem(Ring7);
          Localization.addLocalization("item_Ring7", "Enchanted Ring VI");


          ItemAsset Ring8 = AssetManager.items.clone("Ring8", "ring");
          Ring8.id = "Ring8";
          Ring8.materials = List.Of<string>(new string []{"adamantine"});
          Ring8.base_stats[S.armor] = 8;
          Ring8.base_stats[S.critical_chance] = 0.15f;
          Ring8.base_stats[S.warfare] = 15;
          Ring8.base_stats[S.health] = 400;
          Ring8.base_stats[S.accuracy] = 0.35f;
          Ring8.base_stats[S.damage] = 8;
          Ring8.base_stats[S.attack_speed] = 13;
          Ring8.equipment_value = 160;
          Ring8.quality = ItemQuality.Normal;
          Ring8.tech_needed = "MagicalRings_production";
          Ring8.equipmentType = EquipmentType.Ring;
          Ring8.name_class = "item_class_accessory";
          Ring8.name_templates = List.Of<string>(new string[]{ "ring_name" });
          AssetManager.items.list.AddItem(Ring8);
          Localization.addLocalization("item_Ring8", "Enchanted Ring VII");

//EnchantedAmulets-----------------------------------------------------------------------------------------


          ItemAsset Amulet2 = AssetManager.items.clone("Amulet2", "amulet");
          Amulet2.id = "Amulet2";
          Amulet2.materials = List.Of<string>(new string []{"copper"});
          Amulet2.base_stats[S.armor] = 2;
          Amulet2.base_stats[S.knockback] = 0.1f;
          Amulet2.base_stats[S.intelligence] = 2;
          Amulet2.base_stats[S.diplomacy] = 2;
          Amulet2.base_stats[S.stewardship] = 2;
          Amulet2.base_stats[S.health] = 50;
          Amulet2.equipment_value = 100;
          Amulet2.quality = ItemQuality.Normal;
          Amulet2.tech_needed = "MagicalAmulets_production";
          Amulet2.equipmentType = EquipmentType.Amulet;
          Amulet2.name_class = "item_class_accessory";
          Amulet2.name_templates = List.Of<string>(new string[]{ "amulet_name" });
          AssetManager.items.list.AddItem(Amulet2);
          Localization.addLocalization("item_Amulet2", "Enchanted Amulet I");


          ItemAsset Amulet3 = AssetManager.items.clone("Amulet3", "amulet");
          Amulet3.id = "Amulet3";
          Amulet3.materials = List.Of<string>(new string []{"bronze"});
          Amulet3.base_stats[S.armor] = 3;
          Amulet3.base_stats[S.knockback] = 0.3f;
          Amulet3.base_stats[S.intelligence] = 4;
          Amulet3.base_stats[S.diplomacy] = 4;
          Amulet3.base_stats[S.stewardship] = 4;
          Amulet3.base_stats[S.health] = 75;
          Amulet3.equipment_value = 110;
          Amulet3.quality = ItemQuality.Normal;
          Amulet3.tech_needed = "MagicalAmulets_production";
          Amulet3.equipmentType = EquipmentType.Amulet;
          Amulet3.name_class = "item_class_accessory";
          Amulet3.name_templates = List.Of<string>(new string[]{ "amulet_name" });
          AssetManager.items.list.AddItem(Amulet3);
          Localization.addLocalization("item_Amulet3", "Enchanted Amulet II");


          ItemAsset Amulet4 = AssetManager.items.clone("Amulet4", "amulet");
          Amulet4.id = "Amulet4";
          Amulet4.materials = List.Of<string>(new string []{"silver"});
          Amulet4.base_stats[S.armor] = 4;
          Amulet4.base_stats[S.knockback] = 0.5f;
          Amulet4.base_stats[S.intelligence] = 6;
          Amulet4.base_stats[S.diplomacy] = 6;
          Amulet4.base_stats[S.stewardship] = 6;
          Amulet4.base_stats[S.health] = 100;
          Amulet4.equipment_value = 120;
          Amulet4.quality = ItemQuality.Normal;
          Amulet4.tech_needed = "MagicalAmulets_production";
          Amulet4.equipmentType = EquipmentType.Amulet;
          Amulet4.name_class = "item_class_accessory";
          Amulet4.name_templates = List.Of<string>(new string[]{ "amulet_name" });
          AssetManager.items.list.AddItem(Amulet4);
          Localization.addLocalization("item_Amulet4", "Enchanted Amulet III");


          ItemAsset Amulet5 = AssetManager.items.clone("Amulet5", "amulet");
          Amulet5.id = "Amulet5";
          Amulet5.materials = List.Of<string>(new string []{"iron"});
          Amulet5.base_stats[S.armor] = 5;
          Amulet5.base_stats[S.knockback] = 0.7f;
          Amulet5.base_stats[S.intelligence] = 8;
          Amulet5.base_stats[S.diplomacy] = 8;
          Amulet5.base_stats[S.stewardship] = 8;
          Amulet5.base_stats[S.health] = 125;
          Amulet5.equipment_value = 130;
          Amulet5.quality = ItemQuality.Normal;
          Amulet5.tech_needed = "MagicalAmulets_production";
          Amulet5.equipmentType = EquipmentType.Amulet;
          Amulet5.name_class = "item_class_accessory";
          Amulet5.name_templates = List.Of<string>(new string[]{ "amulet_name" });
          AssetManager.items.list.AddItem(Amulet5);
          Localization.addLocalization("item_Amulet5", "Enchanted Amulet IV");


          ItemAsset Amulet6 = AssetManager.items.clone("Amulet6", "amulet");
          Amulet6.id = "Amulet6";
          Amulet6.materials = List.Of<string>(new string []{"steel"});
          Amulet6.base_stats[S.armor] = 6;
          Amulet6.base_stats[S.knockback] = 0.9f;
          Amulet6.base_stats[S.intelligence] = 10;
          Amulet6.base_stats[S.diplomacy] = 10;
          Amulet6.base_stats[S.stewardship] = 10;
          Amulet6.base_stats[S.health] = 150;
          Amulet6.equipment_value = 140;
          Amulet6.quality = ItemQuality.Normal;
          Amulet6.tech_needed = "MagicalAmulets_production";
          Amulet6.equipmentType = EquipmentType.Amulet;
          Amulet6.name_class = "item_class_accessory";
          Amulet6.name_templates = List.Of<string>(new string[]{ "amulet_name" });
          AssetManager.items.list.AddItem(Amulet6);
          Localization.addLocalization("item_Amulet6", "Enchanted Amulet V");


          ItemAsset Amulet7 = AssetManager.items.clone("Amulet7", "amulet");
          Amulet7.id = "Amulet7";
          Amulet7.materials = List.Of<string>(new string []{"mythril"});
          Amulet7.base_stats[S.armor] = 7;
          Amulet7.base_stats[S.knockback] = 0.11f;
          Amulet7.base_stats[S.intelligence] = 12;
          Amulet7.base_stats[S.diplomacy] = 12;
          Amulet7.base_stats[S.stewardship] = 12;
          Amulet7.base_stats[S.health] = 175;
          Amulet7.equipment_value = 150;
          Amulet7.quality = ItemQuality.Normal;
          Amulet7.tech_needed = "MagicalAmulets_production";
          Amulet7.equipmentType = EquipmentType.Amulet;
          Amulet7.name_class = "item_class_accessory";
          Amulet7.name_templates = List.Of<string>(new string[]{ "amulet_name" });
          AssetManager.items.list.AddItem(Amulet7);
          Localization.addLocalization("item_Amulet7", "Enchanted Amulet VI");


          ItemAsset Amulet8 = AssetManager.items.clone("Amulet8", "amulet");
          Amulet8.id = "Amulet8";
          Amulet8.materials = List.Of<string>(new string []{"adamantine"});
          Amulet8.base_stats[S.armor] = 9;
          Amulet8.base_stats[S.knockback] = 0.15f;
          Amulet8.base_stats[S.intelligence] = 15;
          Amulet8.base_stats[S.diplomacy] = 15;
          Amulet8.base_stats[S.stewardship] = 15;
          Amulet8.base_stats[S.health] = 300;
          Amulet8.equipment_value = 160;
          Amulet8.quality = ItemQuality.Normal;
          Amulet8.tech_needed = "MagicalAmulets_production";
          Amulet8.equipmentType = EquipmentType.Amulet;
          Amulet8.name_class = "item_class_accessory";
          Amulet8.name_templates = List.Of<string>(new string[]{ "amulet_name" });
          AssetManager.items.list.AddItem(Amulet8);
          Localization.addLocalization("item_Amulet8", "Enchanted Amulet VII");


//-----------------------------------------------------------------------------------------
 
          static void craftitems() {
 
          Race human = AssetManager.raceLibrary.get("human");
          Race orc = AssetManager.raceLibrary.get("orc");
          Race dwarf = AssetManager.raceLibrary.get("dwarf");
          Race elf = AssetManager.raceLibrary.get("elf");

          
          human.preferred_weapons.Add("Ring2");
          elf.preferred_weapons.Add("Ring2");
          dwarf.preferred_weapons.Add("Ring2");
          orc.preferred_weapons.Add("Ring2");

human.preferred_weapons.Add("Ring3");
          elf.preferred_weapons.Add("Ring3");
          dwarf.preferred_weapons.Add("Ring3");
          orc.preferred_weapons.Add("Ring3");

human.preferred_weapons.Add("Ring4");
          elf.preferred_weapons.Add("Ring4");
          dwarf.preferred_weapons.Add("Ring4");
          orc.preferred_weapons.Add("Ring4");

human.preferred_weapons.Add("Ring5");
          elf.preferred_weapons.Add("Ring5");
          dwarf.preferred_weapons.Add("Ring5");
          orc.preferred_weapons.Add("Ring5");

human.preferred_weapons.Add("Ring6");
          elf.preferred_weapons.Add("Ring6");
          dwarf.preferred_weapons.Add("Ring6");
          orc.preferred_weapons.Add("Ring6");


human.preferred_weapons.Add("Ring7");
          elf.preferred_weapons.Add("Ring7");
          dwarf.preferred_weapons.Add("Ring7");
          orc.preferred_weapons.Add("Ring7");

human.preferred_weapons.Add("Ring8");
          elf.preferred_weapons.Add("Ring8");
          dwarf.preferred_weapons.Add("Ring8");
          orc.preferred_weapons.Add("Ring8");

human.preferred_weapons.Add("Amulet2");
          elf.preferred_weapons.Add("Amulet2");
          dwarf.preferred_weapons.Add("Amulet2");
          orc.preferred_weapons.Add("Amulet2");

human.preferred_weapons.Add("Amulet3");
          elf.preferred_weapons.Add("Amulet3");
          dwarf.preferred_weapons.Add("Amulet3");
          orc.preferred_weapons.Add("Amulet3");

human.preferred_weapons.Add("Amulet4");
          elf.preferred_weapons.Add("Amulet4");
          dwarf.preferred_weapons.Add("Amulet4");
          orc.preferred_weapons.Add("Amulet4");

human.preferred_weapons.Add("Amulet5");
          elf.preferred_weapons.Add("Amulet5");
          dwarf.preferred_weapons.Add("Amulet5");
          orc.preferred_weapons.Add("Amulet5");

human.preferred_weapons.Add("Amulet6");
          elf.preferred_weapons.Add("Amulet6");
          dwarf.preferred_weapons.Add("Amulet6");
          orc.preferred_weapons.Add("Amulet6");

human.preferred_weapons.Add("Amulet7");
          elf.preferred_weapons.Add("Amulet7");
          dwarf.preferred_weapons.Add("Amulet7");
          orc.preferred_weapons.Add("Amulet7");

human.preferred_weapons.Add("Amulet8");
          elf.preferred_weapons.Add("Amulet8");
          dwarf.preferred_weapons.Add("Amulet8");
          orc.preferred_weapons.Add("Amulet8");
         
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
