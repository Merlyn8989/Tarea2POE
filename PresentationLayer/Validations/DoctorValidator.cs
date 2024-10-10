using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class DoctorValidator : AbstractValidator<Doctor>
    {
        public DoctorValidator()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(doctor => doctor.FirstName)
                .NotEmpty().WithMessage("El nombre no puede estar vacio")
                .MinimumLength(3).WithMessage("El nombre debe contener minimo 3 letras")
                .MaximumLength(100).WithMessage("El nombre no puede tener mas de 100 letras");

            RuleFor(doctor => doctor.Specialty)
                .NotEmpty().WithMessage("La especialidad no puede estar vacia")
                .Length(3, 100).WithMessage("La especialidad debe contener entre 3 y 100 letras");
        }
    }
}