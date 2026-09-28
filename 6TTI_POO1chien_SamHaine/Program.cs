namespace _6TTI_POO1chien_SamHaine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chien chien1 = new Chien("Pam", 15, "Yorkshire");
            Chien chien2 = new Chien("Max", 3, "Labrador");
            Chien chien3 = new Chien("Rex", 5, "Berger Allemand");

            Console.WriteLine(chien1.AfficheCaracteristiques());
            Console.WriteLine(chien2.AfficheCaracteristiques());
            Console.WriteLine(chien3.AfficheCaracteristiques());

            Console.ReadLine();
        }
    }
}
