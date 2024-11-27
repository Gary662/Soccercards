using System;
using System.Drawing; // For the Image type

namespace Soccercards.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Team { get; set; }
        public string Photo { get; set; }
        public Image PlayerImage { get; set; } // image object for displaying

        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Passes { get; set; }
        public int Tackles { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public int Appearances { get; set; }

        // Constructor to load the image based on the Photo path 
        public Player()
        {
            // optionally load an image when creating the Player object 
            LoadPlayerImage();
        }

        //Method to load the image from the Photo path
        public void LoadPlayerImage()
        {
            if (!string.IsNullOrEmpty(Photo))
            {
                try
                {
                    // Load the image from the file path
                    PlayerImage = Image.FromFile(Photo);
                }
                catch
                {
                    // Handle the case where the image path is invalid or file is missing
                    Console.WriteLine($"Error loading image: {Exception.Message}");
                    // Set to null if the image can't be loaded
                    PlayerImage = null; 
                }
            }
        }
    }
}
