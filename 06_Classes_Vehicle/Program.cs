//! Classes
/*
    - Custom objects in C#
    - Have properties and methods.
        - Properties: Variables that exist in the entire class

    Key words:
        - public: can be accessed by any other code in the same assembly or another assembly that reference it.
        - private: can only be accessed in the same class or struct
        - protected: can be accessed only by code in the same class, or in a class that is derived from that class.
        - internal: type or member can be accessed by any code in the same assembly, but not from another assembly.
        - protected interanl: can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.
        - private protected: can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.

    Structs:
        - used from small data-centric types with little or no behavior.
*/

Vehicle vehicle = new Vehicle();
vehicle.Model = "Journey";
System.Console.WriteLine($"I drive a {vehicle.Model}. Its make is {vehicle.Make}.");
vehicle.Make = "Dodge";
vehicle.Mileage = 7500;
System.Console.WriteLine($"I drive a {vehicle.Make} with {vehicle.Mileage} miles on it.");
vehicle.VehicleType = VehicleType.Car;

/*
! Enums
    Each item in an enum needs to have a unique index value. The default value will alway be zero
*/
public enum VehicleType {
    Car = 1, // The index defaults to zero; however we can set our index as such.
    Truck,
    Van,
    Motorcycle,
    Spaceship,
    Plane,
    Boat
}


public class Vehicle { // We have created this new data type that we can now use.

    /*
    !   Properties
            set: (setters)
                - allows us to set attributes to the object we are creating.
                - can have a default value
            get: (getters)
                - allows us to view (get) a value of a property within our object.

            Can be set a null value.
    */

    public string Make {get; set;} = "Unknown Manufacturer"; // setting a default value to our property "Make".
    //* prop - emmet for creating a property
    public string Model { get; set; }
    public double? Mileage { get; set; } // placing a ? denotes that it may be a null value.
    public int Year { get; set; }
    public VehicleType VehicleType { get; set; } // our enum property

}