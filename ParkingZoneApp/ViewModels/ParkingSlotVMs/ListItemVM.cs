﻿using ParkingZoneApp.Enums;
using ParkingZoneApp.Models;
using System.ComponentModel.DataAnnotations;

namespace ParkingZoneApp.ViewModels.ParkingSlotsVMs
{
    public class ListItemVM
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public bool IsAvilableForBooking { get; set; }

        [Required]
        public SlotCategoryEnum Category { get; set; }

        public ListItemVM() { }

        public ListItemVM(ParkingSlot parkingSlots)
        {
            Id = parkingSlots.Id;
            Number = parkingSlots.Number;
            IsAvilableForBooking = parkingSlots.IsAvilableForBooking;
            Category = parkingSlots.Category;
        }
    }
}