using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life.ViewModels;
using Life.Models;
using System.Data;
using System.Windows.Forms;

namespace Life.Controllers
{
    public class BuildingDetailController
    {

        public BuildingDetails view { get; set; }

        public void ViewDidLoad(BuildingLevel buildingLevel)
        {
            var costs = new List<ResourceViewModel>();

            foreach (BuildingCost cost in buildingLevel.BuildingCosts)
            {
                costs.Add(
                    new ResourceViewModel()
                    {
                        Name = cost.Resource.Name,
                        Value = cost.Value
                    }
                    );
            }

            var binding = new BindingSource();
            binding.DataSource = costs;

            var modifiers = new List<BuildingFactorModifierViewModel>();

            foreach (BuildingFactorModifier modifier in buildingLevel.BuildingFactorModifiers)
            {

                modifiers.Add(
                    new BuildingFactorModifierViewModel()
                    {
                        FactorName = modifier.Factor.Name,
                        Value = modifier.Value
                    }
                    );
            }

            var modifierBinding = new BindingSource();
            modifierBinding.DataSource = modifiers;

            view.SetData(binding, modifierBinding);
        }

    }
}
