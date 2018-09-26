using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    class MeleeUnits : Unit
    {


        public int Xpos
        {
            get { return X_position; }
            set { X_position = value; }
        }
        public int Ypos
        {
            get { return Y_position; }
            set { Y_position = value; }
        }
        public int health
        {
            get { return Health; }
            set { Health = value; }
        }
        public int attack
        {
            get { return Attack; }
            set { Attack = value; }
        }
        public int attackRange
        {
            get { return Attack_range; }
            set { Attack_range = value; }
        }
        public int speed
        {
            get { return Speed; }
            set { Speed = value; }
        }
        public string Fact
        {
            get { return Faction; }
            set { Faction = value; }
        }
        public string Pic
        {
            get { return Image; }
            set { Image = value; }
        }




        public override int NewMovePos()
        {

            return NewMovePos();

        }
        public override int Combat()
        {
            return Combat();
        }
        public override int AttackRange()
        {
            return AttackRange();
        }
        public override int UnitDistance()
        {
            return UnitDistance();
        }
        public override int Death()
        {
            return Death();
        }
        public override string ToString()
        {
            return ToString();
        }
    }
}
