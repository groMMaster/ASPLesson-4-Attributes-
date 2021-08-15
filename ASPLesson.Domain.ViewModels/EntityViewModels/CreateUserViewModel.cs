﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace ASPLesson.Domain.ViewModels.EntityViewModels
{
    public class CreateUserViewModel
    {
        [Required(ErrorMessage = "Введите имя")]
        [MinLength(2, ErrorMessage = "Минимальная длина должна быть больше 2 символов")]
        [MaxLength(50, ErrorMessage = "Длина не должна превышать больше 50 символов")]
        public string Name { get; set; }

        [Range(1, 110, ErrorMessage = "Недопустимый возраст")]
        public int Age { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Введите пароль")]
        [MinLength(6, ErrorMessage = "Минимальная длина должна быть больше 6 символов")]
        [MaxLength(70, ErrorMessage = "Длина пароля не должна превышать больше 70 символов")]
        // [StringLength(70, MinimumLength = 6, ErrorMessage = "Диапазон длины пароля должен входить от 6 до 70 символов")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string PasswordConfrim { get; set; }

        [CardLength]
        public string NumberCard { get; set; }
    }
}
