﻿namespace Pustok_Backend.Areas.Admin.ViewModels.Contact
{
    public class ContactMessageVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
