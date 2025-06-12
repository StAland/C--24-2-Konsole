namespace RPG_Klassen
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public Entity(string name, int maxHP, int attack, int defense)
        {
            Name = name;
            MaxHP = maxHP;
            HP = maxHP;
            Attack = attack;
            Defense = defense;
        }

        public virtual void TakeDamage(int amount)
        {
            int damage = Math.Max(amount - Defense, 0);
            HP -= damage;
            HP = Math.Max(HP, 0);
            Console.WriteLine($"{Name} takes {damage} damage. HP left: {HP}");
        }

        public bool IsDead()
        {
            return HP <= 0;
        }
    }
}
