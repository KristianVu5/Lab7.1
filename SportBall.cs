using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lab7._1
{
    internal class SportBall : IsportType
    {
        private int numberOfPlayers;
        private string nameOfSport;
        private readonly SportCategory category;
        private double length;
        private double width;

        public SportBall(int numberOfPlayers, string nameOfSport, SportCategory category)
        {
            this.numberOfPlayers = numberOfPlayers;
            this.nameOfSport = nameOfSport;
            this.category = category;
        }

        public int NumberOfPlayers
        {
            get { return numberOfPlayers; }
            set { numberOfPlayers = value; }
        }

        public string NameOfSoport
        {
            get { return nameOfSport; }
        }

        public SportCategory Category
        {
            get { return category; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public void SportCharacteristics()
        {
            Console.WriteLine("Sport characteristics:");
            Console.WriteLine($"Name of sport: {nameOfSport}");
            Console.WriteLine($"Type of sport: {category}");
            Console.WriteLine($"# of players: {numberOfPlayers}");
            Console.WriteLine($"Court dimensions: {Format(Length)}m x {Format(Width)}m");
        }

        private static string Format(double value)
        {
            return value.ToString("0.##",CultureInfo.InvariantCulture);
        }
    }
}
