

using System;

public class Customer
{   
    public int customerID;
    public string firstName;
    public string lastName;
    public string street;
    public string city;
    public string state;
    public string zipCode;
    public string  phone;
    public string eMail;
    public string Password;

    public Customer() {
        customerID = 1;
        firstName = "Ahmad";
        lastName = "Yasin";
        street = "near grossy plot";
        city = "Multan";
        state = " Pakistan";
        zipCode = "6000";
        phone = "03443277755";
        eMail = " 233605@students.au.edu.pk";
        Password = " 0000";
    

    }
    public Customer(int customerID, string firstName, string lastName, string street, string city, string state, string zipCode,string phone,string eMail,string password)
    {
        this.customerID =customerID;
        this.firstName =firstName;
        this.lastName =lastName;
        this.street =street;
        this.city = city;
        this.state =state;
        this.zipCode =zipCode;
        this.phone =phone;
        this.eMail =eMail;
        this.Password =password;

    }
}
     
public class RetailCustomer : Customer
{
    public string creditCardType;
    public long creditCardNumber;

    public RetailCustomer()
    {
        creditCardType = "Nothing";
        creditCardNumber = 0101;
    }
    public RetailCustomer(string creditCardType, long creditCardNumber)
    {
        this.creditCardType = creditCardType;
        this.creditCardNumber = creditCardNumber;
    }
}

public class Reservation
{
    public int reservationNo;
    public DateTime date;
    public string status;

    public Reservation()
    {
        reservationNo = 23;
        status = " On the way.";

    }
    public Reservation(int reservationNo,string status)
    {
        this.reservationNo = reservationNo;
        this.status = status;
    }

    public class Seat
    {
        public int rowNo;
        public int seatNo;
        public double price;
        public string status;
        public Reservation Reservation { get; set; }
        public Seat()
        {
            rowNo = 2;
            seatNo = 8;
            price = 250.50;
            status = " On the way.";
        }
        public Seat(int rowNo, int seatNo, double price, string status)
        {
            this.rowNo = rowNo;
            this.seatNo = seatNo;
            this.price = price;
            this.status = status;
        }
    }

    public class Flight
    {
        public int flightID;
        public DateTime date;
        public string origin;
        public string destination;
        public TimeOnly departureTime;
        public TimeOnly arrivalTime;
        public int seatingCapacity;

        public Flight()
        {
            flightID = 605;
            origin = " NMU";
            destination = "Air University Multan Campus";
            seatingCapacity = 72;

        }
        public Flight(int flightID, string origin, string destination, int seatingCapacity)
        {
            this.flightID = flightID;
            this.origin = origin;
            this.destination = destination;
            this.seatingCapacity = seatingCapacity;
        }
    }
    public class CorporateCustomer : Customer
    {
        public string campanyName;
        public string frequentFlyerPts;
        public string billingAccountNo;

        public CorporateCustomer()
        {
            campanyName = "Rado";
            frequentFlyerPts = " Nothing";
            billingAccountNo = " 112233";
        }
        public CorporateCustomer(string campanyName, string frequentFlyerPts, string billingAccountNo)
        {
            this.campanyName = campanyName;
            this.frequentFlyerPts = frequentFlyerPts;
            this.billingAccountNo = billingAccountNo;
        }
    }
    class program
    {


        static void Main(string[] args)
        {
            Customer c = new Customer();

            Reservation reservation = new Reservation();
            
            Console.WriteLine("Customer Detail : \n");
            Console.WriteLine(@" Customer ID :"+c.customerID + "\n");
            Console.WriteLine(@" Name :"+c.firstName+" " + c.lastName +"\n");
            Console.WriteLine(@"Reservation Status "+ reservation.status+ "\n");
            Console.WriteLine(@"Reservation Date "+ reservation.date+ "\n");
        }

    }
}