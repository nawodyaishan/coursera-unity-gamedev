using System;

namespace Week2Int {
    /// <summary>
    /// Integer Data Types Lecture Code
    /// </summary>
    internal class Program {
        /// <summary>
        /// Demonstrating Integer Data Types
        /// </summary>
        /// <param name="args">command-line args</param>
        
        static void Main(string[] args) {
            // Calculating second and minutes
            int totalSecondsPlayed = 100;
            int totalMinutesPlayed = totalSecondsPlayed / 60;
            
            // print minutes d second played
            Console.WriteLine("" + totalMinutesPlayed + " minutes and " + (totalSecondsPlayed - (totalMinutesPlayed*60)) + " seconds");
                    }
    }
}