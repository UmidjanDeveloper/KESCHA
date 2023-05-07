namespace KESCHA.Classes
{
   public class Animal
    {
        public string animalName;
        public int animalAge;

        public string Name { get; set; }   
        public int Age { get; set; }   
        public int AgeDifference { get; set; }   
        
        public Animal(int animalAge, string animalName)
        {
            this.animalAge = animalAge;
            this.animalName = animalName;
        }  
    }
}