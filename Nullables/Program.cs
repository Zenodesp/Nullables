internal class Program
{

    private static void Main(string[] args)
    {

        String Naamwerknemer = "Jan Janssens";
        int? DienstjarenVerkoop = 369;
        int? DienstjarenOndersteuning = 211;
        int? DienstjarenAdministratie = null;

        

        double wedde = 24000;

        double bonus;

        double premie = (wedde * 0.02);

        Console.WriteLine("*** WERKNEMER WEDDEBONUSBEREKENAAR ***");
        Console.WriteLine("Naam vd werknemer: " + Naamwerknemer);
        Console.WriteLine("Werkte deze persoon in Verkoop? " + DienstjarenVerkoop.HasValue);
        Console.WriteLine("Hoe lang al? " + DienstjarenVerkoop);
        Console.WriteLine("Werkte deze persoon in Ondersteuning? " + DienstjarenOndersteuning.HasValue);
        Console.WriteLine("Hoe lang al? " + DienstjarenOndersteuning);
        Console.WriteLine("Werkte deze persoon in Administratie? " + DienstjarenAdministratie.HasValue);
        Console.WriteLine("Hoe lang al? " + DienstjarenAdministratie);
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("De wedde van deze persoon is: " + wedde);
        Console.WriteLine("Zijn premie bedraagt: " + premie);

        // Er is waarschijnlijk een veel makkelijkere manier om deze If-statement te schrijven of zelfs te vermijden, maar deze kon ik niet begrijpen

        if (DienstjarenVerkoop != null || DienstjarenOndersteuning != null || DienstjarenAdministratie != null) {
        
            if (DienstjarenAdministratie != null && DienstjarenVerkoop != null) {

                if (DienstjarenVerkoop >= 365 || DienstjarenOndersteuning >= 365 || DienstjarenAdministratie >= 365)
                {
                    bonus = wedde + premie;
                    Console.WriteLine("Zijn totale bonus bedraagt: " + bonus);
                }

            } else 
            if (DienstjarenOndersteuning != null && DienstjarenVerkoop != null)
            {
                if (DienstjarenVerkoop >= 365 || DienstjarenOndersteuning >= 365 || DienstjarenAdministratie >= 365)
                {
                    bonus = wedde + premie;
                    Console.WriteLine("Zijn totale bonus bedraagt: " + bonus);
                }
            } else 
            if (DienstjarenAdministratie != null && DienstjarenOndersteuning != null)
            {
                if (DienstjarenVerkoop >= 365 || DienstjarenOndersteuning >= 365 || DienstjarenAdministratie >= 365)
                {
                    bonus = wedde + premie;
                    Console.WriteLine("Zijn totale bonus bedraagt: " + bonus);

                }
            } 


        }

        
        





    }
}