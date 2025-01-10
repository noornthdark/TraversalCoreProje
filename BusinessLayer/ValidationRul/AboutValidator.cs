using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRul
{
    public class AboutValidator :AbstractValidator<About>
    {
        public AboutValidator() //constractor
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz...");
            RuleFor(x => x.ImageOne).NotEmpty().WithMessage("Lütfen görsel seçiniz...");
            RuleFor(x => x.Description).Length(50).WithMessage("Lütfen en az 50 karakterlik açıklama bilgisi giriniz...");
            //...
        }
    }
}
