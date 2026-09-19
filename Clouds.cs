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
    class Clouds
    {
        public static void init()
        {
            //Cloud details
            CloudAsset ThunderCloud = new CloudAsset();
            ThunderCloud.id = "ThunderCloud";
            ThunderCloud.color = Toolbox.makeColor("#445366", -1f);
			ThunderCloud.cloud_action_1 = new CloudAction(godLightning);
			ThunderCloud.path_sprites = List.Of<string>(new string[]
				{
					"effects/clouds/cloud_big_1",
					"effects/clouds/cloud_big_2"
				});
			ThunderCloud.speed_min = 0.5f;
			ThunderCloud.speed_max = 0.5f;
			ThunderCloud.considered_disaster = true;
			AssetManager.clouds.add(ThunderCloud);

			CloudAsset DraupnirCloud = new CloudAsset();
            DraupnirCloud.id = "DraupnirCloud";
            DraupnirCloud.color = Toolbox.makeColor("#FFFFFF", -1f);
			DraupnirCloud.max_alpha = 0.01f;
			DraupnirCloud.drop_id = "Draupdrop";
			DraupnirCloud.cloud_action_1 = new CloudAction(CloudLibrary.dropAction);
			DraupnirCloud.path_sprites = List.Of<string>(new string[]
				{
					"effects/clouds/cloud_small_2"
				});
			DraupnirCloud.speed_min = 2f;
			DraupnirCloud.speed_max = 2f;
			DraupnirCloud.considered_disaster = true;
			AssetManager.clouds.add(DraupnirCloud);

			//Cloud Postfix
			ThunderCloud.cached_sprites = new List<Sprite>();
			foreach (Sprite sprite2 in Enumerable.Where<Sprite>(Enumerable.Select<string, Sprite>(ThunderCloud.path_sprites, new Func<string, Sprite>(SpriteTextureLoader.getSprite)), (Sprite sprite) => sprite != null))
			{
				ThunderCloud.cached_sprites.Add(sprite2);
			}

			DraupnirCloud.cached_sprites = new List<Sprite>();
			foreach (Sprite sprite2 in Enumerable.Where<Sprite>(Enumerable.Select<string, Sprite>(DraupnirCloud.path_sprites, new Func<string, Sprite>(SpriteTextureLoader.getSprite)), (Sprite sprite) => sprite != null))
			{
				DraupnirCloud.cached_sprites.Add(sprite2);
			}
			return;


        }
        public static void godLightning(Cloud pCloud)
	{
		if (!Toolbox.randomChance(0.1f))
		{
			return;
		}
		int num = (int)pCloud.transform.localPosition.x;
		int num2 = (int)pCloud.transform.localPosition.y;
		float effect_texture_width = pCloud.effect_texture_width;
		float effect_texture_height = pCloud.effect_texture_height;
		num += (int)Toolbox.randomFloat(-effect_texture_width, effect_texture_width);
		num2 += (int)Toolbox.randomFloat(-effect_texture_height + pCloud.spriteShadow.offset.y, effect_texture_height + pCloud.spriteShadow.offset.y);
		WorldTile tile = World.world.GetTile(num, num2);
		if (tile != null)
		{
			if (Toolbox.randomBool())
			{
				MapBox.spawnLightningMedium(tile, 0.15f);
				return;
			}
			MapBox.spawnLightningSmall(tile, 0.15f);
		}
	}
        public static void addTraitToLocalizedLibrary(string name, string desc, string id, string description)
        {
          Dictionary<string, string> localizedText = Reflection.GetField(LocalizedTextManager.instance.GetType(), LocalizedTextManager.instance, "localizedText") as Dictionary<string, string>;
          localizedText.Add(name, id);
          localizedText.Add(desc, description);
        }
    }
}