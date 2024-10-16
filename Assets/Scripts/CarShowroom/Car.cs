using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Car
{
    //private only this class can access
    //protected is like private, but children can access
    //public anyclass can access it (its for the people)
    private string owner = "";
    protected string colour =  "red";

    public float speed = 5;

    
    public Car(string Owner, string Colour, float Speed)
    {
        owner = Owner;
        colour = Colour;
        speed = Mathf.Clamp(Speed, 2f, 100f);
    }

    public void PrintColour()
    {
        Debug.Log( owner + "'s Car is " + colour );
    }

    public string VictorySpeech()
    {
        return Owner() + " proves that the colour " + colour + " is the faster colour";
    }

    public virtual string Owner()
    {
        return owner;
    }

    public abstract string Honk();
}

public class Tank : Car
{
    public Tank(string Owner, string Colour, float Speed) : base(Owner, Colour, Speed)
    {
    }
    public override string Owner()
    {
        //"base" calls the function in the parent
        return base.Owner() + " IS AN INSANE PERSON";
    }

    public void Shoot(Car car)
    {
        car.speed = 0;
        Debug.Log(car.Owner() + "'s car: " + car.Honk());
    }

    public override string Honk()
    {
        return "BOOM";
    }
}

public class FM1Car : Car
{
    public override string Honk()
    {
        return "VRroommmmm";
    }

    public void EnableHoverMode()
    {
        speed = speed * 2;
    }

    public FM1Car(string Owner, string Colour, float Speed) : base(Owner, Colour, Speed)
    {

    }

}