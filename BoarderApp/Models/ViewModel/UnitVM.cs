using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BoarderApp.Models.ViewModel
{
    public class UnitVM
    {

        public Unit UnitName { get; set; }
        public IEnumerable<SelectList> TypeDropDown { get; set; }
    }
}
