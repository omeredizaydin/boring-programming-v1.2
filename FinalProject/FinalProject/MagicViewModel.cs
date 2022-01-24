using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace FinalProject
{
    public class MagicViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Magic> Magic;

        public ObservableCollection<Magic> magic
        {
            get { return Magic; }
            set
            {
                Magic = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("magic"));
            }
        }
        public MagicViewModel()
        {
            magic = new ObservableCollection<Magic>();
            addData();
        }
        private void addData()
        {


            magic.Add(new Magic
            {
                id = 1,
                Name = "Goblet of Fire",
                Description="Deneme",
               
                imgSource = "GobletofFire.png"


            });

            magic.Add(new Magic
            {
                id = 2,
                Name = "Fat Friar",
                Description = "Deneme",

                imgSource = "FatFriar.png"


            });

            magic.Add(new Magic
            {
                id = 3,
                Name = "Golden Snitch",
                Description = "Deneme",

                imgSource = "GoldenSnitch.png"


            });

            magic.Add(new Magic
            {
                id = 4,
                Name = "Draco Dormiens Nunquam",
                Description = "Deneme",

                imgSource = "DracoDormiensNunquam.png"


            });

            magic.Add(new Magic
            {
                id = 5,
                Name = "Raven Claw",
                Description = "Deneme",

                imgSource = "Ravenclaw.png"


            });

            magic.Add(new Magic
            {
                id = 6,
                Name = "Gryffindor",
                Description = "Deneme",

                imgSource = "Gryffindor.png"


            });

          
            magic.Add(new Magic
            {
                id = 8,
                Name = "Slytherin",
                Description = "Deneme",

                imgSource = "Slytherin.png"


            });

            magic.Add(new Magic
            {
                id = 9,
                Name = "Gold and Green Floral",
                Description = "Deneme",

                imgSource = "GoldAndGreenFloral.png"


            });

            magic.Add(new Magic
            {
                id = 10,
                Name = "Unkownn Magic",
                Description = "Deneme",

                imgSource = "magic2.png"


            });

            magic.Add(new Magic
            {
                id = 11,
                Name = "Unkownn Magic",
                Description = "Deneme",

                imgSource = "magic1.png"


            });


        }
    }
}
