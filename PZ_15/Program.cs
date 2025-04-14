using System;
using System.Text.RegularExpressions;

namespace PZ_15
{
    public class InvalidPassengerDataException : Exception
    {
        public InvalidPassengerDataException(string message) : base(message) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter passenger full name:");
                string fullName = Console.ReadLine();
                ValidateFullName(fullName);

                Console.WriteLine("Enter flight number (format: AB123):");
                string flightNumber = Console.ReadLine();
                ValidateFlightNumber(flightNumber);

                Console.WriteLine("Enter passport data (format: 12 34 567890):");
                string passportData = Console.ReadLine();
                ValidatePassportData(passportData);

                Console.WriteLine("\n✅ Data successfully accepted!");
                Console.WriteLine($"Full Name: {fullName}\nFlight Number: {flightNumber}\nPassport: {passportData}");
            }
            catch (InvalidPassengerDataException ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nProgram has ended.");
            }
        }

        static void ValidateFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new InvalidPassengerDataException("Full name cannot be empty.");
        }

        static void ValidateFlightNumber(string flightNumber)
        {
            if (!Regex.IsMatch(flightNumber ?? "", @"^[A-Za-z]{2}\d{3}$"))
                throw new InvalidPassengerDataException("Invalid flight number format. Example: AB123.");
        }

        static void ValidatePassportData(string passportData)
        {
            if (!Regex.IsMatch(passportData ?? "", @"^\d{2} \d{2} \d{6}$"))
                throw new InvalidPassengerDataException("Invalid passport format. Example: 12 34 567890.");
        }
    }
}
