using System;
using System.Threading;
using NCMS;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine;
using ReflectionUtility;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using Beebyte.Obfuscator;

namespace TechsMod
{
    class Projectiles
    {
        public static void init()
        {

            


          ProjectileAsset CrossbowArrow = new ProjectileAsset();
          CrossbowArrow.id = "CrossbowArrow";
          CrossbowArrow.texture = "arrow";
          CrossbowArrow.trailEffect_enabled = false;
          CrossbowArrow.look_at_target = true;
          CrossbowArrow.parabolic = false;
          CrossbowArrow.looped = true;
          CrossbowArrow.speed = 30f;
          CrossbowArrow.draw_light_area = true;
	  CrossbowArrow.draw_light_size = 0.1f;
          CrossbowArrow.startScale = 0.04f;
          CrossbowArrow.targetScale = 0.04f;
          CrossbowArrow.sound_launch = "Crossbow_fire";
          CrossbowArrow.sound_impact = "Crossbow_impact";
          AssetManager.projectiles.add(CrossbowArrow);

          ProjectileAsset FireProj = new ProjectileAsset();
          FireProj.id = "FireProj";
          FireProj.texture = "FireProj";
          FireProj.trailEffect_enabled = false;
          FireProj.look_at_target = true;
          FireProj.parabolic = false;
          FireProj.looped = true;
          FireProj.speed = 15f;
          FireProj.startScale = 0.04f;
          FireProj.targetScale = 0.04f;
          //FireProj.texture_shadow = "pr_freeze_orb";
          FireProj.sound_launch = "event:/SFX/WEAPONS/WeaponFireballStart";
          FireProj.sound_impact = "event:/SFX/WEAPONS/WeaponFireballLand";
          AssetManager.projectiles.add(FireProj);

          ProjectileAsset ThunderProj = new ProjectileAsset();
          ThunderProj.id = "ThunderProj";
          ThunderProj.texture = "ThunderProj";
          ThunderProj.trailEffect_enabled = false;
          ThunderProj.look_at_target = true;
          ThunderProj.parabolic = false;
          ThunderProj.looped = true;
          ThunderProj.speed = 80f;
          ThunderProj.startScale = 0.04f;
          ThunderProj.targetScale = 0.04f;
          ThunderProj.sound_launch = "Thunder";
          ThunderProj.sound_impact = "Thunder";
          AssetManager.projectiles.add(ThunderProj);

          ProjectileAsset FrostProj = new ProjectileAsset();
          FrostProj.id = "FrostProj";
          FrostProj.texture = "FrostProj";
          FrostProj.trailEffect_enabled = false;
          FrostProj.look_at_target = true;
          FrostProj.parabolic = false;
          FrostProj.looped = true;
          FrostProj.speed = 15f;
          FrostProj.startScale = 0.04f;
          FrostProj.targetScale = 0.04f;
          FrostProj.sound_launch = "event:/SFX/WEAPONS/WeaponFreezeOrbStart";
          FrostProj.sound_impact = "event:/SFX/WEAPONS/WeaponFreezeOrbLand";
          AssetManager.projectiles.add(FrostProj);


            
        }
    }
}