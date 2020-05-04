using BlomstViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBlomsterButik
{
    public class BlomstViewModel
    {
        private string navnBlomst;
        private int antalBlomst;
        private string farveBlomst;

        public ObservableCollection<OrdreBlomst> OC_blomster { get; set; }

        public string NavnBlomst { get => navnBlomst; set => navnBlomst = value; }
        public int AntalBlomst { get => antalBlomst; set => antalBlomst = value; }
        public string FarveBlomst { get => farveBlomst; set => farveBlomst = value; }

        public RelayCommand AddNyBlomst { get; set; }

        public BlomstViewModel()
        {
            OC_blomster = new ObservableCollection<OrdreBlomst>();

            //Testdata 
            OC_blomster.Add(new OrdreBlomst("Tulipan", 4, "Rød"));
            OC_blomster.Add(new OrdreBlomst("Tulipan", 3, "Hvid"));
            OC_blomster.Add(new OrdreBlomst("Tulipan", 2, "Gul"));
            

            AddNyBlomst = new RelayCommand(AddBlomst);

        }

        /// <summary>
        /// metode til at tilføje en ny ordreblomst til listen
        /// </summary>
        public void AddBlomst()
        {
            OrdreBlomst oBlomst = new OrdreBlomst(NavnBlomst, AntalBlomst, FarveBlomst);

            OC_blomster.Add(oBlomst);
        }


    }
}
