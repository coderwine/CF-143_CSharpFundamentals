/*
!   Methods
    - blocks of code that provide us functionality to our object.

    Structure:
    ex:       1      2     3       4
            public void MethodName( )
            {
                5
                ... executed code
            }

        1. Access Modifier
        2. Return
        3. Method Name (this can be whatever you want)
        4. Body
*/

Vehicle vehicle = new Vehicle();
vehicle.Model = "Journey";
System.Console.WriteLine($"I drive a {vehicle.Model}. Its make is {vehicle.Make}.");
vehicle.Make = "Dodge";
vehicle.Mileage = 7500;
System.Console.WriteLine($"I drive a {vehicle.Make} with {vehicle.Mileage} miles on it.");
vehicle.VehicleType = VehicleType.Car;

//**********************************************
// New variables

vehicle.TurnOn();
System.Console.WriteLine($"The {vehicle.Make} is on: {vehicle.IsRunning}");

vehicle.TurnOff();
System.Console.WriteLine($"The {vehicle.Make} is on: {vehicle.IsRunning}");

vehicle.IndicateRight();
vehicle.IndicateLeft();

vehicle.TurnOnHazards();
vehicle.IndicatorClear();

// vehicle.CanDrive();
// vehicle.CantDrive();

vehicle.Drive();
vehicle.TurnOn();
vehicle.Drive();

//**********************************************

public enum VehicleType {
    Car = 1,
    Truck,
    Van,
    Motorcycle,
    Spaceship,
    Plane,
    Boat
}


public class Vehicle {

    public string Make {get; set;} = "Unknown Manufacturer";
    public string Model { get; set; }
    public double? Mileage { get; set; }
    public int Year { get; set; }
    public VehicleType VehicleType { get; set; }

    public bool IsRunning { get; private set;} // Private statethat we will only be able to modify the "setter" of this property from within the Vehicle Class.

    public bool RightIsFlashing { get; set; }
    public bool LeftIsFlashing { get; set; }
    
    //* Method
    public void TurnOn()
    {
        /*
            We are returning void as there isn't a value that we are technically returning. In this case, we are simply writing to the console but not altering anything outside of this class.
        */
        IsRunning = true; // changing the setter of our IsRunning property to true.
        System.Console.WriteLine("The vehicle is on.");
    }

    public void TurnOff()
    {
        IsRunning = false;
        System.Console.WriteLine("The vehicle is off");
    }

    public void IndicateRight()
    {
        RightIsFlashing = true;
        LeftIsFlashing = false;
        System.Console.WriteLine("Right blinker on");
    }

    public void IndicateLeft()
    {
        LeftIsFlashing = true;
        RightIsFlashing = false;
        System.Console.WriteLine($"Is right blinker on? {RightIsFlashing}");
        System.Console.WriteLine("Left blinker on");
    }

    public void TurnOnHazards()
    {
        LeftIsFlashing = true;
        RightIsFlashing = true;
        System.Console.WriteLine("Hazards are on.");
    }

    public void IndicatorClear()
    {
        LeftIsFlashing = false;
        RightIsFlashing = false;
        System.Console.WriteLine("Indicator cleared");
    }

    //!CHALLENGE
    /*
        Create a drive method that checks to see if the the vehicle is running. If it is, WriteLine that it is moving forward. If it is not, remind the driver to turn on the vehicle.
    */

    public void Drive()
    {
        // if (vehicle.IsRunning == true)
        if (IsRunning)
        {
            System.Console.WriteLine("The vehicle is moving");
        }
        else
        {
            System.Console.WriteLine("Don't forget to turn the vehicle on.");
        }
    }

    // public void CanDrive()
    // {
    //     IsRunning = true;
    //     System.Console.WriteLine($"Is the car on? {IsRunning}");

    //     System.Console.WriteLine("The car is moving forward.");
    // }

    // public void CantDrive()
    // {
    //     IsRunning = false;
    //     System.Console.WriteLine($"Is the car on? {IsRunning}");

    //     System.Console.WriteLine("You can't drive with the car off. Turn it on.");
    // }



}