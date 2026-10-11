using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PS3Mod.Content.Items.Weapons;
using PS3Mod.Content.Items.Armor;


namespace PS3Mod.Content.Items
{
    public class RecipeOverride : ModSystem
    {
        public override void PostAddRecipes()
        {
            for (int i = 0; i < Recipe.maxRecipes; i++)
            {
                Recipe recipe = Main.recipe[i];

                if (recipe.createItem.type == ItemID.TrueNightsEdge)
                {
                    recipe.DisableRecipe();
                }
                if (recipe.createItem.type == ItemID.TrueExcalibur)
                {
                    recipe.DisableRecipe();
                }
                if (recipe.createItem.type == ItemID.TerraBlade)
                {
                    recipe.DisableRecipe();
                }
                if (recipe.createItem.type == ItemID.LightsBane)
                {
                    recipe.DisableRecipe();
                }
                if (recipe.createItem.type == ItemID.NightsEdge)
                {
                    recipe.DisableRecipe();
                }
                if (recipe.createItem.type == ItemID.Excalibur)
                {
                    recipe.DisableRecipe();
                }
                if (recipe.createItem.type == ItemID.BladeofGrass)
                {
                    recipe.DisableRecipe();
                }
                if (recipe.createItem.type == ItemID.Zenith)
                {
                    recipe.DisableRecipe();
                }
            }

            Recipe zennyyy = Recipe.Create(ItemID.Zenith);
            Recipe tne = Recipe.Create(ModContent.ItemType<OldTNE>());
            Recipe ex = Recipe.Create(ModContent.ItemType<OldTrueExcalibur>());
            Recipe terror = Recipe.Create(ModContent.ItemType<OldTerraBlade>());
            Recipe thelightsbane = Recipe.Create(ModContent.ItemType<LightsBane>());
            Recipe nse = Recipe.Create(ModContent.ItemType<NightsEdge>());
            Recipe nse2 = Recipe.Create(ModContent.ItemType<NightsEdge>());
            Recipe exc = Recipe.Create(ModContent.ItemType<Excalibur>());
            Recipe bog = Recipe.Create(ModContent.ItemType<BladeofGrass>());
            Recipe vulcan = Recipe.Create(ModContent.ItemType<VulcanRepeater>());
            Recipe vulcan2 = Recipe.Create(ModContent.ItemType<VulcanRepeater>());
            Recipe skull = Recipe.Create(ModContent.ItemType<SuspiciousLookingSkull>());
            Recipe skull2 = Recipe.Create(ModContent.ItemType<SuspiciousLookingSkull>());
            Recipe tizona = Recipe.Create(ModContent.ItemType<Tizona>());
            Recipe tizona2 = Recipe.Create(ModContent.ItemType<Tizona>());
            Recipe sharanga = Recipe.Create(ModContent.ItemType<Sharanga>());
            Recipe tonbogiri = Recipe.Create(ModContent.ItemType<Tonbogiri>());
            Recipe tonbogiri2 = Recipe.Create(ModContent.ItemType<Tonbogiri>());
            Recipe dragonMask = Recipe.Create(ModContent.ItemType<DragonMask>());
            Recipe dragonMask2 = Recipe.Create(ModContent.ItemType<DragonMask>());
            Recipe dragonBreastplate = Recipe.Create(ModContent.ItemType<DragonBreastplate>());
            Recipe dragonBreastplate2 = Recipe.Create(ModContent.ItemType<DragonBreastplate>());
            Recipe dragonGreaves = Recipe.Create(ModContent.ItemType<DragonGreaves>());
            Recipe dragonGreaves2 = Recipe.Create(ModContent.ItemType<DragonGreaves>());
            Recipe titanHelmet = Recipe.Create(ModContent.ItemType<TitanHelmet>());
            Recipe titanHelmet2 = Recipe.Create(ModContent.ItemType<TitanHelmet>());
            Recipe titanMail = Recipe.Create(ModContent.ItemType<TitanMail>());
            Recipe titanMail2 = Recipe.Create(ModContent.ItemType<TitanMail>());
            Recipe titanLeggings = Recipe.Create(ModContent.ItemType<TitanLeggings>());
            Recipe titanLeggings2 = Recipe.Create(ModContent.ItemType<TitanLeggings>());
            Recipe spectralHeadgear = Recipe.Create(ModContent.ItemType<SpectralHeadgear>());
            Recipe spectralHeadgear2 = Recipe.Create(ModContent.ItemType<SpectralHeadgear>());
            Recipe spectralArmor = Recipe.Create(ModContent.ItemType<SpectralArmor>());
            Recipe spectralArmor2 = Recipe.Create(ModContent.ItemType<SpectralArmor>());
            Recipe spectralSubligar = Recipe.Create(ModContent.ItemType<SpectralSubligar>());
            Recipe spectralSubligar2 = Recipe.Create(ModContent.ItemType<SpectralSubligar>());

            zennyyy.AddIngredient(ModContent.ItemType<OldTerraBlade>(), 1);
            zennyyy.AddIngredient(ItemID.Meowmere, 1);
            zennyyy.AddIngredient(ItemID.StarWrath, 1);
            zennyyy.AddIngredient(ItemID.InfluxWaver, 1);
            zennyyy.AddIngredient(ModContent.ItemType<OldHorsemansBlade>(), 1);
            zennyyy.AddIngredient(ItemID.Seedler, 1);
            zennyyy.AddIngredient(ItemID.Starfury, 1);
            zennyyy.AddIngredient(ItemID.BeeKeeper, 1);
            zennyyy.AddIngredient(ItemID.EnchantedSword, 1);
            zennyyy.AddIngredient(ItemID.CopperShortsword, 1);

            tne.AddIngredient(ModContent.ItemType<NightsEdge>(), 1);
            tne.AddIngredient(ItemID.BrokenHeroSword, 1);

            ex.AddIngredient(ModContent.ItemType<Excalibur>(), 1);
            ex.AddIngredient(ItemID.BrokenHeroSword, 1);

            terror.AddIngredient(ModContent.ItemType<OldTNE>(), 1);
            terror.AddIngredient(ModContent.ItemType<OldTrueExcalibur>(), 1);
            terror.AddIngredient(ItemID.BrokenHeroSword, 1);

            thelightsbane.AddIngredient(ItemID.DemoniteBar, 10);

            exc.AddIngredient(ItemID.HallowedBar, 12);

            bog.AddIngredient(ItemID.Stinger, 12);
            bog.AddIngredient(ItemID.JungleSpores, 12);
            bog.AddIngredient(ItemID.Vine, 3);

            nse.AddIngredient(ModContent.ItemType<LightsBane>(), 1);
            nse.AddIngredient(ItemID.Muramasa, 1);
            nse.AddIngredient(ModContent.ItemType<BladeofGrass>(), 1);
            nse.AddIngredient(ItemID.FieryGreatsword, 1);

            nse2.AddIngredient(ItemID.BloodButcherer, 1);
            nse2.AddIngredient(ItemID.Muramasa, 1);
            nse2.AddIngredient(ModContent.ItemType<BladeofGrass>(), 1);
            nse2.AddIngredient(ItemID.FieryGreatsword, 1);

            sharanga.AddIngredient(ItemID.MoltenFury, 2);
            sharanga.AddIngredient(ItemID.HellstoneBar, 10);

            vulcan.AddIngredient(ItemID.HallowedRepeater, 1);
            vulcan.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            vulcan.AddIngredient(ItemID.AdamantiteBar, 15);

            vulcan2.AddIngredient(ItemID.HallowedRepeater, 1);
            vulcan2.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            vulcan2.AddIngredient(ItemID.TitaniumBar, 15);

            skull.AddIngredient(ItemID.Bone, 30);
            skull.AddIngredient(ItemID.SoulofLight, 5);
            skull.AddIngredient(ItemID.SoulofNight, 5);
            skull.AddIngredient(ItemID.AdamantiteBar, 10);
            skull.AddIngredient(ItemID.MechanicalEye, 2);
            skull.AddIngredient(ItemID.MechanicalSkull, 1);

            skull2.AddIngredient(ItemID.Bone, 30);
            skull2.AddIngredient(ItemID.SoulofLight, 5);
            skull2.AddIngredient(ItemID.SoulofNight, 5);
            skull2.AddIngredient(ItemID.TitaniumBar, 10);
            skull2.AddIngredient(ItemID.MechanicalEye, 2);
            skull2.AddIngredient(ItemID.MechanicalSkull, 1);

            tizona.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            tizona.AddIngredient(ItemID.AdamantiteBar, 15);
            tizona.AddIngredient(ItemID.Excalibur, 1);

            tizona2.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            tizona2.AddIngredient(ItemID.TitaniumBar, 15);
            tizona2.AddIngredient(ItemID.Excalibur, 1);

            tonbogiri.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            tonbogiri.AddIngredient(ItemID.AdamantiteBar, 15);
            tonbogiri.AddIngredient(ItemID.Gungnir, 1);

            tonbogiri2.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            tonbogiri2.AddIngredient(ItemID.TitaniumBar, 15);
            tonbogiri2.AddIngredient(ItemID.Gungnir, 1);

            //dragon armor
            dragonMask.AddIngredient(ItemID.CobaltHelmet, 1);
            dragonMask.AddIngredient(ItemID.MythrilHelmet, 1);
            dragonMask.AddIngredient(ItemID.AdamantiteHelmet, 1);
            dragonMask.AddIngredient(ItemID.HallowedMask, 1);
            dragonMask.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            dragonMask2.AddIngredient(ItemID.CobaltHelmet, 1);
            dragonMask2.AddIngredient(ItemID.MythrilHelmet, 1);
            dragonMask2.AddIngredient(ItemID.TitaniumHelmet, 1);
            dragonMask2.AddIngredient(ItemID.HallowedMask, 1);
            dragonMask2.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            
            dragonBreastplate.AddIngredient(ItemID.CobaltBreastplate, 1);
            dragonBreastplate.AddIngredient(ItemID.MythrilChainmail, 1);
            dragonBreastplate.AddIngredient(ItemID.AdamantiteBreastplate, 1);
            dragonBreastplate.AddIngredient(ItemID.HallowedPlateMail, 1);
            dragonBreastplate.AddIngredient(ModContent.ItemType<SoulofBlight>(), 20);
            dragonBreastplate.AddIngredient(ItemID.SoulofMight, 15);
            dragonBreastplate2.AddIngredient(ItemID.CobaltBreastplate, 1);
            dragonBreastplate2.AddIngredient(ItemID.MythrilChainmail, 1);
            dragonBreastplate2.AddIngredient(ItemID.TitaniumBreastplate, 1);
            dragonBreastplate2.AddIngredient(ItemID.HallowedPlateMail, 1);
            dragonBreastplate2.AddIngredient(ModContent.ItemType<SoulofBlight>(), 20);
            dragonBreastplate2.AddIngredient(ItemID.SoulofMight, 15);
            
            dragonGreaves.AddIngredient(ItemID.CobaltLeggings, 1);
            dragonGreaves.AddIngredient(ItemID.MythrilGreaves, 1);
            dragonGreaves.AddIngredient(ItemID.AdamantiteLeggings, 1);
            dragonGreaves.AddIngredient(ItemID.HallowedGreaves, 1);
            dragonGreaves.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            dragonGreaves.AddIngredient(ItemID.SoulofMight, 15);
            dragonGreaves2.AddIngredient(ItemID.CobaltLeggings, 1);
            dragonGreaves2.AddIngredient(ItemID.MythrilGreaves, 1);
            dragonGreaves2.AddIngredient(ItemID.TitaniumLeggings, 1);
            dragonGreaves2.AddIngredient(ItemID.HallowedGreaves, 1);
            dragonGreaves2.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            dragonGreaves2.AddIngredient(ItemID.SoulofMight, 15);
            //dragon end

            //titan armor
            titanHelmet.AddIngredient(ItemID.CobaltMask, 1);
            titanHelmet.AddIngredient(ItemID.MythrilHat, 1);
            titanHelmet.AddIngredient(ItemID.AdamantiteMask, 1);
            titanHelmet.AddIngredient(ItemID.HallowedHelmet, 1);
            titanHelmet.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            titanHelmet2.AddIngredient(ItemID.CobaltMask, 1);
            titanHelmet2.AddIngredient(ItemID.MythrilHat, 1);
            titanHelmet2.AddIngredient(ItemID.TitaniumMask, 1);
            titanHelmet2.AddIngredient(ItemID.HallowedHelmet, 1);
            titanHelmet2.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);


            titanMail.AddIngredient(ItemID.CobaltBreastplate, 1);
            titanMail.AddIngredient(ItemID.MythrilChainmail, 1);
            titanMail.AddIngredient(ItemID.AdamantiteBreastplate, 1);
            titanMail.AddIngredient(ItemID.HallowedPlateMail, 1);
            titanMail.AddIngredient(ModContent.ItemType<SoulofBlight>(), 20);
            titanMail.AddIngredient(ItemID.SoulofSight, 15);
            titanMail2.AddIngredient(ItemID.CobaltBreastplate, 1);
            titanMail2.AddIngredient(ItemID.MythrilChainmail, 1);
            titanMail2.AddIngredient(ItemID.TitaniumBreastplate, 1);
            titanMail2.AddIngredient(ItemID.HallowedPlateMail, 1);
            titanMail2.AddIngredient(ModContent.ItemType<SoulofBlight>(), 20);
            titanMail2.AddIngredient(ItemID.SoulofSight, 15);

            titanLeggings.AddIngredient(ItemID.CobaltLeggings, 1);
            titanLeggings.AddIngredient(ItemID.MythrilGreaves, 1);
            titanLeggings.AddIngredient(ItemID.AdamantiteLeggings, 1);
            titanLeggings.AddIngredient(ItemID.HallowedGreaves, 1);
            titanLeggings.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            titanLeggings.AddIngredient(ItemID.SoulofSight, 10);
            titanLeggings2.AddIngredient(ItemID.CobaltLeggings, 1);
            titanLeggings2.AddIngredient(ItemID.MythrilGreaves, 1);
            titanLeggings2.AddIngredient(ItemID.TitaniumLeggings, 1);
            titanLeggings2.AddIngredient(ItemID.HallowedGreaves, 1);
            titanLeggings2.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            titanLeggings2.AddIngredient(ItemID.SoulofSight, 10);
            //titan end

            //spectral armor
            spectralHeadgear.AddIngredient(ItemID.CobaltHat, 1);
            spectralHeadgear.AddIngredient(ItemID.MythrilHood, 1);
            spectralHeadgear.AddIngredient(ItemID.AdamantiteHeadgear, 1);
            spectralHeadgear.AddIngredient(ItemID.HallowedHeadgear, 1);
            spectralHeadgear.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            spectralHeadgear2.AddIngredient(ItemID.CobaltHat, 1);
            spectralHeadgear2.AddIngredient(ItemID.MythrilHood, 1);
            spectralHeadgear2.AddIngredient(ItemID.TitaniumHeadgear, 1);
            spectralHeadgear2.AddIngredient(ItemID.HallowedHeadgear, 1);
            spectralHeadgear2.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);


            spectralArmor.AddIngredient(ItemID.CobaltBreastplate, 1);
            spectralArmor.AddIngredient(ItemID.MythrilChainmail, 1);
            spectralArmor.AddIngredient(ItemID.AdamantiteBreastplate, 1);
            spectralArmor.AddIngredient(ItemID.HallowedPlateMail, 1);
            spectralArmor.AddIngredient(ModContent.ItemType<SoulofBlight>(), 20);
            spectralArmor.AddIngredient(ItemID.SoulofFright, 10);
            spectralArmor2.AddIngredient(ItemID.CobaltBreastplate, 1);
            spectralArmor2.AddIngredient(ItemID.MythrilChainmail, 1);
            spectralArmor2.AddIngredient(ItemID.TitaniumBreastplate, 1);
            spectralArmor2.AddIngredient(ItemID.HallowedPlateMail, 1);
            spectralArmor2.AddIngredient(ModContent.ItemType<SoulofBlight>(), 20);
            spectralArmor2.AddIngredient(ItemID.SoulofFright, 10);

            spectralSubligar.AddIngredient(ItemID.CobaltLeggings, 1);
            spectralSubligar.AddIngredient(ItemID.MythrilGreaves, 1);
            spectralSubligar.AddIngredient(ItemID.AdamantiteLeggings, 1);
            spectralSubligar.AddIngredient(ItemID.HallowedGreaves, 1);
            spectralSubligar.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            spectralSubligar.AddIngredient(ItemID.SoulofFright, 10);
            spectralSubligar2.AddIngredient(ItemID.CobaltLeggings, 1);
            spectralSubligar2.AddIngredient(ItemID.MythrilGreaves, 1);
            spectralSubligar2.AddIngredient(ItemID.TitaniumLeggings, 1);
            spectralSubligar2.AddIngredient(ItemID.HallowedGreaves, 1);
            spectralSubligar2.AddIngredient(ModContent.ItemType<SoulofBlight>(), 15);
            spectralSubligar2.AddIngredient(ItemID.SoulofFright, 10);
            //spectral end
            //8

            sharanga.AddTile(TileID.Anvils);    
            vulcan.AddTile(TileID.MythrilAnvil);
            vulcan2.AddTile(TileID.MythrilAnvil);
            skull.AddTile(TileID.MythrilAnvil);
            skull2.AddTile(TileID.MythrilAnvil);
            tizona.AddTile(TileID.MythrilAnvil);
            tizona2.AddTile(TileID.MythrilAnvil);
            tonbogiri.AddTile(TileID.MythrilAnvil);
            tonbogiri2.AddTile(TileID.MythrilAnvil);
            dragonMask.AddTile(TileID.MythrilAnvil);
            dragonMask2.AddTile(TileID.MythrilAnvil);
            dragonBreastplate.AddTile(TileID.MythrilAnvil);
            dragonBreastplate2.AddTile(TileID.MythrilAnvil);
            dragonGreaves.AddTile(TileID.MythrilAnvil);
            dragonGreaves2.AddTile(TileID.MythrilAnvil);
            titanHelmet.AddTile(TileID.MythrilAnvil);
            titanHelmet2.AddTile(TileID.MythrilAnvil);
            titanMail.AddTile(TileID.MythrilAnvil);
            titanMail2.AddTile(TileID.MythrilAnvil);
            titanLeggings.AddTile(TileID.MythrilAnvil);
            titanLeggings2.AddTile(TileID.MythrilAnvil);
            spectralHeadgear.AddTile(TileID.MythrilAnvil);
            spectralHeadgear2.AddTile(TileID.MythrilAnvil);
            spectralArmor.AddTile(TileID.MythrilAnvil);
            spectralArmor2.AddTile(TileID.MythrilAnvil);
            spectralSubligar.AddTile(TileID.MythrilAnvil);
            spectralSubligar2.AddTile(TileID.MythrilAnvil);
            tne.AddTile(TileID.MythrilAnvil);
            ex.AddTile(TileID.MythrilAnvil);
            exc.AddTile(TileID.MythrilAnvil);
            terror.AddTile(TileID.MythrilAnvil);
            zennyyy.AddTile(TileID.MythrilAnvil);
            bog.AddTile(TileID.MythrilAnvil);
            nse.AddTile(TileID.DemonAltar);
            nse2.AddTile(TileID.DemonAltar);
            thelightsbane.AddTile(TileID.Anvils);
            

            tne.Register();
            ex.Register();
            terror.Register();
            bog.Register();
            nse.Register();
            nse2.Register();
            exc.Register();
            sharanga.Register();
            vulcan.Register();
            vulcan2.Register();
            skull.Register();
            skull2.Register();
            tizona.Register();
            tizona2.Register();
            tonbogiri.Register();
            tonbogiri2.Register();
            dragonMask.Register();
            dragonMask2.Register();
            dragonBreastplate.Register();
            dragonGreaves.Register();
            titanHelmet.Register();
            titanHelmet2.Register();
            titanMail.Register();
            titanMail2.Register();
            titanLeggings.Register();
            titanLeggings2.Register();
            spectralHeadgear.Register();
            spectralHeadgear2.Register();
            spectralArmor.Register();
            spectralArmor2.Register();
            spectralSubligar.Register();
            spectralSubligar2.Register();
            thelightsbane.Register();
            zennyyy.Register();
        }
    }
}
