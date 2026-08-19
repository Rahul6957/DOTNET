using DEligates;

class Program
{
    static void Main()
    {
        Del.SMSDelegate sw = Del.SendSms;

        sw += Del.SendOTP;

        sw();
    }
}   