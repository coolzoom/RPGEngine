﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puskaric.RoleplayingGameLibrary
{
    public class Archer : CharacterBase
    {
        public Archer(string name)
                : this(name, GameConstants.Instance.PlayerHitpoints)
        {

        }

        public Archer() 
                : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                      GameConstants.Instance.PlayerHitpoints)
        {

        }

        public Archer(string name, int health)
        {
            this.CharacterClass = "Archer";
            this.attackBehavior = new BowAttack();
            this.Name = name;
            this.Health = health;
        }
    }
}
