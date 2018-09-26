using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    abstract class Unit
    {
        protected int X_position;
        protected int Y_position;
        protected int Health;
        protected int Speed;
        protected int Attack;
        protected int Attack_range;
        protected string Faction;
        protected string Image;

        public Unit() { }
        abstract public int NewMovePos();
        abstract public int Combat();
        abstract public int AttackRange();
        abstract public int UnitDistance();
        abstract public int Death();
        abstract public string ToString();
    }
}
