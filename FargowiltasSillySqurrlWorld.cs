using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace FargowiltasSillySqurrl
{
    public class FargowiltasSillySqurrlWorld : ModWorld
    {
        public static bool squirrelNight;

        public override void Initialize()
        {
            squirrelNight = false;
        }
        
        public override void PostUpdate()
        {
            if (NPC.AnyNPCs(ModContent.NPCType<NPCs.SillySqurrl>()))
            {
                if (!Main.dayTime)
                    squirrelNight = true;
            }
            else
            {
                squirrelNight = false;
            }

            if (squirrelNight)
            {
                Main.dayTime = false;
                Main.bloodMoon = true;
                if (Main.time > 16200)
                    Main.time = 16200;
            }
        }
    }
}
