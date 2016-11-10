using CrystalSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalSorter.Generator
{
    public class CrystalGen
    {
        public List<Crystal> Generate()
        {
            List<Crystal> crystals = new List<Crystal>();

            // ORANGE CRYSTALS
            // WEAPON
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal - Agony", ItemEffect = "Attack Speed & Casting Speed +1", Shattering = "Very Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Ancient Magic Crystal - Carmae", ItemEffect = "Critical Hit Rate & Attack Speed + 1", Shattering = "Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal - Crimson Flame", ItemEffect = "Critical Hit +2", Shattering = "Very Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal - Destruction", ItemEffect = "Attack Speed +2", Shattering = "Very Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal - Enchantment", ItemEffect = "Casting Speed +2", Shattering = "Very Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal - Temptation", ItemEffect = "Attack Speed & Critical Hit Rate +1", Shattering = "Very Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Black Crystal - Carmae", ItemEffect = "Critical Hit Rate & Attack Speed +1 & AP +2", Shattering = "Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Red Battlefield Crystal: Carmae", ItemEffect = "Critical Hit Rate & Attack Speed +1 & Human Damage +3", Shattering = "N/A", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Red Battlefield Crystal: Power", ItemEffect = "Attack +5 & Human Damage +2", Shattering = "Might be", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });

            // SECONDARY WEAPON
            crystals.Add(new Crystal { Localization = "", Name = "Awakened Spirit's Crystal", ItemEffect = "Max HP +150 & AP +5", Shattering = "Low", Slot = Slot.Secondary.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Spirit Crystal", ItemEffect = "Max HP +100 & AP +5", Shattering = "High", Slot = Slot.Secondary.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Red Spirit Crystal", ItemEffect = "MaxHP +100 & Attack +5 & Human Damage +3", Shattering = "Might be", Slot = Slot.Secondary.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });

            // HELMET
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Ancient Magic Crystal - Harphia", ItemEffect = "Max HP +50 & HP Recovery +5", Shattering = "Low", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Black Magic Crystal - Harphia", ItemEffect = "Max HP +50 & HP Recovery +5 & Evasion +2", Shattering = "Low", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Red Battlefield Crystal: Harsha", ItemEffect = "Max HP +50 & HP Recovery +5 & Human Damage +2", Shattering = "Might be", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });

            // ARMOR
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Ancient Magic Crystal - Cobelinus", ItemEffect = "Max HP +100 & Weight Limit +20LT", Shattering = "Low", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Black Magic Crystal - Cobelinus", ItemEffect = "Max HP +100 & Weight Limit + 20LT & Damage Reduction +2", Shattering = "N/A", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Red Battlefield Crystal - Comeliness", ItemEffect = "Max HP +100 & Weight Limit +20LT & Human Damage +2", Shattering = "Might be", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });

            // GLOVES
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Ancient Magic Crystal - Viper", ItemEffect = "Attack Speed & Casting Speed +1", Shattering = "Low", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Black Magic Crystal - Viper", ItemEffect = "Attack Speed & Casting Speed +1 & Accuracy +2", Shattering = "N/A", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Red Battlefield Crystal: Viper", ItemEffect = "Attack Speed & Casting Speed +1 & Human Damage +2", Shattering = "Might be", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });

            // SHOES
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Ancient Magic Crystal - Hystria", ItemEffect = "Weight Limit +20LT & Movement Speed +1", Shattering = "Low", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Black Magic Crystal - Hystria", ItemEffect = "Weight Limit +20LT & Movement Speed +1 & Endurance +150", Shattering = "N/A", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Red Battlefield Crystal - Hysteria", ItemEffect = "Weight Limit +20LT & Movement Speed +1 & Human Damage +2", Shattering = "Might be", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Orange.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Red Battlefield Crystal - Adamantite", ItemEffect = "Knockdown/Bound Resistance +25% & Stun/Stiffness/Freezing Resistance +5%", Shattering = "N/A", Rarity = Rarity.Orange.ToString(), Slot = Slot.Shoes.ToString(), Weight = 0.10f });

            // ALL EQUIPMENT

            // YELLOW CRYSTALS
            // WEAPON
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of Crimson Flame - Carnage", ItemEffect = "Beast Damage +4", Shattering = "Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of Crimson Flame - Demihuman", ItemEffect = "Demihuman Damage +4", Shattering = "Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of Crimson Flame - Human", ItemEffect = "Human Damage +4", Shattering = "Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of Crimson Flame - Power", ItemEffect = "AP +5", Shattering = "Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Carnage", ItemEffect = "Demihuman Damage +2 & Ignore All Resistane +10%", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Carnage", ItemEffect = "Human Damage +2 & Ignore All Resistane +10%", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Carnage", ItemEffect = "Beast Damage +2 & Ignore All Resistane +10%", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Power", ItemEffect = "Attack +2 & Ignore All Resistance +10%", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Precision", ItemEffect = "All Accuracy +2 & Ignore All Resistance +10%", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal - Agony", ItemEffect = "Critical Hit Rate +2 & Attack Speed -1", Shattering = "Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal - Crimson Flame", ItemEffect = "Critical Hit Rate +1", Shattering = "Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal - Destruction", ItemEffect = "Attack Speed +1", Shattering = "Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal - Enchantment", ItemEffect = "Casting Speed +1", Shattering = "Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Magic Crystal - Meditation", ItemEffect = "Casting Speed +2 & Critical Hit Rate -1", Shattering = "Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal - Temptation", ItemEffect = "Attack SPeed +2 & Critical Hit Rate -1", Shattering = "Low", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });

            // SECONDARY WEAPON

            // HELMET
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Ancient Magic Crystal of Enchantment - Agility", ItemEffect = "All Evasion +5", Shattering = "Low", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of Enchantment - Intimidation", ItemEffect = "Knockdown & Bound Resistance +25% & Evasion +3", Shattering = "Low", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of Enchantment - Vision", ItemEffect = "Evasion +3 & Vision Range +10m", Shattering = "Low", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of the Sun - Memory", ItemEffect = "Casting Speed +2", Shattering = "Low", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Agility", ItemEffect = "Evasion +2 & Knockdown/Bound Resistance +5%", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Black Magic Crystal - Experience", ItemEffect = "Combat EXP +10% & Knockdown/Bound Resistance +5%", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Intimidation", ItemEffect = "Knockdown/Bound Resistance +10% & Stun/Stiffnes/Freezing Resistance +5%", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Memory", ItemEffect = "Casting Speed +2 & Knockdown/Bound Resistance +5%", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Vision", ItemEffect = "Vision Range +15m & Knockdown/Bound Resistance +5%", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });

            // ARMOR
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal - Healing", ItemEffect = "Max HP +50 & HP Recovery +3", Shattering = "Low", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Ancient Magic Crystal of Abundance - Armor", ItemEffect = "Damage Reduction +5", Shattering = "Low", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of Abundance - Patience", ItemEffect = "Max MP/WP/SP +100", Shattering = "Low", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of Abundance - Resonance", ItemEffect = "Map MP/WP/SP +50 & MP/WP/SP Recovery +3", Shattering = "Low", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of Abundance - Vigor", ItemEffect = "Max HP +100", Shattering = "Low", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Healing", ItemEffect = "HP Recovery +5", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Patience", ItemEffect = "Max MP/WP/SP +50 & Stun/Stiffness/Freezing Resistance +10%", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Resonance", ItemEffect = "MP/WP/SP Recovery +5 & Stun/Stiffness/Freezing Resistance 10%", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Vigor", ItemEffect = "Max HP +50 & Stun/Stiffness/Freezing Resistance +10%", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });

            // GLOVES
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of the Sun - Assault", ItemEffect = "Attack Speed +2", Shattering = "Low", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of the Sun - Sturdiness", ItemEffect = "Grapple Resistance +25% & Fall Damage Reduction", Shattering = "Low", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of the Sun - Valor", ItemEffect = "Critical Hit Rate +2", Shattering = "Low", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Assault", ItemEffect = "Attack Speed +2 & Grapple Resistance +5%", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Boulder", ItemEffect = "Weight Limit +15LT & Grapple Resistance +5%", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Precision", ItemEffect = "All Accuracy +2 & Grapple Resistance +5%", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Sturdiness", ItemEffect = "Grapple Resistance +10% & Knockback/Floating Resistance +5%", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Valor", ItemEffect = "Critical Hit Rate +2 & Grapple Resistance +5%", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });

            // SHOES
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Ancient Magic Crystal of Nature - Adamantite", ItemEffect = "Knockdown Resistance & Bound Resistance +25%", Shattering = "Low", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of Nature - Mass", ItemEffect = "Weight Limit +50LT", Slot = Slot.Shoes.ToString(), Shattering = "Low", Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of Nature - Swiftness", ItemEffect = "Movement Speed +2", Shattering = "Low", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Adamantite", ItemEffect = "Knockback/Floating Resistance +10% & Knockdown/Bound Resistance +5%", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Ascension", ItemEffect = "Jump +35 & Knockback/Floating Resistance +10%", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Energy", ItemEffect = "Endurance +250", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Falling", ItemEffect = "Fall Damage -15% & Knockback/Floating Resistance +10%", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Swiftness", ItemEffect = "Movement Speed +2 & Knockback/Floating Resistance +5%", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });

            // ALL EQUIPMENT
            crystals.Add(new Crystal { Localization = "", Name = "Ancient Magic Crystal of Perfection", ItemEffect = "Luck +2", Shattering = "Low", Slot = Slot.Any.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Black Magic Crystal - Armor", ItemEffect = "Damage Reduction +2 & Stun/Stiffness/Freezing Resistance +10%", Shattering = "High", Slot = Slot.Any.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Perfection", ItemEffect = "Luck +1", Shattering = "High", Slot = Slot.Any.ToString(), Weight = 0.10f, Rarity = Rarity.Yellow.ToString() });

            // BLUE CRYSTALS
            // WEAPON
            crystals.Add(new Crystal { Localization = "", Name = "Magic Crystal of Infinity - Absorbation", ItemEffect = "HP Recovery +1 on Attack", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Carnage", ItemEffect = "Demihuman Damage +2", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Carnage", ItemEffect = "Human Damage +2", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Carnage", ItemEffect = "Beast Damage +2", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Durability", ItemEffect = "Durability Reduction Resistance +10%", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Extraction", ItemEffect = "MP/WP/SP Recovery +1 on Attack", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Power", ItemEffect = "AP +2", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Precision", ItemEffect = "All Accuracy +2", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });

            // SECONDARY WEAPON
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Air Attack", ItemEffect = "Air Attack Damage +1", Shattering = "High", Slot = Slot.Secondary.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Back Attack", ItemEffect = "Back Attack Damage +1", Shattering = "High", Slot = Slot.Secondary.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Counter Attack", ItemEffect = "Counter Attack Damage +1", Shattering = "High", Slot = Slot.Secondary.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Critical", ItemEffect = "Critical Hit Damage +1", Shattering = "High", Slot = Slot.Secondary.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Down Attack", ItemEffect = "Down Attack Damage +1", Shattering = "High", Slot = Slot.Secondary.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Ignore Grapple Resistance", ItemEffect = "Ignore Grapple Resistance +10%", Shattering = "High", Slot = Slot.Secondary.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Ignore Knockback Resistance", ItemEffect = "Ignore Knockback Resistance +10%", Shattering = "High", Slot = Slot.Secondary.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Ignore Stun", ItemEffect = "Ignore Stun Resistance +10%", Shattering = "High", Slot = Slot.Secondary.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Speed Attack", ItemEffect = "Speed Attack Damage +1", Shattering = "High", Slot = Slot.Secondary.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });

            // HELMET
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Agility", ItemEffect = "Evasion +2", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Experience", ItemEffect = "Combat EXP +10%", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Initmidation", ItemEffect = "Knockdown/Bound Resistance +10%", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Memory", ItemEffect = "Casting Speed +2", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Vision", ItemEffect = "Vision Range +15m", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });

            // ARMOR
            crystals.Add(new Crystal { Localization = "", Name = "Magic Crystal of Infinity - Energy", ItemEffect = "Max Stamina +150", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Evasion", ItemEffect = "Special Attack Evasion +10%", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Heal", ItemEffect = "HP Recovery +3", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Magic Defense", ItemEffect = "Magic Damage Reduction +2", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Melee Defense", ItemEffect = "Melee Damage Reduction +2", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Patience", ItemEffect = "Max MP/WP/SP +35", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Ranged Defense", ItemEffect = "Ranged Damage Reduction +2", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Resonance", ItemEffect = "MP/WP/SP Recovery +3", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Siege", ItemEffect = "Siege Weapon Evasion +10%", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Vigor", ItemEffect = "Max HP +35", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });

            // GLOVES
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Assault", ItemEffect = "Attack Speed +2", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Magic Attack", ItemEffect = "Magic AP +2", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Melee Attack", ItemEffect = "Melee AP +2", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Precision", ItemEffect = "All Accuracy +2", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Ranged Attack", ItemEffect = "Ranged AP +2", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Strength", ItemEffect = "Weight Limit +15LT", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Sturdiness", ItemEffect = "Grapple Resistance +10%", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Valor", ItemEffect = "Critical Hit Rate +2", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });

            // SHOES 
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Adamantite", ItemEffect = "Knockback/Floating Resistance +10%", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Ascension", ItemEffect = "Jump Height +35", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Energy", ItemEffect = "Stamina +150", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Falling", ItemEffect = "Fall Damage -15%", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Magic Crystal of Infinity - Submergence", ItemEffect = "Breath Gauge +15sec", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Swiftness", ItemEffect = "Movement Speed +2", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });

            // ALL EQUIPMENT
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Infinity - Armor", ItemEffect = "Damage Reduction +2", Shattering = "High", Slot = Slot.Any.ToString(), Weight = 0.10f, Rarity = Rarity.Blue.ToString() });

            // GREEN CRYSTALS
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Crimson Flame - Carnage", ItemEffect = "Demihuman Damage +1", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Crimson Flame - Carnage", ItemEffect = "Human Damage +1", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Crimson Flame - Carnage", ItemEffect = "Beast Damage +1", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Crimson Flame - Power", ItemEffect = "AP +1", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Crimson Flame - Precision", ItemEffect = "All Accuracy +1", Shattering = "High", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });

            // SECONDARY WEAPON
            //crystals.Add(new Crystal { Name = "", ItemEffect = "", Slot = Slot.Secondary.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });

            // HELMET
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Enchantment - Agility", ItemEffect = "Evasion +1", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Magic Crystal of Enchantment - Experience", ItemEffect = "Combat EXP +5%", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Enchantment - Intimidation", ItemEffect = "Knockdown/Bound Resistance +5%", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Enchantment - Memory", ItemEffect = "Casting Speed +1", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Enchantment - Vision", ItemEffect = "Vision Range +10m", Shattering = "High", Slot = Slot.Helmet.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });

            // ARMOR
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Abundance - Healing", ItemEffect = "HP Recovery +2", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Abundance - Patience", ItemEffect = "Max MP/WP/SP +25", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Abundance - Resonance", ItemEffect = "MP/WP/SP Recovery +2", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Abundance - Vigor", ItemEffect = "Max HP +25", Shattering = "High", Slot = Slot.Armor.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });

            // GLOVES
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of the Sun - Assault", ItemEffect = "Attack Speed +1", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of the Sun - Boulder", ItemEffect = "Weight Limit +10LT", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of the Sun - Precision", ItemEffect = "All Accuracy +1", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of the Sun - Sturdiness", ItemEffect = "Grapple Resistance +5%", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of the Sun - Valor", ItemEffect = "Critical Hit Rate +1", Shattering = "High", Slot = Slot.Gloves.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });

            // SHOES
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Nature - Adamantite", ItemEffect = "Knockback/Floating Resistance +5%", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Nature - Ascension", ItemEffect = "Jump Height +25", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Nature - Energy", ItemEffect = "Stamina +100", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "", Name = "Magic Crystal of Nature - Falling", ItemEffect = "Fall Damage -10%", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Nature - Swiftness", ItemEffect = "Movement Speed +1", Shattering = "High", Slot = Slot.Shoes.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });

            // ALL EQUIPMENT
            crystals.Add(new Crystal { Localization = "EU/NA", Name = "Magic Crystal of Abundance - Armor", ItemEffect = "Damage Reduction +1", Shattering = "High", Slot = Slot.Any.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            crystals.Add(new Crystal { Name = "Magic Crystal of Abundance - Relaxation", ItemEffect = "Additional Damage against 'Ferocious' Monsters +1", Shattering = "High", Slot = Slot.Any.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });

            //crystals.Add(new Crystal { Name = "", ItemEffect = "", Slot = Slot.Weapon.ToString(), Weight = 0.10f, Rarity = Rarity.Green.ToString() });
            return crystals.OrderBy(c => c.Slot).ToList();
        } 
    }
}