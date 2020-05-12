using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using FargowiltasSillySqurrl.NPCs;

namespace FargowiltasSillySqurrl
{
	public class FargowiltasSillySqurrl : Mod
	{
		public FargowiltasSillySqurrl()
	        {
                        int Timer = 0;
			Timer++;
			if (Timer >= 120 && Main.bloodMoon && NPC.AnyNPCs(ModContent.NPCType<SillySqurrl>()) && Main.dayTime == false) {
 			Main.dayTime = true;
			Main.bloodMoon = true;
			Main.time = 0;
			Timer = 0;
			}	
		}
        }
}
