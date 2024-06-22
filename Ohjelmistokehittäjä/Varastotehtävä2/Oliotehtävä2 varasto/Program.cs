// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Varasto

{

    //kentät

    private double paino;
    private string nimi;
    private int maara;
    private int hyllyssa;
    private int hyllyyn;
    public static int Laskuri = 0;

    //metodit

    public double painonmuutos()

    {
        Console.Write("Painonmuutos: ");
        paino = paino - double.Parse(Console.ReadLine());
        return paino;
    }

    public string nimenmuutos()

    {
        Console.Write("Nimenmuutos: ");
        nimi = Console.ReadLine();
        Laskuri++;
        return nimi;

    }

    public int maaramuutos()

    {
        Console.Write("Määrämuutos: ");
        maara = maara + int.Parse(Console.ReadLine());
        return maara;

    }
    public int poishyllysta()
    {
        Console.Write("Poishyllystä: ");
        hyllyssa = hyllyssa- int.Parse(Console.ReadLine());
        return hyllyssa;
    }
    public int palautahyllyyn()
    {
        Console.Write("Palautahyllyyn: ");
        hyllyyn = int.Parse(Console.ReadLine());
        return hyllyyn;
    }




    //Oletuskonstruktori

    public Varasto()

    {
        paino = paino;
        maara = maara;
        nimi = nimi;
        hyllyssa = hyllyssa;
        hyllyyn = hyllyyn;
        Laskuri++;
    }

    //ylikuormitettu konstruktori()

    public Varasto(int u_paino, int u_maara, string u_nimi, int u_hyllyssa, int u_hyllyyn)

    {   
        paino = u_paino;
        maara = u_maara;
        nimi = u_nimi;
        hyllyssa = u_hyllyssa;
        hyllyyn = u_hyllyyn;
        
    }
    
    //ominaisuusfunktio

    public double varastopaino //{ get; set; }

    {
        set { paino = value; }
        get { return paino; }
    }

    public int varastomaara //{ get; set; }

    {
        set { maara = value; }
        get { return maara; }
    }

    public string varastonimi //{ get; set; }

    {
        set { nimi = value; }
        get { return nimi; }
    }
    public int varastohyllyssa //{ get; set; }   
    {
        set { hyllyssa = value; }
        get { return hyllyssa; }
    }


    
      class Program

    {
           static void Main(string[] args)

        {   //luodaan olio

            int u_maara, u_hyllyssa, u_hyllyyn;
            string u_nimi; double u_paino;

            Varasto tallenne = new Varasto();
            Console.Write("Varastopaino: ");
            tallenne.varastopaino = double.Parse(Console.ReadLine());
            Console.Write("Varastomäärä: ");
            tallenne.varastomaara = int.Parse(Console.ReadLine());
            Console.Write("Varastonimi: ");
            tallenne.varastonimi = Console.ReadLine();
            Console.Write("Varastohyllyssä: ");
            tallenne.varastohyllyssa = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Varastonimi: " + tallenne.varastonimi + " / Varastopaino: " + tallenne.varastopaino + " Kg" + " / Varastomäärä: " + tallenne.varastomaara
             + " / Varastohyllyssä: " + tallenne.varastohyllyssa + " /Laskuri: " + Varasto.Laskuri);
            Console.WriteLine();
            u_paino = tallenne.painonmuutos();
            u_maara = tallenne.maaramuutos();
            u_nimi = tallenne.nimenmuutos();
            u_hyllyssa = tallenne.poishyllysta();
            u_hyllyyn = tallenne.palautahyllyyn();
            Console.WriteLine();
            Console.WriteLine("Uusipaino: " + u_paino + " Kg" + " / Uusimäärä: " + u_maara + " / Uusinimi: " + u_nimi + " / Uusihyllymäärä: " + u_hyllyssa +
                " / Palautahyllyyn: " + u_hyllyyn + " / Laskuri: " + Varasto.Laskuri);
            Console.WriteLine();

        }

    }
}