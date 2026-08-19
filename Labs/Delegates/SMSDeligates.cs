namespace DEligates;

public class Del
{
    // Delegate
    public delegate void SMSDelegate();

    // Methods
    public static void SendSms()
    {
        Console.WriteLine("sms send");
    }

    public static void SendOTP()
    {
        Console.WriteLine("send OTP");
    }
}