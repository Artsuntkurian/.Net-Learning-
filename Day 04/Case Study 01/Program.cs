using System;

namespace HospitalManagement
{
    public interface INotification
    {
        void Send();
    }

    public class EmailNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Email notification sent.");
        }
    }

    public class SmsNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("SMS notification sent.");
        }
    }

    public class WhatsAppNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("WhatsApp notification sent.");
        }
    }

    public interface IPayment
    {
        void Pay();
    }

    public class CashPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Payment completed using Cash.");
        }
    }

    public class CreditCardPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Payment completed using Credit Card.");
        }
    }

    public class MedicalReportService
    {
        public void GenerateReport()
        {
            Console.WriteLine("Medical report generated.");
        }
    }

    public class ReportPrinter
    {
        public void PrintReport()
        {
            Console.WriteLine("Medical report printed.");
        }
    }

    public class ReportNotifier
    {
        public void NotifyPatient()
        {
            Console.WriteLine("Patient notified about report availability.");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hospital Management System");

            INotification notification = new WhatsAppNotification();
            notification.Send();

            IPayment payment = new CreditCardPayment();
            payment.Pay();

            var reportService = new MedicalReportService();
            var printer = new ReportPrinter();
            var notifier = new ReportNotifier();

            reportService.GenerateReport();
            printer.PrintReport();
            notifier.NotifyPatient();
        }
    }
}