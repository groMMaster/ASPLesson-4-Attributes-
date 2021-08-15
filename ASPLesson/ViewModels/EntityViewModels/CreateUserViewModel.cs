﻿using ASPLesson.Helpers.ValidationAttributes;
using System;
using System.ComponentModel.DataAnnotations;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace ASPLesson.ViewModels.EntityViewModels
{
    [Serializable]
    public class CreateUserViewModel
    {
        //[Required(ErrorMessage = "Введите имя")]
        //[MinLength(2, ErrorMessage = "Минимальная длина должна быть больше 2 символов")]
        //[MaxLength(50, ErrorMessage = "Длина не должна превышать больше 50 символов")]
        //public string Name { get; set; }

        //[Range(1, 110, ErrorMessage = "Недопустимый возраст")]
        //public int Age { get; set; }

        //[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        //public string Email { get; set; }

        //[Required(ErrorMessage = "Введите пароль")]
        //[StringLength(70, MinimumLength = 6, ErrorMessage = "Диапазон длины пароля должен входить от 6 до 70 символов")]
        //public string Password { get; set; }

        //[Compare("Password", ErrorMessage = "Пароли не совпадают")]
        //public string PasswordConfrim { get; set; }

        [CardLength(19, ErrorMessage = "Некорректный номер карты")]
        public string NumberCard { get; set; }
    }
}
