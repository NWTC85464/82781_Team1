//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantPOS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees
    {
        public int employeeNumber { get; set; }
        public string name { get; set; }
        public int employeePasscode { get; set; }
        public string jobTitle { get; set; }
        public int Restaurant_restaurantId { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
    }
}
