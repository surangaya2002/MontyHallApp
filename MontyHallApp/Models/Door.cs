using System;
using System.Collections.Generic;
using System.Text;
using static MontyHallApp.Enums.Enums;

namespace MontyHallApp.Models
{
    public class Door
    {
        bool isFirstChoice;
        bool isSecondChoice;
        bool isMontySelected;

        public DoorNumber Number { get; set; }
        public bool IsWinningDoor { get; set; }

        public bool IsFirstChoice
        {
            get
            {
                return (this.isFirstChoice);
            }

            set
            {
                this.isFirstChoice = value;
            }
        }

        public bool IsSecondChoice
        {
            get
            {
                return (this.isSecondChoice);
            }

            set
            {
                this.isSecondChoice = value;
            }
        }

        public bool IsMontySelected
        {
            get
            {
                return (this.isMontySelected);
            }

            set
            {
                this.isMontySelected = value;
            }
        }

        
    }
}
