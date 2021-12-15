using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Work.Models
{
    public class InternetResource
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string URL { get; set; }
        public DateTime DateOfCreating { get; set; }

        public IList<UserResource> UsersResources { get; set; }

        public InternetResource()
        {

        }
        public InternetResource(string name, string url, DateTime createdAt)
        {
            this.Name = name;
            this.URL = url;
            this.DateOfCreating = createdAt;
        }
    }
}
