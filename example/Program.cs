using System.Collections.Generic;
using Purity;
using System.Runtime.Serialization;
using BetterEventSystem;
using SurviveOvernight.Items;

namespace SurviveOvernight;

[SerializableAttribute]
internal class Program {
    
    public class Entity {
        public int health;
        public int maxHealth;
        public int damage;
        public int speed;
        public DrawableShape sprite;
    }

    public class Enemy : Entity { 
        public Enemy(int health, int maxHealth, int damage, int speed, DrawableShape sprite) {
            this.health = health;
            this.maxHealth = maxHealth;
            this.damage = damage;
            this.speed = speed;
            this.sprite = sprite;
        }
    }

    public class Player : Entity {
        public int charm;
        public List<Item> inventory = new List<Item>();

        public Player(int maxHealth, int damage, int speed, DrawableShape sprite, int health = 0) {
            this.maxHealth = maxHealth;
            this.health = (health == 0) ? maxHealth : health;
            this.sprite = sprite;
            this.damage = damage;
            this.speed = speed;
        }

        public void give(string id) {
            try {
                this.inventory.Add(Items.Items.getItem(id));
            }
            catch(Exception e) {
                Logger.Warn("cannot obtain item, item id is invalid");
            }

        }
    }

    static Player player;
    
    static void Main(string[] args) {
        DrawableText text = new DrawableText("Welcome to this crazy kids game");

        player = new Player(
            6,
            1,
            20,
            new DrawableShape(
                Shape.CIRCLE,
                new Vector2D(),
                40
            )
        );


        EventSystem.GetEvent("window_create").AddListener((e) => {
            Window window = (Window) e.data;
            window.drawables.Add(text);
        });

        EventSystem.GetEvent("before_render").AddListener((e) => {

        });

        new Window(
            title: "Survive Overnight"
        );
    }
}