using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace AeroVigil
{
    public class FlightUtils
    {

        // FlightName and its corresponding passenger capacity
         private static readonly Dictionary<string, int> PassengerCapacity =
            new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                { "SpiceJet", 396 },
                { "Vistara", 615 },
                { "IndiGo", 230 },
                { "Air Arabia", 130 }
            };
        
        // FlightName and its corresponding fuel capacity
        private static readonly Dictionary<string, double> Flights = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
        {
           { "SpiceJet", 200000 },
           { "Vistara", 300000 },
           { "IndiGo", 250000 },
           { "Air Arabia", 150000 }
        };

        // validate the FlightNumber
        public bool ValidateFlightNumber(string flightNumber)
        {
            string pattern = @"FL-[1-9][0-9]{3}";
            if(Regex.IsMatch(flightNumber, pattern))
            {
                return true;
            }
            else
            {
                throw new InvalidFlightException($"The flight number {flightNumber} is invalid.");
            }
        }


    // validate flightName
        public bool ValidateFlightName(string flightName)
        {
            if (Flights.ContainsKey(flightName))
            {
                return true;
            }
            else
            {
                throw new InvalidFlightException($"The flight name {flightName} is invalid.");
            }
        }

        // validate Passenger Count
        public bool ValidatePassengerCount(int passengerCount, String flightName)
        {
            if(passengerCount <= 0 || passengerCount > PassengerCapacity[flightName])
            {
                throw new InvalidFlightException($"The passenger count {passengerCount} is invalid for {flightName}.");
            }
            return true;
        }


        // Calculate Fuel to Fill Tank
        public double CalculateFuelToFillTank(string flightName, double currentFuelLevel)
        {
            double requiredFuel = Flights[flightName];
            if(currentFuelLevel < 0 || currentFuelLevel > requiredFuel)
            {
                throw new InvalidFlightException($"The current fuel level {currentFuelLevel} is invalid for {flightName}.");
            }
            return requiredFuel - currentFuelLevel;
        }


    }
}