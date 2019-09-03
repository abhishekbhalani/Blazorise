﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise
{
    public abstract class BaseValidationNone : BaseComponent
    {
        #region Members

        #endregion

        #region Methods

        protected override void RegisterClasses()
        {
            ClassMapper
                .Add( () => ClassProvider.ValidationNone() );

            base.RegisterClasses();
        }

        #endregion

        #region Properties

        [CascadingParameter] protected BaseValidation ParentValidation { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        #endregion
    }
}
