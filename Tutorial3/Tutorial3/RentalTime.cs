namespace Tutorial3;

public class RentalTime
{
    DateTime rentStartDate = DateTime.Today;
    DateTime rentEndDate;
    private TimeSpan rentDuration;
    private double fee;
    private Random gen =  new Random();

    public DateTime RandomDate()
    {
        DateTime start = new DateTime(2025, 11, 5);
        int range = (DateTime.Today - start).Days;
        return start.AddDays(gen.Next(range));
    }

    public double FeeCalculator(Types.ItemType item, DateTime start, DateTime end)
    {
        TimeSpan duration = end - start;
        int days = Math.Max(1, duration.Days);
        double dailyFee = item switch
        {
            Types.ItemType.Laptop => 0.50,
            Types.ItemType.Monitor => 0.10,
            Types.ItemType.Camera => 0.20,
            Types.ItemType.Projector => 0.35,
            Types.ItemType.Keyboard => 0.10,
            _ => 0
        };
        return dailyFee*days;
    }

    public TimeSpan RentDuration(Types.ItemType item, Types.UserType user)
    {
        TimeSpan duration = rentDuration switch
        {
            

        };
    }


}