using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class PatientValidator : AbstractValidator<Doctor>
    {
        public PatientValidator() 
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(patient => patient.FirstName)
                .NotEmpty().WithMessage("El nombre no puede estar vacio")
                .MinimumLength(3).WithMessage("El nombre debe contener minimo 3 letras")
                .MaximumLength(100).WithMessage("El nombre no puede tener mas de 100 letras");

            RuleFor(patient => patient.LastName)
                .NotEmpty().WithMessage("El apellido no puede estar vacio")
                .Length(3, 100).WithMessage("El apellido debe contener entre 3 y 100 letras");
        }
    }
}
