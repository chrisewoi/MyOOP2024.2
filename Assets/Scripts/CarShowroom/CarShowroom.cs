using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarShowroom : MonoBehaviour
{
    void Start()
    {
        //new ClassName() <--- Makes an object out of the class
        FM1Car AnthonyCar = new FM1Car("Anthony", "Red", 300f);
        Tank DomCar = new Tank("Dom", "Green", 20f);
        Tank AndrewCar = new Tank("Andrew", "Pink", 77f);

        Race(AnthonyCar, DomCar);
        AnthonyCar.EnableHoverMode();
        Race(AnthonyCar, DomCar);
        DomCar.Shoot(AnthonyCar);
        AndrewCar.Shoot(DomCar);
        Race(AnthonyCar, DomCar);
    }

    void Race(Car car1, Car car2)
    {
        if(car1.speed > car2.speed)
        {
            Debug.Log("HERE IS YOUR WINNER: " + car1.VictorySpeech());
        }
        else
        {
            Debug.Log("HERE IS YOUR WINNER: " + car2.VictorySpeech());
        }
    }
}
