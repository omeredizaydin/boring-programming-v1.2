using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace FinalProject
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Characters> Characters;

        public ObservableCollection<Characters> characters
        {
            get { return Characters; }
            set { Characters = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("characters"));
            }
        }
        public MainViewModel()
        {
            characters = new ObservableCollection<Characters>();
            addData();
        }
        private void addData()
        {


            characters.Add(new Characters
            {
                id = 1,
                Name = "Harry James Potter",
                Gender = "Male",
                Job="Student",
                House= "Gryffindor",
                Wand= "Holly phoenix feather",
                Patronus= "Stag",
                Skills= "Parseltongue| Seeker",
                Birth= "31 July 1980",
                imgSource = "harrypotter.png"


            });

            characters.Add(new Characters
            {
                id = 2,
                Name = "Draco Malfoy",
                Gender = "Male",
                Job = "Student",
                House = "Slytherin",
                Wand = "Hawthorn unicorn hair",
                Patronus = "Unknown",
                Skills = "Prefec|Seeker",
                Birth = "5 June 1980",
                imgSource = "DracoMalfoy.png"


            });

            characters.Add(new Characters
            {
                id = 3,
                Name = "Ronald Bilius Weasley",
                Gender = "Male",
                Job = "Student",
                House = "Gryffindor",
                Wand = "Ash unicorn tail hair",
                Patronus = "Jack Russell",
                Skills = "Wizard chess",
                Birth = "1 March 1980",
                imgSource = "RonaldWeasley.png"


            });

            
            characters.Add(new Characters
            {
                id = 4,
                Name = "Hermione Jean Granger",
                Gender = "Female",
                Job = "Student",
                House = "Gryffindor",
                Wand = "vine wood dragon",
                Patronus = "Otter",
                Skills = "Almost everything",
                Birth = "19 June 1979",
                imgSource = "HermioneGranger.png"


            });



            characters.Add(new Characters
            {
                id =5,
                Name = "Severus Snape",
                Gender = "Male",
                Job = "Professor",
                House = "Slytherin",
                Wand = "Unknown",
                Patronus = "Doe",
                Skills = "Potions|Occlumency",
                Birth = "9 March 1960",
                imgSource = "ProfessorSeverusSnape.png"


            });

            characters.Add(new Characters
            {
                id = 5,
                Name = "Helga Hufflepuff",
                Gender = "Female",
                Job = "Founder",
                House = "Hufflepuff",
                Wand = "Unknown",
                Patronus = "Unknown",
                Skills = "Food-related Charms",
                Birth = "11th Century",
                imgSource = "HelgaHufflepuff.png"


            });
            characters.Add(new Characters
            {
                id = 1,
                Name = "Harry James Potter",
                Gender = "Male",
                Job = "Student",
                House = "Gryffindor",
                Wand = "Holly phoenix feather",
                Patronus = "Stag",
                Skills = "Parseltongue| Seeker",
                Birth = "31 July 1980",
                imgSource = "harrypotter.png"


            });

            characters.Add(new Characters
            {
                id = 2,
                Name = "Draco Malfoy",
                Gender = "Male",
                Job = "Student",
                House = "Slytherin",
                Wand = "Hawthorn unicorn hair",
                Patronus = "Unknown",
                Skills = "Prefec|Seeker",
                Birth = "5 June 1980",
                imgSource = "DracoMalfoy.png"


            });

            characters.Add(new Characters
            {
                id = 3,
                Name = "Ronald Bilius Weasley",
                Gender = "Male",
                Job = "Student",
                House = "Gryffindor",
                Wand = "Ash unicorn tail hair",
                Patronus = "Jack Russell",
                Skills = "Wizard chess",
                Birth = "1 March 1980",
                imgSource = "RonaldWeasley.png"


            });


            characters.Add(new Characters
            {
                id = 4,
                Name = "Hermione Jean Granger",
                Gender = "Female",
                Job = "Student",
                House = "Gryffindor",
                Wand = "vine wood dragon",
                Patronus = "Otter",
                Skills = "Almost everything",
                Birth = "19 June 1979",
                imgSource = "HermioneGranger.png"


            });



            characters.Add(new Characters
            {
                id = 5,
                Name = "Severus Snape",
                Gender = "Male",
                Job = "Professor",
                House = "Slytherin",
                Wand = "Unknown",
                Patronus = "Doe",
                Skills = "Potions|Occlumency",
                Birth = "9 March 1960",
                imgSource = "ProfessorSeverusSnape.png"


            });

            characters.Add(new Characters
            {
                id = 5,
                Name = "Helga Hufflepuff",
                Gender = "Female",
                Job = "Founder",
                House = "Hufflepuff",
                Wand = "Unknown",
                Patronus = "Unknown",
                Skills = "Food-related Charms",
                Birth = "11th Century",
                imgSource = "HelgaHufflepuff.png"


            });
                characters.Add(new Characters
                {
                    id = 1,
                    Name = "Harry James Potter",
                    Gender = "Male",
                    Job = "Student",
                    House = "Gryffindor",
                    Wand = "Holly phoenix feather",
                    Patronus = "Stag",
                    Skills = "Parseltongue| Seeker",
                    Birth = "31 July 1980",
                    imgSource = "harrypotter.png"


                });

            characters.Add(new Characters
            {
                id = 2,
                Name = "Draco Malfoy",
                Gender = "Male",
                Job = "Student",
                House = "Slytherin",
                Wand = "Hawthorn unicorn hair",
                Patronus = "Unknown",
                Skills = "Prefec|Seeker",
                Birth = "5 June 1980",
                imgSource = "DracoMalfoy.png"


            });

            characters.Add(new Characters
            {
                id = 3,
                Name = "Ronald Bilius Weasley",
                Gender = "Male",
                Job = "Student",
                House = "Gryffindor",
                Wand = "Ash unicorn tail hair",
                Patronus = "Jack Russell",
                Skills = "Wizard chess",
                Birth = "1 March 1980",
                imgSource = "RonaldWeasley.png"


            });


            characters.Add(new Characters
            {
                id = 4,
                Name = "Hermione Jean Granger",
                Gender = "Female",
                Job = "Student",
                House = "Gryffindor",
                Wand = "vine wood dragon",
                Patronus = "Otter",
                Skills = "Almost everything",
                Birth = "19 June 1979",
                imgSource = "HermioneGranger.png"


            });



            characters.Add(new Characters
            {
                id = 5,
                Name = "Severus Snape",
                Gender = "Male",
                Job = "Professor",
                House = "Slytherin",
                Wand = "Unknown",
                Patronus = "Doe",
                Skills = "Potions|Occlumency",
                Birth = "9 March 1960",
                imgSource = "ProfessorSeverusSnape.png"


            });

            characters.Add(new Characters
            {
                id = 5,
                Name = "Helga Hufflepuff",
                Gender = "Female",
                Job = "Founder",
                House = "Hufflepuff",
                Wand = "Unknown",
                Patronus = "Unknown",
                Skills = "Food-related Charms",
                Birth = "11th Century",
                imgSource = "HelgaHufflepuff.png"


            });
        }
    }
}
