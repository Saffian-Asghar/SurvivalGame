using System.Collections.Generic;
using UnityEngine;

class Character : MonoBehaviour
{

    // attributs
    private string name;
    private int Health;
    private int maxHealth;
    private int stamina;
    private int maxStamina;
    private bool alive;
    private short speed;
    private short maxSpeed;
    private Vector3 coordinate;
    private List<Item> itemList;
    private List<Weapon> weaponList;
    private HealthBar healthBar;

    // constructors
    public Character()
    {
        this.name = "unknown";
        this.Health = 100;
        this.maxHealth = 100;
        this.stamina = 100;
        this.maxStamina = 100;
        this.alive = true;
        this.speed = 0;
        this.maxSpeed = 10;
        this.weaponList = new List<Weapon>();
        this.itemList = new List<Item>();
        this.coordinate = new Vector3(Random.Range(0.0f, float.MaxValue), Random.Range(0.0f, float.MaxValue), Random.Range(0.0f, float.MaxValue));
    }

    // getters
    public string getName() { return this.name; }
    public int getHealth() { return this.Health; }
    public int getMaxHealth() { return this.maxHealth; }
    public int getStamina() { return this.stamina; }
    public int getMaxStamina() { return this.maxStamina; }
    public bool isAlive() { return this.alive; }
    public short getSpeed() { return this.speed; }
    public short getMaxSpeed() { return this.maxSpeed; }
    public Vector3 getCoordinate() { return this.coordinate; }
    public List<Item> getItemList() { return this.itemList; }
    public List<Weapon> getWeaponList() { return this.weaponList; }

    // setters

    public void setName(string s)
    {
        if (string.IsNullOrEmpty(s) == false)
            this.name = s;
        else
            this.name = "Unknown";
    }
    public void setHealth(int h)
    {
        if (h >= 0 & h <= this.maxHealth)
            this.Health = h;
    }

    public void setMaxHealth(int h)
    {
        if (h >= 0)
            this.maxHealth = h;

    }
    public void setStamina(int s)
    {
        if (s >= 0 & s <= this.maxStamina)
            this.stamina = s;
    }

    public void setMaxStamina(int s)
    {
        if (s >= 0)
            this.maxStamina = s;
    }
    public void setAlive(bool b) { this.alive = b; }
    public void setSpeed(short s)
    {
        if (s >= 0 & s <= this.maxSpeed)
            this.speed = s;
    }
    public void setMaxSpeed(short s)
    {
        if (s >= 0)
            this.maxSpeed = s;
    }
    public void setCoordinate(Vector3 v)
    {
        if (v != null)
            this.coordinate = v;
    }
    public void setItemList(List<Item> l)
    {
        if (l != null)
            this.itemList = l;
    }
    public void setWeaponList(List<Weapon> l)
    {
        if (l != null)
            this.weaponList = l;
    }

    // functions

    // Start is called before the first frame update
    void Start()
    {
        Health = maxHealth;
        healthBar.SetMaxHealth(this.maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        this.Health -= damage;

        this.healthBar.SetHealth(this.Health);
    }

}