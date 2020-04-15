using UnityEngine;

namespace DapperDino.Tutorials.Inheritance
{
    public class InheritanceExample : MonoBehaviour
    {
        private void Start()
        {
            Item item = new Weapon("Sword");

            item.Use();
        }
    }

    public class Item
    {
        protected readonly string name;

        public Item(string name)
        {
            this.name = name;
        }

        public virtual void Use()
        {
            Debug.Log($"Using {name}");
        }
    }

    public class Weapon : Item
    {
        public Weapon(string name) : base(name) { }

        public override void Use()
        {
            Debug.Log($"Swinging {name}");
        }
    }
}
