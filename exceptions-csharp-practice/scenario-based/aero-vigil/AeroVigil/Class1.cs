namespace AeroVigil;

public class Class1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to AeroVigil!");
        Console.WriteLine("Enter the Flight Details: ");

        try
        {
            string input = Console.ReadLine();
            string[] flightDetails = input.Split(':');

            string flightNumber = flightDetails[0];
            string flightName = flightDetails[1];
            int passengerCount = int.Parse(flightDetails[2]);
            double fuelLevel = double.Parse(flightDetails[3]);

            Flight flight = new Flight(flightNumber, passengerCount, fuelLevel);
            FlightUtils flightUtils = new FlightUtils();

            flightUtils.ValidateFlightNumber(flightNumber);
            flightUtils.ValidateFlightName(flightName);
            flightUtils.ValidatePassengerCount(passengerCount, flightName);
            
            Console.WriteLine("Flight details are valid.");
            
            double requiredFuel = flightUtils.CalculateFuelToFillTank(flightName, fuelLevel);
            Console.WriteLine($"Required fuel level for {flightName} is {requiredFuel} liters.");
        }catch (InvalidFlightException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

    }
}
