using ChestOrMonster.Interface;


namespace ChestOrMonster.Model.Item
{
    internal class Bow : Weapon
    {
        public string Name { get; private set; }
        public double Damage { get; private set; }

        //public Bow ()
        //{
        //    Name = "Лук";
        //    Damage = 17;
        //}
    }
}