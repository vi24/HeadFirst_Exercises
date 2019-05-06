using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KathleensParty3._0
{
    class Party
    {
        #region properties

        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public virtual decimal Cost {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                if (NumberOfPeople > 12)
                {
                    totalCost += 100;
                }
                return totalCost;
            }
        }
        #endregion 

        public Party (int numberOfPeople, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
        }

        #region private methods
        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            return costOfDecorations;
        }
        #endregion
    }
}
