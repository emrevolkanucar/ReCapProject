using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(1972);
            RuleFor(c => c.DailyPrice).GreaterThan(100).When(c => c.BrandId == 1);
            RuleFor(c => c.Description).Must(StartWithA).When(c => c.BrandId == 2);

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
