using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using TooliRent.Application.DTOs;

namespace TooliRent.Application.Validation
{
    public class ToolCreateValidator : AbstractValidator<ToolCreateDto>
    {
        public ToolCreateValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(120);

            RuleFor(x => x.CategoryId)
                .NotEmpty();

            RuleFor(x => x.InventoryCode)
                .MaximumLength(50)
                .When(x => !string.IsNullOrWhiteSpace(x.InventoryCode));
        }
    }

    public class ToolUpdateValidator : AbstractValidator<ToolUpdateDto>
    {
        public ToolUpdateValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(120);

            RuleFor(x => x.CategoryId)
                .NotEmpty();

            RuleFor(x => x.InventoryCode)
                .MaximumLength(50)
                .When(x => !string.IsNullOrWhiteSpace(x.InventoryCode));
        }
    }
}

