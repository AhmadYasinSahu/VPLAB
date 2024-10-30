using System;

public class User
{
    public int userID = 0;
    public string Name { get; set; }
    public String phoneNumber { get; set; }

    List<User> users = new List<User>();
    public void register()
    {
        ++userID;

        Console.WriteLine(" Enter your Name : ");
        string name = Console.ReadLine();

        Console.WriteLine(" Enter your Phone Number : ");
        string phoneNum = Console.ReadLine();

        Console.WriteLine(" User regustered successfully. ");
        Console.ReadLine();
    }
    public void Login()
    {
        Console.WriteLine(" Enter your Id : ");
        int id = Convert.ToInt32(Console.ReadLine());
        var user = users.Find(u => u.userID == id);

        if (user == null)
            Console.WriteLine("User not found!");
        else
            Console.WriteLine("User  found!");
        Console.WriteLine("Login successfully.");
        Console.ReadLine();
    }

    public void displayProfile()
    {
        Console.WriteLine(" Enter your Id : ");
        int id = Convert.ToInt32(Console.ReadLine());
        var user = users.Find(u => u.userID == id);

        if (user != null)
            Console.WriteLine($"User Id : {user.userID} User Name : {user.Name} , User Phone Number : {user.phoneNumber}");
       
        Console.ReadLine();
    }

}

public class Driver : User
{
    public int driverID { get; set; }
    public string vehicleDetails { get; set; }

    public bool isAvailable = false;
    public List<Trip> tripHistory;

    public void viewTripHistory()
    {
        foreach (var r in tripHistory)
        {
            Console.WriteLine($" Trip ID :{r.tripID} ,  Rider Name : {r.riderName} ,  Driver Name : {r.driverName}  ,  Start Location : {r.startLocation}  ,  Destionation : {r.destination} , Status : {r.status} , Fare : {r.fare}");
        }
    }
    public void acceptRide()
    {
        Trip t = new Trip();
        if (isAvailable)
        {
            Console.WriteLine($"Driver {t.driverName} accepted the ride request from {Name}.");
        }
        else
        {
            Console.WriteLine($"Driver  {t.driverName} not accepted the ride request from {Name}.");
        }
    }

   public bool  toggleAvailability()
    {
       
        if (driverID != 0)
            isAvailable = true;
        else
            isAvailable = false;

        return isAvailable;
    }

}
public class Rider : User
{
    public List<Trip> rideHistory;
    
    public void requestRide()
    {
        Trip t = new Trip() ;
        Console.WriteLine(" Enter your current Location: ");
         t.startLocation= Console.ReadLine();

        Console.WriteLine(" Enter your Destination: ");
        t.destination = Console.ReadLine();

        rideHistory.Add(t);

        Console.WriteLine(" Ride requested successfully! ");
        Console.ReadLine();

    }
    public void viewRideHistory()
    {
       foreach(var r in rideHistory)
        {
            Console.WriteLine($" Trip ID :{r.tripID}  from: {r.startLocation}  , To: {r.destination} ,  Fare : { r.fare}");
        }
    }
}

public class Trip
{
    public int tripID { get; set; }
    public string riderName { get; set; }
    public string driverName { get; set; }
    public string startLocation { get; set; }
    public string destination { get; set; }
    public bool status = false;
    public int fare { get; set; }

    public void calculatefare()
    {
        if (status)
        {

            fare = fare + 2;
        }    
    }
    public void startTrip()
    {
        if (status)
        {
        Console.WriteLine($"Trip started from : { startLocation}");
        }
    }
    public void endTrip()
    {
        if (status)
        {
            Console.WriteLine($"Trip ended at :{endTrip} ");
        }
    }
    public void displayTripDetails()
    {
       
            Console.WriteLine($" Trip ID :{tripID} ,  Rider : {riderName} ,  Driver : {driverName}  ,  From : {startLocation}  ,  To : {destination} , Fare : {fare}");
        
    }
  
}
public class RideSharingSystem{
    public List<Rider> riders;
    public List<Trip> trips;
    public List<DriveInfo> drives;

    public void registerUser()
    {
        User user = new User();
       
        user.register();


    }
    public bool findAvailableDriver()
    {
        Driver driver = new Driver();
        driver.isAvailable = true;
        return true;
    }

    public void completeTrip()
    {
        Trip trip = new Trip();
        trip.endTrip();
        
    }
    public void RequestRide()
    {
        Rider r = new Rider();
        r.requestRide();
    }
    public void displayAllTrips()
    {
        foreach(Trip t in trips)
        {
            Console.WriteLine($" Trip ID :{t.tripID} ,  Rider : {t.riderName} ,  Driver : {t.driverName}  ,  From : {t.startLocation}  ,  To : {t.destination} , Fare : {t.fare}");
        }
    }
}
class program
{
    static void Main(string[] args)
    {
        User user = new User();
        Driver driver = new Driver(); 
        Rider rider = new Rider();
        Trip trip = new Trip();
        RideSharingSystem RSS= new RideSharingSystem();
        trip.status = true;
        while (true) { 
        Console.WriteLine(" \n\n\t\t\t\t Welcome to the Riding-Sharing System ");

        Console.WriteLine("\n\t 1.Register as Rider ");

        Console.WriteLine("\n\t 2.Register as Driver ");

        Console.WriteLine("\n\t 3.Request a Ride (Rider) ");

        Console.WriteLine("\n\t 4.Accept a Ride (Driver)");

        Console.WriteLine("\n\t 5.Complete a Trip (Driver)");

        Console.WriteLine("\n\t 6.View Ride History (Rider)");

        Console.WriteLine("\n\t 7.View Trip History (Driver)");

        Console.WriteLine("\n\t 8.Display all Trips ");

        Console.WriteLine("\n\t 9.Exit");

        Console.WriteLine("\n\t Please Choice an option");
        int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    user.register();
                    break;
                case 2:
                    driver.register();
                    break;
                case 3:
                    rider.requestRide();
                    break;
                case 4:
                    driver.acceptRide();
                    break;
                case 5:
                    RSS.RequestRide();
                    break;
                case 6:
                    rider.viewRideHistory();
                    break;
                case 7:
                    trip.displayTripDetails();
                    break;
                case 8:
                    RSS.displayAllTrips();
                    break;
                case 9:
                    break;
                default:
                    Console.WriteLine(" Invalid Entry!");
                    break;
            }
        }
    }
}
