using System;

namespace CaveExplorerTracker
{
    // This class represents a single cave in the program.
    // It stores all the important details about a cave.
    public class Cave
    {
        // The name of the cave
        public string CaveName { get; set; }

        // Where the cave is located
        public string Location { get; set; }

        // How deep the cave is (in feet)
        public int DepthInFeet { get; set; }

        // How long the cave is (in feet)
        public int LengthInFeet { get; set; }

        // Whether the cave has been explored or not
        public bool IsExplored { get; set; }

        // The danger level of the cave "Low, Medium, High, etc."
        public string DangerLevel { get; set; }

        // Constructor: runs when a new Cave object is created
        // It sets all the values for the cave
        public Cave(string caveName, string location, int depthInFeet, int lengthInFeet, bool isExplored, string dangerLevel)
        {
            CaveName = caveName;
            Location = location;
            DepthInFeet = depthInFeet;
            LengthInFeet = lengthInFeet;
            IsExplored = isExplored;
            DangerLevel = dangerLevel;
        }

        // Returns a simple text version of the exploration status
        public string GetExplorationStatus()
        {
            if (IsExplored)
                return "Explored";
            else
                return "Not Explored";
        }

        // Returns all cave info in one formatted string
        // This is useful for displaying in the GUI
        public string GetCaveSummary()
        {
            return $"Name: {CaveName} | Location: {Location} | Depth: {DepthInFeet} ft | Length: {LengthInFeet} ft | Status: {GetExplorationStatus()} | Danger: {DangerLevel}";
        }
    }
}