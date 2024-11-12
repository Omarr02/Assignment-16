using UnityEngine;

namespace Assignment18
{
    public struct Position
    {
        public float X;
        public float Y;
        public float Z;

        public Position(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public void printPosition()
        {
            Debug.Log($"Position: X={X}, Y={Y}, Z={Z}");
        }
    }
    public class Character
    {
        public string name;
        private int health;
        protected Position position;

        public int Health
        {
            get => health;
            set => health = Mathf.Clamp(value, 0, 100);
        }

        public Character(string name, int health, Position position)
        {
            this.name = name;
            Health = health;
            this.position = position;
        }

        public Character() : this("No name", 100, new Position(0, 0, 0)) { }

        public virtual void DisplayInfo()
        {
            Debug.Log($"Name: {name}, Health: {Health}");
            position.printPosition();
        }

        public void Attack(int damage, Character target)
        {
            ApplyDamage(damage, target);
        }

        public void Attack(int damage, Character target, string attackType)
        {
            Debug.Log($"Attack Type: {attackType}");
            ApplyDamage(damage, target);
        }

        private void ApplyDamage(int damage, Character target)
        {
            target.Health -= damage;
            Debug.Log($"{target.name} took {damage} damage! Remaining Health: {target.Health}");
        }
    }
    public class Soldier : Character
    {
        public Soldier(string name, int health, Position position) : base(name, health, position) { }

        public Soldier() : base() { }

        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }
    public class Officer : Character
    {
        public Officer(string name, int health, Position position) : base(name, health, position) { }

        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }
    }
}
