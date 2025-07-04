﻿namespace ZondaTechAssesment.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Industry { get; set; } = string.Empty;

        public string ContactPerson { get; set; } = string.Empty;

        public  DateTime RegistrationDate { get; set; }
    }
}
