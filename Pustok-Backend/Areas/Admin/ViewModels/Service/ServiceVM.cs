﻿namespace Pustok_Backend.Areas.Admin.ViewModels.Service
{
    public class ServiceVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string IconName { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
