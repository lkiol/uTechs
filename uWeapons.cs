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
using ai;
using Beebyte.Obfuscator;

namespace TechsMod
{
    class uWeapons
    {
        public static void init()
        {
 
          craftitem();
//BonesProd
          ItemAsset BoneSword = AssetManager.items.clone("BoneSword", "sword");
          BoneSword.id = "BoneSword";
          BoneSword.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
          "sword_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"
          });
          BoneSword.materials = List.Of<string>(new string[]{"wood"});
          BoneSword.base_stats[S.attack_speed] = 25;
          BoneSword.base_stats[S.damage_range] = 1f;
          BoneSword.base_stats[S.damage] = 5;
/*
          BoneSword.base_stats[S.fertility] = 0.0f;
          BoneSword.base_stats[S.max_children] = 0f;
          BoneSword.base_stats[S.max_age] = 0f;
          BoneSword.base_stats[S.speed] = 0f;
          BoneSword.base_stats[S.health] = 0;
          BoneSword.base_stats[S.accuracy] = 0f;
          BoneSword.base_stats[S.range] = 0;
          BoneSword.base_stats[S.armor] = 0;
          BoneSword.base_stats[S.scale] = 0.0f;
          BoneSword.base_stats[S.dodge] = 0f;
          BoneSword.base_stats[S.targets] = 0f;
          BoneSword.base_stats[S.critical_chance] = 0.0f;
          BoneSword.base_stats[S.knockback] = 0.0f;
          BoneSword.base_stats[S.knockback_reduction] = 0.0f;
          BoneSword.base_stats[S.intelligence] = 0;
          BoneSword.base_stats[S.warfare] = 0;
          BoneSword.base_stats[S.diplomacy] = 0;
          BoneSword.base_stats[S.stewardship] = 0;
          BoneSword.base_stats[S.opinion] = 0f;
          BoneSword.base_stats[S.loyalty_traits] = 0f;
          BoneSword.base_stats[S.cities] = 0;
          BoneSword.base_stats[S.zone_range] = 0;
*/
          BoneSword.equipment_value = 50;
          BoneSword.quality = ItemQuality.Normal;
          BoneSword.path_slash_animation = "effects/slashes/slash_sword";
          BoneSword.tech_needed = "BonesandWood_production";
          BoneSword.equipmentType = EquipmentType.Weapon;
          BoneSword.name_class = "item_class_weapon";
          BoneSword.action_special_effect = new WorldAction(NoneRegularAction);
          //BoneSword.action_attack_target = new AttackAction(NoneAttackSomeoneAction *Flame*);
          AssetManager.items.list.AddItem(BoneSword);
          Localization.addLocalization("item_BoneSword", "Bone&Wood Sword");
          addWeaponsSprite(BoneSword.id, BoneSword.materials[0]);


          ItemAsset BoneAxe = AssetManager.items.clone("BoneAxe", "axe");
          BoneAxe.id = "BoneAxe";
          BoneAxe.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "axe_name#30",
          "axe_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"
          });
          BoneAxe.materials = List.Of<string>(new string[]{"wood"});
          BoneAxe.base_stats[S.attack_speed] = 30;
          //BoneAxe.base_stats[S.damage_range] = 5f;
          BoneAxe.base_stats[S.damage] = 5;
          BoneAxe.base_stats[S.speed] = 5f;
          BoneAxe.equipment_value = 50;
          BoneAxe.quality = ItemQuality.Normal;
          BoneAxe.path_slash_animation = "effects/slashes/slash_axe";
          BoneAxe.tech_needed = "BonesandWood_production";
          BoneAxe.equipmentType = EquipmentType.Weapon;
          BoneAxe.name_class = "item_class_weapon";
          BoneAxe.action_special_effect = new WorldAction(NoneRegularAction);
          //BoneAxe.action_attack_target = new AttackAction(NoneAttackSomeoneAction *Flame*);
          AssetManager.items.list.AddItem(BoneAxe);
          Localization.addLocalization("item_BoneAxe", "Bone&Wood Axe");
          addWeaponsSprite(BoneAxe.id, BoneAxe.materials[0]);


          ItemAsset BoneHammer = AssetManager.items.clone("BoneHammer", "hammer");
          BoneHammer.id = "BoneHammer";
          BoneHammer.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "hammer_name#30",
          "hammer_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"
          });
          BoneHammer.materials = List.Of<string>(new string[]{"wood"});
          BoneHammer.base_stats[S.attack_speed] = 15;
          //BoneHammer.base_stats[S.damage_range] = 15f;
          BoneHammer.base_stats[S.damage] = 4;
          BoneHammer.base_stats[S.speed] = -5f;
          BoneHammer.equipment_value = 50;
          BoneHammer.quality = ItemQuality.Normal;
          BoneHammer.path_slash_animation = "effects/slashes/slash_hammer";
          BoneHammer.tech_needed = "BonesandWood_production";
          BoneHammer.equipmentType = EquipmentType.Weapon;
          BoneHammer.name_class = "item_class_weapon";
          //BoneHammer.action_special_effect = new WorldAction(NoneRegularAction);
          //BoneAxe.action_attack_target = new AttackAction(NoneAttackSomeoneAction *Flame*);
          AssetManager.items.list.AddItem(BoneHammer);
          Localization.addLocalization("item_BoneHammer", "Bone&Wood Hammer");
          addWeaponsSprite(BoneHammer.id, BoneHammer.materials[0]);


          ItemAsset BoneSpear = AssetManager.items.clone("BoneSpear", "spear");
          BoneSpear.id = "BoneSpear";
          BoneSpear.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "spear_name#30",
          "spear_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"
          });
          BoneSpear.materials = List.Of<string>(new string[]{"wood"});
          BoneSpear.base_stats[S.attack_speed] = 20;
          //BoneSpear.base_stats[S.damage_range] = 20f;
          BoneSpear.base_stats[S.damage] = 5;
          BoneSpear.equipment_value = 50;
          BoneSpear.quality = ItemQuality.Normal;
          BoneSpear.path_slash_animation = "effects/slashes/slash_spear";
          BoneSpear.tech_needed = "BonesandWood_production";
          BoneSpear.equipmentType = EquipmentType.Weapon;
          BoneSpear.name_class = "item_class_weapon";
          //BoneSpear.action_special_effect = new WorldAction(NoneRegularAction);
          //BoneSpear.action_attack_target = new AttackAction(NoneAttackSomeoneAction *Flame*);
          AssetManager.items.list.AddItem(BoneSpear);
          Localization.addLocalization("item_BoneSpear", "Bone&Wood Spear");
          addWeaponsSprite(BoneSpear.id, BoneSpear.materials[0]);


          ItemAsset BoneBow = AssetManager.items.clone("BoneBow", "bow");
          BoneBow.id = "BoneBow";
          BoneBow.projectile = "arrow";
          BoneBow.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          BoneBow.materials = List.Of<string>(new string []{"wood"});
          BoneBow.base_stats[S.damage] = 5;
          BoneBow.base_stats[S.range] = 18;
          BoneBow.base_stats[S.attack_speed] = 12;
          BoneBow.base_stats[S.critical_chance] = 0.15f;
          BoneBow.equipment_value = 50;
          BoneBow.quality = ItemQuality.Normal;
          BoneBow.equipmentType = EquipmentType.Weapon;
          BoneBow.name_class = "item_class_weapon";
          BoneBow.path_slash_animation = "effects/slashes/slash_bow";
          BoneBow.tech_needed = "BonesandWood_production";
          AssetManager.items.list.AddItem(BoneBow);
          Localization.addLocalization("item_BoneBow", "Bone&Wood Bow");
          addWeaponsSprite(BoneBow.id, BoneBow.materials[0]);


          
//CrossbowProd------------------------------------------------------------------------------------------------


          ItemAsset WoodenCrossbow = AssetManager.items.clone("WoodenCrossbow", "bow");
          WoodenCrossbow.id = "WoodenCrossbow";
          WoodenCrossbow.projectile = "CrossbowArrow";
          WoodenCrossbow.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          WoodenCrossbow.materials = List.Of<string>(new string []{"wood"});
          WoodenCrossbow.base_stats[S.damage] = 13;
          WoodenCrossbow.base_stats[S.range] = 25;
          WoodenCrossbow.base_stats[S.attack_speed] = 10;
          WoodenCrossbow.base_stats[S.critical_chance] = 0.25f;
          WoodenCrossbow.equipment_value = 70;
          WoodenCrossbow.quality = ItemQuality.Normal;
          WoodenCrossbow.equipmentType = EquipmentType.Weapon;
          WoodenCrossbow.name_class = "item_class_weapon";
          WoodenCrossbow.path_slash_animation = "effects/slashes/slash_bow";
          WoodenCrossbow.tech_needed = "Crossbow_production";
          AssetManager.items.list.AddItem(WoodenCrossbow);
          Localization.addLocalization("item_WoodenCrossbow", "Wooden Crossbow");
          addWeaponsSprite(WoodenCrossbow.id, WoodenCrossbow.materials[0]);

ItemAsset CopperCrossbow = AssetManager.items.clone("CopperCrossbow", "bow");
          CopperCrossbow.id = "CopperCrossbow";
          CopperCrossbow.projectile = "CrossbowArrow";
          CopperCrossbow.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          CopperCrossbow.materials = List.Of<string>(new string []{"copper"});
          CopperCrossbow.base_stats[S.damage] = 14;
          CopperCrossbow.base_stats[S.range] = 25;
          CopperCrossbow.base_stats[S.attack_speed] = 10;
          CopperCrossbow.base_stats[S.critical_chance] = 0.26f;
          CopperCrossbow.equipment_value = 75;
          CopperCrossbow.quality = ItemQuality.Normal;
          CopperCrossbow.equipmentType = EquipmentType.Weapon;
          CopperCrossbow.name_class = "item_class_weapon";
          CopperCrossbow.path_slash_animation = "effects/slashes/slash_bow";
          CopperCrossbow.tech_needed = "Crossbow_production";
          AssetManager.items.list.AddItem(CopperCrossbow);
          Localization.addLocalization("item_CopperCrossbow", "Copper Crossbow");
          addWeaponsSprite(CopperCrossbow.id, CopperCrossbow.materials[0]);

ItemAsset BronzeCrossbow = AssetManager.items.clone("BronzeCrossbow", "bow");
          BronzeCrossbow.id = "BronzeCrossbow";
          BronzeCrossbow.projectile = "CrossbowArrow";
          BronzeCrossbow.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          BronzeCrossbow.materials = List.Of<string>(new string []{"bronze"});
          BronzeCrossbow.base_stats[S.damage] = 15;
          BronzeCrossbow.base_stats[S.range] = 25;
          BronzeCrossbow.base_stats[S.attack_speed] = 10;
          BronzeCrossbow.base_stats[S.critical_chance] = 0.27f;
          BronzeCrossbow.equipment_value = 80;
          BronzeCrossbow.quality = ItemQuality.Normal;
          BronzeCrossbow.equipmentType = EquipmentType.Weapon;
          BronzeCrossbow.name_class = "item_class_weapon";
          BronzeCrossbow.path_slash_animation = "effects/slashes/slash_bow";
          BronzeCrossbow.tech_needed = "Crossbow_production";
          AssetManager.items.list.AddItem(BronzeCrossbow);
          Localization.addLocalization("item_BronzeCrossbow", "Bronze Crossbow");
          addWeaponsSprite(BronzeCrossbow.id, BronzeCrossbow.materials[0]);

ItemAsset SilverCrossbow = AssetManager.items.clone("SilverCrossbow", "bow");
          SilverCrossbow.id = "SilverCrossbow";
          SilverCrossbow.projectile = "CrossbowArrow";
          SilverCrossbow.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          SilverCrossbow.materials = List.Of<string>(new string []{"silver"});
          SilverCrossbow.base_stats[S.damage] = 16;
          SilverCrossbow.base_stats[S.range] = 25;
          SilverCrossbow.base_stats[S.attack_speed] = 10;
          SilverCrossbow.base_stats[S.critical_chance] = 0.28f;
          SilverCrossbow.equipment_value = 85;
          SilverCrossbow.quality = ItemQuality.Normal;
          SilverCrossbow.equipmentType = EquipmentType.Weapon;
          SilverCrossbow.name_class = "item_class_weapon";
          SilverCrossbow.path_slash_animation = "effects/slashes/slash_bow";
          SilverCrossbow.tech_needed = "Crossbow_production";
          AssetManager.items.list.AddItem(SilverCrossbow);
          Localization.addLocalization("item_SilverCrossbow", "Silver Crossbow");
          addWeaponsSprite(SilverCrossbow.id, SilverCrossbow.materials[0]);

ItemAsset IronCrossbow = AssetManager.items.clone("IronCrossbow", "bow");
          IronCrossbow.id = "IronCrossbow";
          IronCrossbow.projectile = "CrossbowArrow";
          IronCrossbow.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          IronCrossbow.materials = List.Of<string>(new string []{"iron"});
          IronCrossbow.base_stats[S.damage] = 17;
          IronCrossbow.base_stats[S.range] = 25;
          IronCrossbow.base_stats[S.attack_speed] = 10;
          IronCrossbow.base_stats[S.critical_chance] = 0.29f;
          IronCrossbow.equipment_value = 90;
          IronCrossbow.quality = ItemQuality.Normal;
          IronCrossbow.equipmentType = EquipmentType.Weapon;
          IronCrossbow.name_class = "item_class_weapon";
          IronCrossbow.path_slash_animation = "effects/slashes/slash_bow";
          IronCrossbow.tech_needed = "Crossbow_production";
          AssetManager.items.list.AddItem(IronCrossbow);
          Localization.addLocalization("item_IronCrossbow", "Iron Crossbow");
          addWeaponsSprite(IronCrossbow.id, IronCrossbow.materials[0]);

ItemAsset SteelCrossbow = AssetManager.items.clone("SteelCrossbow", "bow");
          SteelCrossbow.id = "SteelCrossbow";
          SteelCrossbow.projectile = "CrossbowArrow";
          SteelCrossbow.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          SteelCrossbow.materials = List.Of<string>(new string []{"steel"});
          SteelCrossbow.base_stats[S.damage] = 18;
          SteelCrossbow.base_stats[S.range] = 25;
          SteelCrossbow.base_stats[S.attack_speed] = 10;
          SteelCrossbow.base_stats[S.critical_chance] = 0.30f;
          SteelCrossbow.equipment_value = 95;
          SteelCrossbow.quality = ItemQuality.Normal;
          SteelCrossbow.equipmentType = EquipmentType.Weapon;
          SteelCrossbow.name_class = "item_class_weapon";
          SteelCrossbow.path_slash_animation = "effects/slashes/slash_bow";
          SteelCrossbow.tech_needed = "Crossbow_production";
          AssetManager.items.list.AddItem(SteelCrossbow);
          Localization.addLocalization("item_SteelCrossbow", "Steel Crossbow");
          addWeaponsSprite(SteelCrossbow.id, SteelCrossbow.materials[0]);

ItemAsset MythrilCrossbow = AssetManager.items.clone("MythrilCrossbow", "bow");
          MythrilCrossbow.id = "MythrilCrossbow";
          MythrilCrossbow.projectile = "CrossbowArrow";
          MythrilCrossbow.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          MythrilCrossbow.materials = List.Of<string>(new string []{"mythril"});
          MythrilCrossbow.base_stats[S.damage] = 19;
          MythrilCrossbow.base_stats[S.range] = 25;
          MythrilCrossbow.base_stats[S.attack_speed] = 10;
          MythrilCrossbow.base_stats[S.critical_chance] = 0.31f;
          MythrilCrossbow.equipment_value = 100;
          MythrilCrossbow.quality = ItemQuality.Normal;
          MythrilCrossbow.equipmentType = EquipmentType.Weapon;
          MythrilCrossbow.name_class = "item_class_weapon";
          MythrilCrossbow.path_slash_animation = "effects/slashes/slash_bow";
          MythrilCrossbow.tech_needed = "Crossbow_production";
          AssetManager.items.list.AddItem(MythrilCrossbow);
          Localization.addLocalization("item_MythrilCrossbow", "Mythril Crossbow");
          addWeaponsSprite(MythrilCrossbow.id, MythrilCrossbow.materials[0]);

ItemAsset AdamantineCrossbow = AssetManager.items.clone("AdamantineCrossbow", "bow");
          AdamantineCrossbow.id = "AdamantineCrossbow";
          AdamantineCrossbow.projectile = "CrossbowArrow";
          AdamantineCrossbow.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          AdamantineCrossbow.materials = List.Of<string>(new string []{"adamantine"});
          AdamantineCrossbow.base_stats[S.damage] = 20;
          AdamantineCrossbow.base_stats[S.range] = 25;
          AdamantineCrossbow.base_stats[S.attack_speed] = 10;
          AdamantineCrossbow.base_stats[S.critical_chance] = 0.35f;
          AdamantineCrossbow.equipment_value = 105;
          AdamantineCrossbow.quality = ItemQuality.Normal;
          AdamantineCrossbow.equipmentType = EquipmentType.Weapon;
          AdamantineCrossbow.name_class = "item_class_weapon";
          AdamantineCrossbow.path_slash_animation = "effects/slashes/slash_bow";
          AdamantineCrossbow.tech_needed = "Crossbow_production";
          AssetManager.items.list.AddItem(AdamantineCrossbow);
          Localization.addLocalization("item_AdamantineCrossbow", "Adamantine Crossbow");
          addWeaponsSprite(AdamantineCrossbow.id, AdamantineCrossbow.materials[0]);

//MagicStaffFire------------------------------------------------------------------------------------------------

          ItemAsset WoodenFire1Staff = AssetManager.items.clone("WoodenFire1Staff", "bow");
          WoodenFire1Staff.id = "WoodenFire1Staff";
          WoodenFire1Staff.projectile = "FireProj";
          WoodenFire1Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          WoodenFire1Staff.materials = List.Of<string>(new string []{"wood"});
          WoodenFire1Staff.base_stats[S.damage] = 15;
          WoodenFire1Staff.base_stats[S.range] = 13;
          WoodenFire1Staff.base_stats[S.attack_speed] = 0;
          WoodenFire1Staff.base_stats[S.critical_chance] = 0.15f;
          WoodenFire1Staff.equipment_value = 100;
          WoodenFire1Staff.base_stats[S.projectiles] = 1;
          WoodenFire1Staff.quality = ItemQuality.Normal;
          WoodenFire1Staff.equipmentType = EquipmentType.Weapon;
          WoodenFire1Staff.name_class = "item_class_weapon";
          WoodenFire1Staff.action_special_effect = new WorldAction(NoneRegularAction);
          WoodenFire1Staff.action_attack_target = new AttackAction(Explosion1);
          WoodenFire1Staff.path_slash_animation = "effects/slashes/slash_bow";
          WoodenFire1Staff.tech_needed = "FireStaff";
          AssetManager.items.list.AddItem(WoodenFire1Staff);
          Localization.addLocalization("item_WoodenFire1Staff", "Wooden Fire Staff I");
          addWeaponsSprite(WoodenFire1Staff.id, WoodenFire1Staff.materials[0]);

          ItemAsset CopperFire2Staff = AssetManager.items.clone("CopperFire2Staff", "bow");
          CopperFire2Staff.id = "CopperFire2Staff";
          CopperFire2Staff.projectile = "FireProj";
          CopperFire2Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          CopperFire2Staff.materials = List.Of<string>(new string []{"copper"});
          CopperFire2Staff.base_stats[S.damage] = 16;
          CopperFire2Staff.base_stats[S.range] = 14;
          CopperFire2Staff.base_stats[S.attack_speed] = 0;
          CopperFire2Staff.base_stats[S.critical_chance] = 0.20f;
          CopperFire2Staff.equipment_value = 110;
          CopperFire2Staff.base_stats[S.projectiles] = 1;
          CopperFire2Staff.quality = ItemQuality.Normal;
          CopperFire2Staff.equipmentType = EquipmentType.Weapon;
          CopperFire2Staff.name_class = "item_class_weapon";
          CopperFire2Staff.action_special_effect = new WorldAction(NoneRegularAction);
          CopperFire2Staff.action_attack_target = new AttackAction(Explosion2);
          CopperFire2Staff.path_slash_animation = "effects/slashes/slash_bow";
          CopperFire2Staff.tech_needed = "FireStaff";
          AssetManager.items.list.AddItem(CopperFire2Staff);
          Localization.addLocalization("item_CopperFire2Staff", "Copper Fire Staff II");
          addWeaponsSprite(CopperFire2Staff.id, CopperFire2Staff.materials[0]);

          ItemAsset BronzeFire3Staff = AssetManager.items.clone("BronzeFire3Staff", "bow");
          BronzeFire3Staff.id = "BronzeFire3Staff";
          BronzeFire3Staff.projectile = "FireProj";
          BronzeFire3Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          BronzeFire3Staff.materials = List.Of<string>(new string []{"bronze"});
          BronzeFire3Staff.base_stats[S.damage] = 17;
          BronzeFire3Staff.base_stats[S.range] = 14;
          BronzeFire3Staff.base_stats[S.attack_speed] = 0;
          BronzeFire3Staff.base_stats[S.critical_chance] = 0.25f;
          BronzeFire3Staff.equipment_value = 120;
          BronzeFire3Staff.base_stats[S.projectiles] = 1;
          BronzeFire3Staff.quality = ItemQuality.Normal;
          BronzeFire3Staff.equipmentType = EquipmentType.Weapon;
          BronzeFire3Staff.name_class = "item_class_weapon";
          BronzeFire3Staff.action_special_effect = new WorldAction(NoneRegularAction);
          BronzeFire3Staff.action_attack_target = new AttackAction(Explosion3);
          BronzeFire3Staff.path_slash_animation = "effects/slashes/slash_bow";
          BronzeFire3Staff.tech_needed = "FireStaff";
          AssetManager.items.list.AddItem(BronzeFire3Staff);
          Localization.addLocalization("item_BronzeFire3Staff", "Bronze Fire Staff III");
          addWeaponsSprite(BronzeFire3Staff.id, BronzeFire3Staff.materials[0]);

          ItemAsset SilverFire4Staff = AssetManager.items.clone("SilverFire4Staff", "bow");
          SilverFire4Staff.id = "SilverFire4Staff";
          SilverFire4Staff.projectile = "FireProj";
          SilverFire4Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          SilverFire4Staff.materials = List.Of<string>(new string []{"silver"});
          SilverFire4Staff.base_stats[S.damage] = 18;
          SilverFire4Staff.base_stats[S.range] = 14;
          SilverFire4Staff.base_stats[S.attack_speed] = 0;
          SilverFire4Staff.base_stats[S.critical_chance] = 0.30f;
          SilverFire4Staff.equipment_value = 130;
          SilverFire4Staff.base_stats[S.projectiles] = 1;
          SilverFire4Staff.quality = ItemQuality.Normal;
          SilverFire4Staff.equipmentType = EquipmentType.Weapon;
          SilverFire4Staff.name_class = "item_class_weapon";
          SilverFire4Staff.action_special_effect = new WorldAction(NoneRegularAction);
          SilverFire4Staff.action_attack_target = new AttackAction(Explosion4);
          SilverFire4Staff.path_slash_animation = "effects/slashes/slash_bow";
          SilverFire4Staff.tech_needed = "FireStaff";
          AssetManager.items.list.AddItem(SilverFire4Staff);
          Localization.addLocalization("item_SilverFire4Staff", "Silver Fire Staff IV");
          addWeaponsSprite(SilverFire4Staff.id, SilverFire4Staff.materials[0]);

          ItemAsset IronFire5Staff = AssetManager.items.clone("IronFire5Staff", "bow");
          IronFire5Staff.id = "IronFire5Staff";
          IronFire5Staff.projectile = "FireProj";
          IronFire5Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          IronFire5Staff.materials = List.Of<string>(new string []{"iron"});
          IronFire5Staff.base_stats[S.damage] = 19;
          IronFire5Staff.base_stats[S.range] = 15;
          IronFire5Staff.base_stats[S.attack_speed] = 0;
          IronFire5Staff.base_stats[S.critical_chance] = 0.35f;
          IronFire5Staff.equipment_value = 140;
          IronFire5Staff.base_stats[S.projectiles] = 1;
          IronFire5Staff.quality = ItemQuality.Normal;
          IronFire5Staff.equipmentType = EquipmentType.Weapon;
          IronFire5Staff.name_class = "item_class_weapon";
          IronFire5Staff.action_special_effect = new WorldAction(NoneRegularAction);
          IronFire5Staff.action_attack_target = new AttackAction(Explosion5);
          IronFire5Staff.path_slash_animation = "effects/slashes/slash_bow";
          IronFire5Staff.tech_needed = "FireStaff";
          AssetManager.items.list.AddItem(IronFire5Staff);
          Localization.addLocalization("item_IronFire5Staff", "Iron Fire Staff V");
          addWeaponsSprite(IronFire5Staff.id, IronFire5Staff.materials[0]);
          
          ItemAsset SteelFire6Staff = AssetManager.items.clone("SteelFire6Staff", "bow");
          SteelFire6Staff.id = "SteelFire6Staff";
          SteelFire6Staff.projectile = "FireProj";
          SteelFire6Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          SteelFire6Staff.materials = List.Of<string>(new string []{"steel"});
          SteelFire6Staff.base_stats[S.damage] = 20;
          SteelFire6Staff.base_stats[S.range] = 16;
          SteelFire6Staff.base_stats[S.attack_speed] = 0;
          SteelFire6Staff.base_stats[S.critical_chance] = 0.40f;
          SteelFire6Staff.equipment_value = 150;
          SteelFire6Staff.base_stats[S.projectiles] = 1;
          SteelFire6Staff.quality = ItemQuality.Normal;
          SteelFire6Staff.equipmentType = EquipmentType.Weapon;
          SteelFire6Staff.name_class = "item_class_weapon";
          SteelFire6Staff.action_special_effect = new WorldAction(NoneRegularAction);
          SteelFire6Staff.action_attack_target = new AttackAction(Explosion6);
          SteelFire6Staff.path_slash_animation = "effects/slashes/slash_bow";
          SteelFire6Staff.tech_needed = "FireStaff";
          AssetManager.items.list.AddItem(SteelFire6Staff);
          Localization.addLocalization("item_SteelFire6Staff", "Steel Fire Staff VI");
          addWeaponsSprite(SteelFire6Staff.id, SteelFire6Staff.materials[0]);

          ItemAsset MythrilFire7Staff = AssetManager.items.clone("MythrilFire7Staff", "bow");
          MythrilFire7Staff.id = "MythrilFire7Staff";
          MythrilFire7Staff.projectile = "FireProj";
          MythrilFire7Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          MythrilFire7Staff.materials = List.Of<string>(new string []{"mythril"});
          MythrilFire7Staff.base_stats[S.damage] = 22;
          MythrilFire7Staff.base_stats[S.range] = 17;
          MythrilFire7Staff.base_stats[S.attack_speed] = 0;
          MythrilFire7Staff.base_stats[S.critical_chance] = 0.45f;
          MythrilFire7Staff.equipment_value = 160;
          MythrilFire7Staff.base_stats[S.projectiles] = 2;
          MythrilFire7Staff.quality = ItemQuality.Normal;
          MythrilFire7Staff.equipmentType = EquipmentType.Weapon;
          MythrilFire7Staff.name_class = "item_class_weapon";
          MythrilFire7Staff.action_special_effect = new WorldAction(NoneRegularAction);
          MythrilFire7Staff.action_attack_target = new AttackAction(Explosion7);
          MythrilFire7Staff.path_slash_animation = "effects/slashes/slash_bow";
          MythrilFire7Staff.tech_needed = "FireStaff";
          AssetManager.items.list.AddItem(MythrilFire7Staff);
          Localization.addLocalization("item_MythrilFire7Staff", "Mythril Fire Staff VII");
          addWeaponsSprite(MythrilFire7Staff.id, MythrilFire7Staff.materials[0]);

          ItemAsset AdamantineFire8Staff = AssetManager.items.clone("AdamantineFire8Staff", "bow");
          AdamantineFire8Staff.id = "AdamantineFire8Staff";
          AdamantineFire8Staff.projectile = "FireProj";
          AdamantineFire8Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          AdamantineFire8Staff.materials = List.Of<string>(new string []{"adamantine"});
          AdamantineFire8Staff.base_stats[S.damage] = 22;
          AdamantineFire8Staff.base_stats[S.range] = 18;
          //AdamantineFire8Staff.base_stats[S.attack_speed] = 0;
          AdamantineFire8Staff.base_stats[S.critical_chance] = 0.45f;
          AdamantineFire8Staff.equipment_value = 160;
          AdamantineFire8Staff.base_stats[S.projectiles] = 3;
          AdamantineFire8Staff.quality = ItemQuality.Normal;
          AdamantineFire8Staff.equipmentType = EquipmentType.Weapon;
          AdamantineFire8Staff.name_class = "item_class_weapon";
          AdamantineFire8Staff.action_special_effect = new WorldAction(NoneRegularAction);
          AdamantineFire8Staff.action_attack_target = new AttackAction(Explosion8);
          AdamantineFire8Staff.path_slash_animation = "effects/slashes/slash_bow";
          AdamantineFire8Staff.tech_needed = "FireStaff";
          AssetManager.items.list.AddItem(AdamantineFire8Staff);
          Localization.addLocalization("item_AdamantineFire8Staff", "Adamantine Fire Staff VIII");
          addWeaponsSprite(AdamantineFire8Staff.id, AdamantineFire8Staff.materials[0]);

 //MagicStaffThunder------------------------------------------------------------------------------------------------

          ItemAsset WoodenThunder1Staff = AssetManager.items.clone("WoodenThunder1Staff", "bow");
          WoodenThunder1Staff.id = "WoodenThunder1Staff";
          WoodenThunder1Staff.projectile = "ThunderProj";
          WoodenThunder1Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          WoodenThunder1Staff.materials = List.Of<string>(new string []{"wood"});
          WoodenThunder1Staff.base_stats[S.damage] = 15;
          WoodenThunder1Staff.base_stats[S.range] = 13;
          WoodenThunder1Staff.base_stats[S.attack_speed] = 0;
          WoodenThunder1Staff.base_stats[S.critical_chance] = 0.15f;
          WoodenThunder1Staff.equipment_value = 100;
          WoodenThunder1Staff.base_stats[S.projectiles] = 1;
          WoodenThunder1Staff.quality = ItemQuality.Normal;
          WoodenThunder1Staff.equipmentType = EquipmentType.Weapon;
          WoodenThunder1Staff.name_class = "item_class_weapon";
          WoodenThunder1Staff.action_special_effect = new WorldAction(NoneRegularAction);
          WoodenThunder1Staff.action_attack_target = new AttackAction(ThunderSmall);
          WoodenThunder1Staff.path_slash_animation = "effects/slashes/slash_bow";
          WoodenThunder1Staff.tech_needed = "ThunderStaff";
          AssetManager.items.list.AddItem(WoodenThunder1Staff);
          Localization.addLocalization("item_WoodenThunder1Staff", "Wooden Thunder Staff I");
          addWeaponsSprite(WoodenThunder1Staff.id, WoodenThunder1Staff.materials[0]);

          ItemAsset CopperThunder2Staff = AssetManager.items.clone("CopperThunder2Staff", "bow");
          CopperThunder2Staff.id = "CopperThunder2Staff";
          CopperThunder2Staff.projectile = "ThunderProj";
          CopperThunder2Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          CopperThunder2Staff.materials = List.Of<string>(new string []{"copper"});
          CopperThunder2Staff.base_stats[S.damage] = 16;
          CopperThunder2Staff.base_stats[S.range] = 14;
          CopperThunder2Staff.base_stats[S.attack_speed] = 0;
          CopperThunder2Staff.base_stats[S.critical_chance] = 0.20f;
          CopperThunder2Staff.equipment_value = 110;
          CopperThunder2Staff.base_stats[S.projectiles] = 1;
          CopperThunder2Staff.quality = ItemQuality.Normal;
          CopperThunder2Staff.equipmentType = EquipmentType.Weapon;
          CopperThunder2Staff.name_class = "item_class_weapon";
          CopperThunder2Staff.action_special_effect = new WorldAction(NoneRegularAction);
          CopperThunder2Staff.action_attack_target = new AttackAction(ThunderSmall);
          CopperThunder2Staff.path_slash_animation = "effects/slashes/slash_bow";
          CopperThunder2Staff.tech_needed = "ThunderStaff";
          AssetManager.items.list.AddItem(CopperThunder2Staff);
          Localization.addLocalization("item_CopperThunder2Staff", "Copper Thunder Staff II");
          addWeaponsSprite(CopperThunder2Staff.id, CopperThunder2Staff.materials[0]);

          ItemAsset BronzeThunder3Staff = AssetManager.items.clone("BronzeThunder3Staff", "bow");
          BronzeThunder3Staff.id = "BronzeThunder3Staff";
          BronzeThunder3Staff.projectile = "ThunderProj";
          BronzeThunder3Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          BronzeThunder3Staff.materials = List.Of<string>(new string []{"bronze"});
          BronzeThunder3Staff.base_stats[S.damage] = 17;
          BronzeThunder3Staff.base_stats[S.range] = 14;
          BronzeThunder3Staff.base_stats[S.attack_speed] = 0;
          BronzeThunder3Staff.base_stats[S.critical_chance] = 0.25f;
          BronzeThunder3Staff.equipment_value = 120;
          BronzeThunder3Staff.base_stats[S.projectiles] = 1;
          BronzeThunder3Staff.quality = ItemQuality.Normal;
          BronzeThunder3Staff.equipmentType = EquipmentType.Weapon;
          BronzeThunder3Staff.name_class = "item_class_weapon";
          BronzeThunder3Staff.action_special_effect = new WorldAction(NoneRegularAction);
          BronzeThunder3Staff.action_attack_target = new AttackAction(ThunderSmall);
          BronzeThunder3Staff.path_slash_animation = "effects/slashes/slash_bow";
          BronzeThunder3Staff.tech_needed = "ThunderStaff";
          AssetManager.items.list.AddItem(BronzeThunder3Staff);
          Localization.addLocalization("item_BronzeThunder3Staff", "Bronze Thunder Staff III");
          addWeaponsSprite(BronzeThunder3Staff.id, BronzeThunder3Staff.materials[0]);

          ItemAsset SilverThunder4Staff = AssetManager.items.clone("SilverThunder4Staff", "bow");
          SilverThunder4Staff.id = "SilverThunder4Staff";
          SilverThunder4Staff.projectile = "ThunderProj";
          SilverThunder4Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          SilverThunder4Staff.materials = List.Of<string>(new string []{"silver"});
          SilverThunder4Staff.base_stats[S.damage] = 18;
          SilverThunder4Staff.base_stats[S.range] = 14;
          SilverThunder4Staff.base_stats[S.attack_speed] = 0;
          SilverThunder4Staff.base_stats[S.critical_chance] = 0.30f;
          SilverThunder4Staff.equipment_value = 130;
          SilverThunder4Staff.base_stats[S.projectiles] = 1;
          SilverThunder4Staff.quality = ItemQuality.Normal;
          SilverThunder4Staff.equipmentType = EquipmentType.Weapon;
          SilverThunder4Staff.name_class = "item_class_weapon";
          SilverThunder4Staff.action_special_effect = new WorldAction(NoneRegularAction);
          SilverThunder4Staff.action_attack_target = new AttackAction(ThunderSmall);
          SilverThunder4Staff.path_slash_animation = "effects/slashes/slash_bow";
          SilverThunder4Staff.tech_needed = "ThunderStaff";
          AssetManager.items.list.AddItem(SilverThunder4Staff);
          Localization.addLocalization("item_SilverThunder4Staff", "Silver Thunder Staff IV");
          addWeaponsSprite(SilverThunder4Staff.id, SilverThunder4Staff.materials[0]);

          ItemAsset IronThunder5Staff = AssetManager.items.clone("IronThunder5Staff", "bow");
          IronThunder5Staff.id = "IronThunder5Staff";
          IronThunder5Staff.projectile = "ThunderProj";
          IronThunder5Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          IronThunder5Staff.materials = List.Of<string>(new string []{"iron"});
          IronThunder5Staff.base_stats[S.damage] = 19;
          IronThunder5Staff.base_stats[S.range] = 15;
          IronThunder5Staff.base_stats[S.attack_speed] = 0;
          IronThunder5Staff.base_stats[S.critical_chance] = 0.35f;
          IronThunder5Staff.equipment_value = 140;
          IronThunder5Staff.base_stats[S.projectiles] = 1;
          IronThunder5Staff.quality = ItemQuality.Normal;
          IronThunder5Staff.equipmentType = EquipmentType.Weapon;
          IronThunder5Staff.name_class = "item_class_weapon";
          IronThunder5Staff.action_special_effect = new WorldAction(NoneRegularAction);
          IronThunder5Staff.action_attack_target = new AttackAction(ThunderMedium);
          IronThunder5Staff.path_slash_animation = "effects/slashes/slash_bow";
          IronThunder5Staff.tech_needed = "ThunderStaff";
          AssetManager.items.list.AddItem(IronThunder5Staff);
          Localization.addLocalization("item_IronThunder5Staff", "Iron Thunder Staff V");
          addWeaponsSprite(IronThunder5Staff.id, IronThunder5Staff.materials[0]);
          
          ItemAsset SteelThunder6Staff = AssetManager.items.clone("SteelThunder6Staff", "bow");
          SteelThunder6Staff.id = "SteelThunder6Staff";
          SteelThunder6Staff.projectile = "ThunderProj";
          SteelThunder6Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          SteelThunder6Staff.materials = List.Of<string>(new string []{"steel"});
          SteelThunder6Staff.base_stats[S.damage] = 20;
          SteelThunder6Staff.base_stats[S.range] = 16;
          SteelThunder6Staff.base_stats[S.attack_speed] = 0;
          SteelThunder6Staff.base_stats[S.critical_chance] = 0.40f;
          SteelThunder6Staff.equipment_value = 150;
          SteelThunder6Staff.base_stats[S.projectiles] = 1;
          SteelThunder6Staff.quality = ItemQuality.Normal;
          SteelThunder6Staff.equipmentType = EquipmentType.Weapon;
          SteelThunder6Staff.name_class = "item_class_weapon";
          SteelThunder6Staff.action_special_effect = new WorldAction(NoneRegularAction);
          SteelThunder6Staff.action_attack_target = new AttackAction(ThunderMedium);
          SteelThunder6Staff.path_slash_animation = "effects/slashes/slash_bow";
          SteelThunder6Staff.tech_needed = "ThunderStaff";
          AssetManager.items.list.AddItem(SteelThunder6Staff);
          Localization.addLocalization("item_SteelThunder6Staff", "Steel Thunder Staff VI");
          addWeaponsSprite(SteelThunder6Staff.id, SteelThunder6Staff.materials[0]);

          ItemAsset MythrilThunder7Staff = AssetManager.items.clone("MythrilThunder7Staff", "bow");
          MythrilThunder7Staff.id = "MythrilThunder7Staff";
          MythrilThunder7Staff.projectile = "ThunderProj";
          MythrilThunder7Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          MythrilThunder7Staff.materials = List.Of<string>(new string []{"mythril"});
          MythrilThunder7Staff.base_stats[S.damage] = 22;
          MythrilThunder7Staff.base_stats[S.range] = 17;
          MythrilThunder7Staff.base_stats[S.attack_speed] = 0;
          MythrilThunder7Staff.base_stats[S.critical_chance] = 0.45f;
          MythrilThunder7Staff.equipment_value = 160;
          MythrilThunder7Staff.base_stats[S.projectiles] = 2;
          MythrilThunder7Staff.quality = ItemQuality.Normal;
          MythrilThunder7Staff.equipmentType = EquipmentType.Weapon;
          MythrilThunder7Staff.name_class = "item_class_weapon";
          MythrilThunder7Staff.action_special_effect = new WorldAction(NoneRegularAction);
          MythrilThunder7Staff.action_attack_target = new AttackAction(ThunderBig);
          MythrilThunder7Staff.path_slash_animation = "effects/slashes/slash_bow";
          MythrilThunder7Staff.tech_needed = "ThunderStaff";
          AssetManager.items.list.AddItem(MythrilThunder7Staff);
          Localization.addLocalization("item_MythrilThunder7Staff", "Mythril Thunder Staff VII");
          addWeaponsSprite(MythrilThunder7Staff.id, MythrilThunder7Staff.materials[0]);

          ItemAsset AdamantineThunder8Staff = AssetManager.items.clone("AdamantineThunder8Staff", "bow");
          AdamantineThunder8Staff.id = "AdamantineThunder8Staff";
          AdamantineThunder8Staff.projectile = "ThunderProj";
          AdamantineThunder8Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          AdamantineThunder8Staff.materials = List.Of<string>(new string []{"adamantine"});
          AdamantineThunder8Staff.base_stats[S.damage] = 22;
          AdamantineThunder8Staff.base_stats[S.range] = 18;
          //AdamantineThunder8Staff.base_stats[S.attack_speed] = 0;
          AdamantineThunder8Staff.base_stats[S.critical_chance] = 0.45f;
          AdamantineThunder8Staff.equipment_value = 160;
          AdamantineThunder8Staff.base_stats[S.projectiles] = 3;
          AdamantineThunder8Staff.quality = ItemQuality.Normal;
          AdamantineThunder8Staff.equipmentType = EquipmentType.Weapon;
          AdamantineThunder8Staff.name_class = "item_class_weapon";
          AdamantineThunder8Staff.action_special_effect = new WorldAction(NoneRegularAction);
          AdamantineThunder8Staff.action_attack_target = new AttackAction(ThunderBig);
          AdamantineThunder8Staff.path_slash_animation = "effects/slashes/slash_bow";
          AdamantineThunder8Staff.tech_needed = "ThunderStaff";
          AssetManager.items.list.AddItem(AdamantineThunder8Staff);
          Localization.addLocalization("item_AdamantineThunder8Staff", "Adamantine Thunder Staff VIII");
          addWeaponsSprite(AdamantineThunder8Staff.id, AdamantineThunder8Staff.materials[0]);


//MagicStaffFrost------------------------------------------------------------------------------------------------

          ItemAsset WoodenFrost1Staff = AssetManager.items.clone("WoodenFrost1Staff", "bow");
          WoodenFrost1Staff.id = "WoodenFrost1Staff";
          WoodenFrost1Staff.projectile = "FrostProj";
          WoodenFrost1Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          WoodenFrost1Staff.materials = List.Of<string>(new string []{"wood"});
          WoodenFrost1Staff.base_stats[S.damage] = 15;
          WoodenFrost1Staff.base_stats[S.range] = 13;
          WoodenFrost1Staff.base_stats[S.attack_speed] = 0;
          WoodenFrost1Staff.base_stats[S.critical_chance] = 0.15f;
          WoodenFrost1Staff.equipment_value = 100;
          WoodenFrost1Staff.base_stats[S.projectiles] = 1;
          WoodenFrost1Staff.quality = ItemQuality.Normal;
          WoodenFrost1Staff.equipmentType = EquipmentType.Weapon;
          WoodenFrost1Staff.name_class = "item_class_weapon";
          WoodenFrost1Staff.action_special_effect = new WorldAction(NoneRegularAction);
          WoodenFrost1Staff.action_attack_target = new AttackAction(Tornado1);
          WoodenFrost1Staff.path_slash_animation = "effects/slashes/slash_bow";
          WoodenFrost1Staff.tech_needed = "FrostStaff";
          AssetManager.items.list.AddItem(WoodenFrost1Staff);
          Localization.addLocalization("item_WoodenFrost1Staff", "Wooden Frost Staff I");
          addWeaponsSprite(WoodenFrost1Staff.id, WoodenFrost1Staff.materials[0]);

          ItemAsset CopperFrost2Staff = AssetManager.items.clone("CopperFrost2Staff", "bow");
          CopperFrost2Staff.id = "CopperFrost2Staff";
          CopperFrost2Staff.projectile = "FrostProj";
          CopperFrost2Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          CopperFrost2Staff.materials = List.Of<string>(new string []{"copper"});
          CopperFrost2Staff.base_stats[S.damage] = 16;
          CopperFrost2Staff.base_stats[S.range] = 14;
          CopperFrost2Staff.base_stats[S.attack_speed] = 0;
          CopperFrost2Staff.base_stats[S.critical_chance] = 0.20f;
          CopperFrost2Staff.equipment_value = 110;
          CopperFrost2Staff.base_stats[S.projectiles] = 1;
          CopperFrost2Staff.quality = ItemQuality.Normal;
          CopperFrost2Staff.equipmentType = EquipmentType.Weapon;
          CopperFrost2Staff.name_class = "item_class_weapon";
          CopperFrost2Staff.action_special_effect = new WorldAction(NoneRegularAction);
          CopperFrost2Staff.action_attack_target = new AttackAction(Tornado1);
          CopperFrost2Staff.path_slash_animation = "effects/slashes/slash_bow";
          CopperFrost2Staff.tech_needed = "FrostStaff";
          AssetManager.items.list.AddItem(CopperFrost2Staff);
          Localization.addLocalization("item_CopperFrost2Staff", "Copper Frost Staff II");
          addWeaponsSprite(CopperFrost2Staff.id, CopperFrost2Staff.materials[0]);

          ItemAsset BronzeFrost3Staff = AssetManager.items.clone("BronzeFrost3Staff", "bow");
          BronzeFrost3Staff.id = "BronzeFrost3Staff";
          BronzeFrost3Staff.projectile = "FrostProj";
          BronzeFrost3Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          BronzeFrost3Staff.materials = List.Of<string>(new string []{"bronze"});
          BronzeFrost3Staff.base_stats[S.damage] = 17;
          BronzeFrost3Staff.base_stats[S.range] = 14;
          BronzeFrost3Staff.base_stats[S.attack_speed] = 0;
          BronzeFrost3Staff.base_stats[S.critical_chance] = 0.25f;
          BronzeFrost3Staff.equipment_value = 120;
          BronzeFrost3Staff.base_stats[S.projectiles] = 1;
          BronzeFrost3Staff.quality = ItemQuality.Normal;
          BronzeFrost3Staff.equipmentType = EquipmentType.Weapon;
          BronzeFrost3Staff.name_class = "item_class_weapon";
          BronzeFrost3Staff.action_special_effect = new WorldAction(NoneRegularAction);
          BronzeFrost3Staff.action_attack_target = new AttackAction(Tornado1);
          BronzeFrost3Staff.path_slash_animation = "effects/slashes/slash_bow";
          BronzeFrost3Staff.tech_needed = "FrostStaff";
          AssetManager.items.list.AddItem(BronzeFrost3Staff);
          Localization.addLocalization("item_BronzeFrost3Staff", "Bronze Frost Staff III");
          addWeaponsSprite(BronzeFrost3Staff.id, BronzeFrost3Staff.materials[0]);

          ItemAsset SilverFrost4Staff = AssetManager.items.clone("SilverFrost4Staff", "bow");
          SilverFrost4Staff.id = "SilverFrost4Staff";
          SilverFrost4Staff.projectile = "FrostProj";
          SilverFrost4Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          SilverFrost4Staff.materials = List.Of<string>(new string []{"silver"});
          SilverFrost4Staff.base_stats[S.damage] = 18;
          SilverFrost4Staff.base_stats[S.range] = 14;
          SilverFrost4Staff.base_stats[S.attack_speed] = 0;
          SilverFrost4Staff.base_stats[S.critical_chance] = 0.30f;
          SilverFrost4Staff.equipment_value = 130;
          SilverFrost4Staff.base_stats[S.projectiles] = 1;
          SilverFrost4Staff.quality = ItemQuality.Normal;
          SilverFrost4Staff.equipmentType = EquipmentType.Weapon;
          SilverFrost4Staff.name_class = "item_class_weapon";
          SilverFrost4Staff.action_special_effect = new WorldAction(NoneRegularAction);
          SilverFrost4Staff.action_attack_target = new AttackAction(Tornado1);
          SilverFrost4Staff.path_slash_animation = "effects/slashes/slash_bow";
          SilverFrost4Staff.tech_needed = "FrostStaff";
          AssetManager.items.list.AddItem(SilverFrost4Staff);
          Localization.addLocalization("item_SilverFrost4Staff", "Silver Frost Staff IV");
          addWeaponsSprite(SilverFrost4Staff.id, SilverFrost4Staff.materials[0]);

          ItemAsset IronFrost5Staff = AssetManager.items.clone("IronFrost5Staff", "bow");
          IronFrost5Staff.id = "IronFrost5Staff";
          IronFrost5Staff.projectile = "FrostProj";
          IronFrost5Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          IronFrost5Staff.materials = List.Of<string>(new string []{"iron"});
          IronFrost5Staff.base_stats[S.damage] = 19;
          IronFrost5Staff.base_stats[S.range] = 15;
          IronFrost5Staff.base_stats[S.attack_speed] = 0;
          IronFrost5Staff.base_stats[S.critical_chance] = 0.35f;
          IronFrost5Staff.equipment_value = 140;
          IronFrost5Staff.base_stats[S.projectiles] = 1;
          IronFrost5Staff.quality = ItemQuality.Normal;
          IronFrost5Staff.equipmentType = EquipmentType.Weapon;
          IronFrost5Staff.name_class = "item_class_weapon";
          IronFrost5Staff.action_special_effect = new WorldAction(NoneRegularAction);
          IronFrost5Staff.action_attack_target = new AttackAction(Tornado2);
          IronFrost5Staff.path_slash_animation = "effects/slashes/slash_bow";
          IronFrost5Staff.tech_needed = "FrostStaff";
          AssetManager.items.list.AddItem(IronFrost5Staff);
          Localization.addLocalization("item_IronFrost5Staff", "Iron Frost Staff V");
          addWeaponsSprite(IronFrost5Staff.id, IronFrost5Staff.materials[0]);
          
          ItemAsset SteelFrost6Staff = AssetManager.items.clone("SteelFrost6Staff", "bow");
          SteelFrost6Staff.id = "SteelFrost6Staff";
          SteelFrost6Staff.projectile = "FrostProj";
          SteelFrost6Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          SteelFrost6Staff.materials = List.Of<string>(new string []{"steel"});
          SteelFrost6Staff.base_stats[S.damage] = 20;
          SteelFrost6Staff.base_stats[S.range] = 16;
          SteelFrost6Staff.base_stats[S.attack_speed] = 0;
          SteelFrost6Staff.base_stats[S.critical_chance] = 0.40f;
          SteelFrost6Staff.equipment_value = 150;
          SteelFrost6Staff.base_stats[S.projectiles] = 1;
          SteelFrost6Staff.quality = ItemQuality.Normal;
          SteelFrost6Staff.equipmentType = EquipmentType.Weapon;
          SteelFrost6Staff.name_class = "item_class_weapon";
          SteelFrost6Staff.action_special_effect = new WorldAction(NoneRegularAction);
          SteelFrost6Staff.action_attack_target = new AttackAction(Tornado2);
          SteelFrost6Staff.path_slash_animation = "effects/slashes/slash_bow";
          SteelFrost6Staff.tech_needed = "FrostStaff";
          AssetManager.items.list.AddItem(SteelFrost6Staff);
          Localization.addLocalization("item_SteelFrost6Staff", "Steel Frost Staff VI");
          addWeaponsSprite(SteelFrost6Staff.id, SteelFrost6Staff.materials[0]);

          ItemAsset MythrilFrost7Staff = AssetManager.items.clone("MythrilFrost7Staff", "bow");
          MythrilFrost7Staff.id = "MythrilFrost7Staff";
          MythrilFrost7Staff.projectile = "FrostProj";
          MythrilFrost7Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          MythrilFrost7Staff.materials = List.Of<string>(new string []{"mythril"});
          MythrilFrost7Staff.base_stats[S.damage] = 22;
          MythrilFrost7Staff.base_stats[S.range] = 17;
          MythrilFrost7Staff.base_stats[S.attack_speed] = 0;
          MythrilFrost7Staff.base_stats[S.critical_chance] = 0.45f;
          MythrilFrost7Staff.equipment_value = 160;
          MythrilFrost7Staff.base_stats[S.projectiles] = 2;
          MythrilFrost7Staff.quality = ItemQuality.Normal;
          MythrilFrost7Staff.equipmentType = EquipmentType.Weapon;
          MythrilFrost7Staff.name_class = "item_class_weapon";
          MythrilFrost7Staff.action_special_effect = new WorldAction(NoneRegularAction);
          MythrilFrost7Staff.action_attack_target = new AttackAction(Tornado3);
          MythrilFrost7Staff.path_slash_animation = "effects/slashes/slash_bow";
          MythrilFrost7Staff.tech_needed = "FrostStaff";
          AssetManager.items.list.AddItem(MythrilFrost7Staff);
          Localization.addLocalization("item_MythrilFrost7Staff", "Mythril Frost Staff VII");
          addWeaponsSprite(MythrilFrost7Staff.id, MythrilFrost7Staff.materials[0]);

          ItemAsset AdamantineFrost8Staff = AssetManager.items.clone("AdamantineFrost8Staff", "bow");
          AdamantineFrost8Staff.id = "AdamantineFrost8Staff";
          AdamantineFrost8Staff.projectile = "FrostProj";
          AdamantineFrost8Staff.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "bow_name#30",
          "bow_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          AdamantineFrost8Staff.materials = List.Of<string>(new string []{"adamantine"});
          AdamantineFrost8Staff.base_stats[S.damage] = 22;
          AdamantineFrost8Staff.base_stats[S.range] = 18;
          //AdamantineFrost8Staff.base_stats[S.attack_speed] = 0;
          AdamantineFrost8Staff.base_stats[S.critical_chance] = 0.45f;
          AdamantineFrost8Staff.equipment_value = 160;
          AdamantineFrost8Staff.base_stats[S.projectiles] = 3;
          AdamantineFrost8Staff.quality = ItemQuality.Normal;
          AdamantineFrost8Staff.equipmentType = EquipmentType.Weapon;
          AdamantineFrost8Staff.name_class = "item_class_weapon";
          AdamantineFrost8Staff.action_special_effect = new WorldAction(NoneRegularAction);
          AdamantineFrost8Staff.action_attack_target = new AttackAction(Tornado3);
          AdamantineFrost8Staff.path_slash_animation = "effects/slashes/slash_bow";
          AdamantineFrost8Staff.tech_needed = "FrostStaff";
          AssetManager.items.list.AddItem(AdamantineFrost8Staff);
          Localization.addLocalization("item_AdamantineFrost8Staff", "Adamantine Frost Staff VIII");
          addWeaponsSprite(AdamantineFrost8Staff.id, AdamantineFrost8Staff.materials[0]);

//------------------------------------------------------------------------------------------------


   
 
          static void craftitem() {
 
          Race human = AssetManager.raceLibrary.get("human");
          Race orc = AssetManager.raceLibrary.get("orc");
          Race dwarf = AssetManager.raceLibrary.get("dwarf");
          Race elf = AssetManager.raceLibrary.get("elf");

          
          human.preferred_weapons.Add("BoneSword");
          elf.preferred_weapons.Add("BoneSword");
          dwarf.preferred_weapons.Add("BoneSword");
          orc.preferred_weapons.Add("BoneSword");

human.preferred_weapons.Add("BoneBow");
          elf.preferred_weapons.Add("BoneBow");
          dwarf.preferred_weapons.Add("BoneBow");
          orc.preferred_weapons.Add("BoneBow");

human.preferred_weapons.Add("BoneSpear");
          elf.preferred_weapons.Add("BoneSpear");
          dwarf.preferred_weapons.Add("BoneSpear");
          orc.preferred_weapons.Add("BoneSpear");

human.preferred_weapons.Add("BoneAxe");
          elf.preferred_weapons.Add("BoneAxe");
          dwarf.preferred_weapons.Add("BoneAxe");
          orc.preferred_weapons.Add("BoneAxe");

human.preferred_weapons.Add("BoneHammer");
          elf.preferred_weapons.Add("BoneHammer");
          dwarf.preferred_weapons.Add("BoneHammer");
          orc.preferred_weapons.Add("BoneHammer");

human.preferred_weapons.Add("WoodenCrossbow");
          elf.preferred_weapons.Add("WoodenCrossbow");
          dwarf.preferred_weapons.Add("WoodenCrossbow");
          orc.preferred_weapons.Add("WoodenCrossbow");

human.preferred_weapons.Add("CopperCrossbow");
          elf.preferred_weapons.Add("CopperCrossbow");
          dwarf.preferred_weapons.Add("CopperCrossbow");
          orc.preferred_weapons.Add("CopperCrossbow");

human.preferred_weapons.Add("BronzeCrossbow");
          elf.preferred_weapons.Add("BronzeCrossbow");
          dwarf.preferred_weapons.Add("BronzeCrossbow");
          orc.preferred_weapons.Add("BronzeCrossbow");

human.preferred_weapons.Add("SilverCrossbow");
          elf.preferred_weapons.Add("SilverCrossbow");
          dwarf.preferred_weapons.Add("SilverCrossbow");
          orc.preferred_weapons.Add("SilverCrossbow");

human.preferred_weapons.Add("IronCrossbow");
          elf.preferred_weapons.Add("IronCrossbow");
          dwarf.preferred_weapons.Add("IronCrossbow");
          orc.preferred_weapons.Add("IronCrossbow");

human.preferred_weapons.Add("SteelCrossbow");
          elf.preferred_weapons.Add("SteelCrossbow");
          dwarf.preferred_weapons.Add("SteelCrossbow");
          orc.preferred_weapons.Add("SteelCrossbow");

human.preferred_weapons.Add("MythrilCrossbow");
          elf.preferred_weapons.Add("MythrilCrossbow");
          dwarf.preferred_weapons.Add("MythrilCrossbow");
          orc.preferred_weapons.Add("MythrilCrossbow");

human.preferred_weapons.Add("AdamantineCrossbow");
          elf.preferred_weapons.Add("AdamantineCrossbow");
          dwarf.preferred_weapons.Add("AdamantineCrossbow");
          orc.preferred_weapons.Add("AdamantineCrossbow");

human.preferred_weapons.Add("WoodenFire1Staff");
          elf.preferred_weapons.Add("WoodenFire1Staff");
          dwarf.preferred_weapons.Add("WoodenFire1Staff");
          orc.preferred_weapons.Add("WoodenFire1Staff");

human.preferred_weapons.Add("CopperFire2Staff");
          elf.preferred_weapons.Add("CopperFire2Staff");
          dwarf.preferred_weapons.Add("CopperFire2Staff");
          orc.preferred_weapons.Add("CopperFire2Staff");

human.preferred_weapons.Add("BronzeFire3Staff");
          elf.preferred_weapons.Add("BronzeFire3Staff");
          dwarf.preferred_weapons.Add("BronzeFire3Staff");
          orc.preferred_weapons.Add("BronzeFire3Staff");

human.preferred_weapons.Add("SilverFire4Staff");
          elf.preferred_weapons.Add("SilverFire4Staff");
          dwarf.preferred_weapons.Add("SilverFire4Staff");
          orc.preferred_weapons.Add("SilverFire4Staff");

human.preferred_weapons.Add("IronFire5Staff");
          elf.preferred_weapons.Add("IronFire5Staff");
          dwarf.preferred_weapons.Add("IronFire5Staff");
          orc.preferred_weapons.Add("IronFire5Staff");

human.preferred_weapons.Add("SteelFire6Staff");
          elf.preferred_weapons.Add("SteelFire6Staff");
          dwarf.preferred_weapons.Add("SteelFire6Staff");
          orc.preferred_weapons.Add("SteelFire6Staff");

human.preferred_weapons.Add("MythrilFire7Staff");
          elf.preferred_weapons.Add("MythrilFire7Staff");
          dwarf.preferred_weapons.Add("MythrilFire7Staff");
          orc.preferred_weapons.Add("MythrilFire7Staff");

human.preferred_weapons.Add("AdamantineFire8Staff");
          elf.preferred_weapons.Add("AdamantineFire8Staff");
          dwarf.preferred_weapons.Add("AdamantineFire8Staff");
          orc.preferred_weapons.Add("AdamantineFire8Staff");

human.preferred_weapons.Add("WoodenThunder1Staff");
          elf.preferred_weapons.Add("WoodenThunder1Staff");
          dwarf.preferred_weapons.Add("WoodenThunder1Staff");
          orc.preferred_weapons.Add("WoodenThunder1Staff");

human.preferred_weapons.Add("CopperThunder2Staff");
          elf.preferred_weapons.Add("CopperThunder2Staff");
          dwarf.preferred_weapons.Add("CopperThunder2Staff");
          orc.preferred_weapons.Add("CopperThunder2Staff");

human.preferred_weapons.Add("BronzeThunder3Staff");
          elf.preferred_weapons.Add("BronzeThunder3Staff");
          dwarf.preferred_weapons.Add("BronzeThunder3Staff");
          orc.preferred_weapons.Add("BronzeThunder3Staff");

human.preferred_weapons.Add("SilverThunder4Staff");
          elf.preferred_weapons.Add("SilverThunder4Staff");
          dwarf.preferred_weapons.Add("SilverThunder4Staff");
          orc.preferred_weapons.Add("SilverThunder4Staff");

human.preferred_weapons.Add("IronThunder5Staff");
          elf.preferred_weapons.Add("IronThunder5Staff");
          dwarf.preferred_weapons.Add("IronThunder5Staff");
          orc.preferred_weapons.Add("IronThunder5Staff");

human.preferred_weapons.Add("SteelThunder6Staff");
          elf.preferred_weapons.Add("SteelThunder6Staff");
          dwarf.preferred_weapons.Add("SteelThunder6Staff");
          orc.preferred_weapons.Add("SteelThunder6Staff");

human.preferred_weapons.Add("MythrilThunder7Staff");
          elf.preferred_weapons.Add("MythrilThunder7Staff");
          dwarf.preferred_weapons.Add("MythrilThunder7Staff");
          orc.preferred_weapons.Add("MythrilThunder7Staff");

human.preferred_weapons.Add("AdamantineThunder8Staff");
          elf.preferred_weapons.Add("AdamantineThunder8Staff");
          dwarf.preferred_weapons.Add("AdamantineThunder8Staff");
          orc.preferred_weapons.Add("AdamantineThunder8Staff");

human.preferred_weapons.Add("WoodenFrost1Staff");
          elf.preferred_weapons.Add("WoodenFrost1Staff");
          dwarf.preferred_weapons.Add("WoodenFrost1Staff");
          orc.preferred_weapons.Add("WoodenFrost1Staff");

human.preferred_weapons.Add("CopperFrost2Staff");
          elf.preferred_weapons.Add("CopperFrost2Staff");
          dwarf.preferred_weapons.Add("CopperFrost2Staff");
          orc.preferred_weapons.Add("CopperFrost2Staff");

human.preferred_weapons.Add("BronzeFrost3Staff");
          elf.preferred_weapons.Add("BronzeFrost3Staff");
          dwarf.preferred_weapons.Add("BronzeFrost3Staff");
          orc.preferred_weapons.Add("BronzeFrost3Staff");

human.preferred_weapons.Add("SilverFrost4Staff");
          elf.preferred_weapons.Add("SilverFrost4Staff");
          dwarf.preferred_weapons.Add("SilverFrost4Staff");
          orc.preferred_weapons.Add("SilverFrost4Staff");

human.preferred_weapons.Add("IronFrost5Staff");
          elf.preferred_weapons.Add("IronFrost5Staff");
          dwarf.preferred_weapons.Add("IronFrost5Staff");
          orc.preferred_weapons.Add("IronFrost5Staff");

human.preferred_weapons.Add("SteelFrost6Staff");
          elf.preferred_weapons.Add("SteelFrost6Staff");
          dwarf.preferred_weapons.Add("SteelFrost6Staff");
          orc.preferred_weapons.Add("SteelFrost6Staff");

human.preferred_weapons.Add("MythrilFrost7Staff");
          elf.preferred_weapons.Add("MythrilFrost7Staff");
          dwarf.preferred_weapons.Add("MythrilFrost7Staff");
          orc.preferred_weapons.Add("MythrilFrost7Staff");

human.preferred_weapons.Add("AdamantineFrost8Staff");
          elf.preferred_weapons.Add("AdamantineFrost8Staff");
          dwarf.preferred_weapons.Add("AdamantineFrost8Staff");
          orc.preferred_weapons.Add("AdamantineFrost8Staff");


         
         }
 
        }



static bool Explosion1(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {

if(Toolbox.randomChance(0.001f))
{
         Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
         PowerLibrary pb = new PowerLibrary();
         pb.spawnEarthquake(pTarget.a.currentTile, null);
         EffectsLibrary.spawnExplosionWave(pTile.posV3, 10f, 0.5f);
         World.world.startShake(0.3f, 0.01f, 2f, true, true);
}
else if (Toolbox.randomChance(0.10f))
{
pTarget.CallMethod("addStatusEffect", "burning", 5f);
}
        return false;
  
        }


static bool Explosion2(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {

if(Toolbox.randomChance(0.001f))
{
         Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
         PowerLibrary pb = new PowerLibrary();
         pb.spawnEarthquake(pTarget.a.currentTile, null);
         EffectsLibrary.spawnExplosionWave(pTile.posV3, 10f, 0.5f);
         World.world.startShake(0.3f, 0.01f, 2f, true, true);
}
else if (Toolbox.randomChance(0.20f))
{
pTarget.CallMethod("addStatusEffect", "burning", 6f);
}
        return false;
  
        }

static bool Explosion3(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {

if(Toolbox.randomChance(0.001f))
{
         Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
         PowerLibrary pb = new PowerLibrary();
         pb.spawnEarthquake(pTarget.a.currentTile, null);
         EffectsLibrary.spawnExplosionWave(pTile.posV3, 10f, 0.5f);
         World.world.startShake(0.3f, 0.01f, 2f, true, true);
}
else if (Toolbox.randomChance(0.30f))
{
pTarget.CallMethod("addStatusEffect", "burning", 7f);
}
        return false;
  
        }

static bool Explosion4(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {

if(Toolbox.randomChance(0.001f))
{
         Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
         PowerLibrary pb = new PowerLibrary();
         pb.spawnEarthquake(pTarget.a.currentTile, null);
         EffectsLibrary.spawnExplosionWave(pTile.posV3, 10f, 0.5f);
         World.world.startShake(0.3f, 0.01f, 2f, true, true);
}
else if (Toolbox.randomChance(0.40f))
{
pTarget.CallMethod("addStatusEffect", "burning", 8f);
}
        return false;
  
        }

static bool Explosion5(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {

if(Toolbox.randomChance(0.001f))
{
         Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
         PowerLibrary pb = new PowerLibrary();
         pb.spawnEarthquake(pTarget.a.currentTile, null);
         EffectsLibrary.spawnExplosionWave(pTile.posV3, 10f, 0.5f);
         World.world.startShake(0.3f, 0.01f, 2f, true, true);
}
else if (Toolbox.randomChance(0.50f))
{
pTarget.CallMethod("addStatusEffect", "burning", 9f);
}
        return false;
  
        }

static bool Explosion6(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {

if(Toolbox.randomChance(0.001f))
{
         Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
         PowerLibrary pb = new PowerLibrary();
         pb.spawnEarthquake(pTarget.a.currentTile, null);
         EffectsLibrary.spawnExplosionWave(pTile.posV3, 10f, 0.5f);
         World.world.startShake(0.3f, 0.01f, 2f, true, true);
}
else if (Toolbox.randomChance(0.60f))
{
pTarget.CallMethod("addStatusEffect", "burning", 10f);
}
        return false;
  
        }

static bool Explosion7(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {

if(Toolbox.randomChance(0.001f))
{
         Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
         PowerLibrary pb = new PowerLibrary();
         pb.spawnEarthquake(pTarget.a.currentTile, null);
         EffectsLibrary.spawnExplosionWave(pTile.posV3, 10f, 0.5f);
         World.world.startShake(0.3f, 0.01f, 2f, true, true);
}
else if (Toolbox.randomChance(0.70f))
{
pTarget.CallMethod("addStatusEffect", "burning", 11f);
}
        return false;
  
        }

static bool Explosion8(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {

if(Toolbox.randomChance(0.001f))
{
         Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;
         PowerLibrary pb = new PowerLibrary();
         pb.spawnEarthquake(pTarget.a.currentTile, null);
         EffectsLibrary.spawnExplosionWave(pTile.posV3, 10f, 0.5f);
         World.world.startShake(0.3f, 0.01f, 2f, true, true);
}
else if (Toolbox.randomChance(0.80f))
{
pTarget.CallMethod("addStatusEffect", "burning", 12f);
}
        return false;
  
        }



//-----------------------------------------------




static bool ThunderSmall(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
        

        Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;

        if(Toolbox.randomChance(0.001f))
{
 
         PowerLibrary pb = new PowerLibrary();
         pb.spawnCloud(pTarget.a.currentTile, "ThunderCloud");
}

else if(Toolbox.randomChance(0.10f))

{
MapBox.spawnLightningSmall(pTile, 0.05f);
  
   }

else if(Toolbox.randomChance(0.40f))

{
pTarget.CallMethod("addStatusEffect", "burning", 5f);
  
   }    
    


  return false;
        }




static bool ThunderMedium(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
        

        Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;

        if(Toolbox.randomChance(0.001f))
{
 
         PowerLibrary pb = new PowerLibrary();
         pb.spawnCloud(pTarget.a.currentTile, "ThunderCloud");
}

else if(Toolbox.randomChance(0.15f))

{
MapBox.spawnLightningSmall(pTile, 0.10f);
  
   }    

else if(Toolbox.randomChance(0.60f))

{
pTarget.CallMethod("addStatusEffect", "burning", 8f);
  
   } 


  return false;
        }




static bool ThunderBig(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
        

        Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;

        if(Toolbox.randomChance(0.001f))
{
 
         PowerLibrary pb = new PowerLibrary();
         pb.spawnCloud(pTarget.a.currentTile, "ThunderCloud");
}

else if(Toolbox.randomChance(0.20f))

{
MapBox.spawnLightningSmall(pTile, 0.15f);
  
   }    

else if(Toolbox.randomChance(0.80f))

{
pTarget.CallMethod("addStatusEffect", "burning", 15f);
  
   } 


  return false;
        }


//---------------------------------------------------------------



static bool Tornado1(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
        Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;

if(Toolbox.randomChance(0.001f))
{
         ActionLibrary.castTornado(null, pTarget, null);

         EffectsLibrary.spawnExplosionWave(pTile.posV3, 10f, 0.5f);

         World.world.startShake(0.3f, 0.01f, 2f, true, true);
}

else if(Toolbox.randomChance(0.40f))

{
pTarget.CallMethod("addStatusEffect", "frozen", 5f);
  
   }
        return false;
  
        }




static bool Tornado2(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
        Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;

if(Toolbox.randomChance(0.001f))
{
         ActionLibrary.castTornado(null, pTarget, null);

         ActionLibrary.castTornado(null, pTarget, null);

         EffectsLibrary.spawnExplosionWave(pTile.posV3, 10f, 0.5f);

         World.world.startShake(0.3f, 0.01f, 2f, true, true);
}

else if(Toolbox.randomChance(0.60f))

{
pTarget.CallMethod("addStatusEffect", "frozen", 8f);
  
   }

        return false;
  
        }




static bool Tornado3(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
        Actor a = Reflection.GetField(pTarget.GetType(), pTarget, "a") as Actor;

if(Toolbox.randomChance(0.01f))
{
         ActionLibrary.castTornado(null, pTarget, null);

         ActionLibrary.castTornado(null, pTarget, null);

         ActionLibrary.castTornado(null, pTarget, null);

         EffectsLibrary.spawnExplosionWave(pTile.posV3, 10f, 0.5f);

         World.world.startShake(0.3f, 0.01f, 2f, true, true);
}

else if(Toolbox.randomChance(0.80f))

{
pTarget.CallMethod("addStatusEffect", "frozen", 12f);
  
   }

        return false;
  
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
