using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace myShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введите имя")]
        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "Длинна имени не менее 3 символов")]
        public string name { get; set; }
        [Display(Name = "Введите фамилию")]
        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "Длинна фамилии не менее 3 символов")]
        public string surname { get; set; }
        [Display(Name = "Введите адрес")]
        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "Длинна адреса не менее 3 символов")]
        public string adress { get; set; }
        [Display(Name = "Введите номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(50, MinimumLength = 10)]
        [Required(ErrorMessage = "Длинна телефона не менее 10 символов")]
        public string phone { get; set; }
        [Display(Name = "Введите Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "Длинна Email не менее 5 символов")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
