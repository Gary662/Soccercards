using System;
using System.Drawing; // For the Image type

namespace Soccercards.Models
{
    public class Player
    {
        private string _photo; //
        public string Name { get; set; }
        public int Age { get; set; }
        public string Team { get; set; }
        // Path to player's photo image
        public string Photo {
            get
            {
                return _photo;
            }
            set
            {
                _photo = value;
                LoadPlayerImage();
            }
        }
        // image object for displaying
        public Image PlayerImage { get; set; } 

        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Passes { get; set; }
        public int Tackles { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public int Appearances { get; set; }

        public Player()
        {
           
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
                catch (Exception ex)
                {
                    // Handle the case where the image path is invalid or file is missing
                    Console.WriteLine($"Error loading image: {ex.Message}");
                    // Set to null if the image can't be loaded
                    PlayerImage = null; 
                }
            }
        }
    }
}
