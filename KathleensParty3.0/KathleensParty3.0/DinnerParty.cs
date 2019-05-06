using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KathleensParty3._0
{
    class DinnerParty : Party
    {
        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption): base(numberOfPeople, fancyDecorations)
        {
            HealthyOption = healthyOption;
        }
        #region properties
        public bool HealthyOption { get; set; }

        public override decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += ((CalculateCostOfBeveragesPerPerson()
                + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }
        }

        #endregion

        #region ö
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            return costOfBeveragesPerPerson;
        }



    }
}
