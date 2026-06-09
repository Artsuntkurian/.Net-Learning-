using System;

namespace RideSharingApplication
{
    public interface IRide
    {
        void CalculateFare();
    }

    public class StandardRide : IRide
    {
        public void CalculateFare()
        {
            Console.WriteLine("Standard ride fare calculated.");
        }
    }

    public class LuxuryRide : IRide
    {
        public void CalculateFare()
        {
            Console.WriteLine("Luxury ride fare calculated.");
        }
    }

    public class BikeRide : IRide
    {
        public void CalculateFare()
        {
            Console.WriteLine("Bike ride fare calculated.");
        }
    }

    public class AutoRide : IRide
    {
        public void CalculateFare()
        {
            Console.WriteLine("Auto ride fare calculated.");
        }
    }

    public interface INotification
    {
        void SendNotification();
    }

    public class EmailNotification : INotification
    {
        public void SendNotification()
        {
            Console.WriteLine("Email notification sent.");
        }
    }

    public class WhatsAppNotification : INotification
    {
        public void SendNotification()
        {
            Console.WriteLine("WhatsApp notification sent.");
        }
    }

    public class NotificationService
    {
        private readonly INotification notification;

        public NotificationService(INotification notification)
        {
            this.notification = notification;
        }

        public void Notify()
        {
            notification.SendNotification();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ride Sharing Application");

            IRide luxuryRide = new LuxuryRide();
            luxuryRide.CalculateFare();

            IRide bikeRide = new BikeRide();
            bikeRide.CalculateFare();

            IRide autoRide = new AutoRide();
            autoRide.CalculateFare();

            INotification notification = new WhatsAppNotification();
            NotificationService notificationService = new NotificationService(notification);

            notificationService.Notify();
        }
    }
}