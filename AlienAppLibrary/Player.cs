﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienAppLibrary
{
    public class Player : Character
    {
        public Weapon EquippedWeapon { get; set; }
        public int Kills { get; set; }

        public Player(int life, int maxLife, int block, int hitChance, int speed, Weapon equippedWeapon, string name, int kills) : base(life, maxLife, block, hitChance, speed, name)
        {
            EquippedWeapon = equippedWeapon;
            Kills = kills;
        }

        public override string ToString()
        {
            return string.Format($"Stats\nLife: {Life}/{MaxLife}\n" +
                $"Weapon: {EquippedWeapon}\n{(Kills == 1 ? $"You have {Kills} kill. When will it end?" : Kills == 0 ? "You have no kills." : $"You have {Kills} kills. When will it end?")}");
        }

        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }
    }
}
