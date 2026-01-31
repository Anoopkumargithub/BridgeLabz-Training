using System;

// flight validation, passenger capacity checks, and fuel level verification.

internal class Flight
{
    private string flightNumber;
    private int passengerCapacity;
    private double fuelLevel;

    // getter setter

    public string FlightNumber
    {
        get {return flightNumber;}
        set {flightNumber = value;}
    }

    public int PassengerCapacity
    {
        get {return passengerCapacity;}
        set {passengerCapacity = value;}
    }

    public double FuelLevel
    {
        get {return fuelLevel;}
        set {fuelLevel = value;}
    }

    public Flight(string flightNumber, int passengerCapacity, double fuelLevel)
    {
        this.flightNumber = flightNumber;
        this.passengerCapacity = passengerCapacity;
        this.fuelLevel = fuelLevel;
    }

}