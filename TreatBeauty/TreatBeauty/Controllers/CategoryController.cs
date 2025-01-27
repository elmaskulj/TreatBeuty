﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TreatBeauty.Interfaces;
using TreatBeauty.Model;

namespace TreatBeauty.Controllers
{
    [Authorize]
    public class CategoryController :CrudController<Model.Category,Model.Category,Model.Category,object>
    {
        public CategoryController(ICategoryService service) : base(service)
        {
        }
    }
}
