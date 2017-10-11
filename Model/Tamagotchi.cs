using System.Collections.Generic;

namespace TamagotchiApp.Models
{
  public class Tamagotchi
  {
    private string _name;
    private int _food = 100;
    private int _happiness = 100;
    private int _rest = 100;
    private int _death = 0;

    private static Tamagotchi _myTama = null;

    //constructor
    public Tamagotchi (string name)
    {
      _name = name;
    }

    public void Save()
    {
      if (_myTama == null)
      {
        _myTama = this;
      }
    }

    public static Tamagotchi GetTama()
    {
      return _myTama;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetFood()
    {
      return _food;
    }
    public void GiveFood()
    {
      _food += 10;
      _happiness -= 10;
      _rest -= 30;
    }
    public void SetFood(int newFood)
    {
      _food = newFood;
    }
    public int GetHappiness()
    {
      return _happiness;
    }
    public void GiveHappiness()
    {
      _happiness += 10;
      _food -= 10;
      _rest -= 30;
    }
    public void SetHappiness(int newHappiness)
    {
      _happiness = newHappiness;
    }
    public int GetSleep()
    {
      return _rest;
    }
    public void GiveSleep()
    {
      _rest += 10;
      _food -= 30;
      _happiness -= 10;
    }
    public void SetSleep(int newRest)
    {
      _rest = newRest;
    }
    public int GetDeath()
    {
      return _death;
    }
    public void GiveDeath()
    {
      _rest -= 100;
      _food -= 100;
      _happiness -= 100;
    }
    public void SetDeath(int newDeath)
    {
      _death = newDeath;
    }
  }
}
