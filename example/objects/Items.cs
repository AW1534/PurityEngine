namespace SurviveOvernight.Items;

public class Item {
        public string name;
        public string id;
        public string desc;
    }

public class Weapon : Item {
    public int damage;
    public float attackInterval;
    public bool splash;
    public float splashRadius;
    public bool ranged;

    public Weapon(string name, string id, string desc = "null", int damage = 1,
                    float attackInterval = 1,
                    bool splash = false,
                    bool ranged = false,
                    float splashRadius = 0) {
        this.name = name;
        this.id = id;
        this.desc = desc;
        this.damage = damage;
        this.attackInterval = attackInterval;
        this.splash = splash;
        this.splashRadius = splashRadius;
        this.ranged = ranged;
    }
}

public class Consumables : Item {
    public Consumables(string name, string id, string desc) {
        this.name = name;
        this.id = id;
        this.desc = desc;
    }
    public void use() {
    }
}

public static class Items {
    public static Item getItem(string id) {
        switch(id) {
            case "textbook":
                return (new Weapon(
                    "Textbook",
                    "textbook",
                    "It appears the mitochondria is the powerhouse of the cell",
                    5,
                    0.5f,
                    false,
                    false
                ));
                break;

            case "dictionary":
                return (new Weapon(
                    "Dictionary",
                    "dictionary",
                    "oxford english dictionary",
                    10,
                    2,
                    true,
                    false
                ));
                break;

            case "mop":
                return (new Weapon(
                    "Mop",
                    "mop",
                    "A janitors signiture weapon",
                    7,
                    1.5f,
                    true,
                    false
                ));
                break;

        }
        return null;
    }
}