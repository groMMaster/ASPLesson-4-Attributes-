using System.ComponentModel.DataAnnotations;

namespace ASPLesson.Helpers.ValidationAttributes
{
    public class CardLengthAttribute : ValidationAttribute
    {
        private const int LengthCard = 19;

        public CardLengthAttribute(int length) { }

        public override bool IsValid(object value)
        {
            var lengthValue = value.ToString().Length;
            if (value != null && LengthCard == lengthValue)
                return true;

            return false;
        }
    }
}
