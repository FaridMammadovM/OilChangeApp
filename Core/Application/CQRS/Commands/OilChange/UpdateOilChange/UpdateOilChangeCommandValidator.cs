using FluentValidation;

namespace Application.CQRS.Commands.OilChange.UpdateOilChange
{
    public class UpdateOilChangeCommandValidator : AbstractValidator<UpdateOilChangeCommand>
    {
        public UpdateOilChangeCommandValidator()
        {
            RuleFor(x => x.Request)
               .NotNull()
               .WithMessage("Request boş ola bilməz.");

            When(x => x.Request.ServiceId != 1 && x.Request.ServiceId != 2, () =>
            {
                RuleFor(x => x.Request.Filters)
                    .Must(filters => filters == null || !filters.Any())
                    .WithMessage("Əgər ServiceId 1 və ya 2 deyilsə, Filtr null olmalıdır.");
            });

            When(x => x.Request.ServiceId == 1 || x.Request.ServiceId == 5 || x.Request.ServiceId == 6 || x.Request.ServiceId == 7, () =>
            {
                RuleFor(x => x.Request.SAEViscosityId)
                    .Must(id => id == null)
                    .WithMessage("Əgər ServiceId 1, 5, 6 və 7-dirsə, SAEViscosityId null olmalıdır.");

                RuleFor(x => x.Request.WinterViscosityId)
                    .Must(id => id == null)
                    .WithMessage("Əgər ServiceId 1, 5, 6 və 7-dirsə, WinterViscosityId null olmalıdır.");
            });

            When(x => x.Request.ServiceId == 4, () =>
            {
                RuleFor(x => x.Request.SAEViscosityId)
                    .Must(t => t == null)
                    .WithMessage("Əgər ServiceId 4-dürsə, SAEViscosityId null olmalıdır.");

                RuleFor(x => x.Request.Duration)
                   .Must(id => id == null)
                   .WithMessage("Əgər ServiceId 4-dürsə, Duration null olmalıdır.");
            });

            When(x => x.Request.ServiceId == 3, () =>
            {
                RuleFor(x => x.Request.Duration)
                    .Must(id => id == null)
                    .WithMessage("Əgər ServiceId 3-dürsə, Duration null olmalıdır.");

                RuleFor(x => x.Request.SAEViscosityId)
                .Must(id => id == null)
                .WithMessage("Əgər ServiceId 3-dürsə, SAEViscosityId null olmalıdır.");
            });

            When(x => x.Request.ServiceId == 5 || x.Request.ServiceId == 6 || x.Request.ServiceId == 7, () =>
            {
                RuleFor(x => x.Request.Duration)
                    .Must(id => id == null)
                    .WithMessage("Əgər ServiceId 5, 6 və 7-sə, Duration null olmalıdır.");
            });


            When(x => x.Request.ServiceId == 2 || x.Request.ServiceId == 4, () =>
            {
                RuleFor(x => x.Request.Indicator)
                    .Must(id => id == null)
                    .WithMessage("Əgər ServiceId 2 və 4-sə, Indicator null olmalıdır.");
            });

        }
    }
}
