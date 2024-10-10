using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class AppointmentValidator : AbstractValidator<Appointment>
    {
        public AppointmentValidator()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(appointment => appointment.DateAppointments)
                .NotEmpty().WithMessage("La fecha de la cita no puede estar vacía")
                .GreaterThanOrEqualTo(DateTime.Today).WithMessage("La fecha de la cita no puede ser en el pasado");

            RuleFor(appointment => appointment.Diagnosis)
                .NotEmpty().WithMessage("El diagnóstico no puede estar vacío")
                .MinimumLength(5).WithMessage("El diagnóstico debe tener al menos 5 caracteres")
                .MaximumLength(500).WithMessage("El diagnóstico no puede tener más de 500 caracteres");

            RuleFor(appointment => appointment.Treatment)
                .NotEmpty().WithMessage("El tratamiento no puede estar vacío")
                .MinimumLength(5).WithMessage("El tratamiento debe tener al menos 5 caracteres")
                .MaximumLength(500).WithMessage("El tratamiento no puede tener más de 500 caracteres");

            RuleFor(appointment => appointment.PatientId)
                .GreaterThan(0).WithMessage("Debe seleccionarse un paciente válido para la cita");

            RuleFor(appointment => appointment.DoctorId)
                .GreaterThan(0).WithMessage("Debe seleccionarse un doctor válido para la cita");
        }
    }
}
