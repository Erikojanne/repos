// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//TEHTÄVÄ A.

//Rakenna Henkilö-luokka, joka sisältää tietoja (nimi, syntymävuosi ja ikä) ja  jossa on
//oletuskonstruktori, ylikuormitettu konstruktori (nimi ja syntymävuosi). Luokassa tulee määritellä
//metodit asetaTiedot(nimi ja syntymävuosi), laskeIka, palautaIka ja palautaNimi.
//Tässä nykyisen vuoden selvittämiseen apuja:  DateTime nyt = DateTime.Now;
//ja int nyt_vuosi = nyt.Year;

class henkilo
{
    //kentät eli luokan muuttujat
    private string nimi;
    public int syntymavuosi;
    private int ika;

    //oletuskonstruktori (alustetaan arvot 0/tyhjä)
    public henkilo()
    {
        nimi = "";
        syntymavuosi = 0;
        ika = 0;
    }

    //Ylikuormitettu konstruktori
    public henkilo(string u_nimi, int u_syntymavuosi)
    {
        nimi = u_nimi;
        syntymavuosi = u_syntymavuosi;

        Console.WriteLine("Ylikuormitettua konstruktoria käytetty");
    }

    //metodi joka asettaa nimen ja syntymävuoden
    public void asetaTiedot(string u_nimi, int u_syntymavuosi)
    {
        //asetetaan saadut arvot olion muuttujiin
        nimi = u_nimi;
        syntymavuosi = u_syntymavuosi;

        Console.WriteLine("asetaTiedot metodia käytetty");
    }

    //metodi, joka laskee iän
    public void laskeIka()
    {
        DateTime time = DateTime.Now; //haetaan päivä määrä
        int vuosi = time.Year; //tallennetaan vuosi
        ika = vuosi - syntymavuosi; //laskutoimitus

        Console.WriteLine("LaskeIka metodia käytetty");
    }

    //metodi joka palauttaa iän
    public int palautaIka()
    {
        Console.WriteLine("palautaIka metodia käytetty");
        return ika;
    }

    //metodi, joka palauttaa nimen
    public string palautaNimi()
    {
        Console.WriteLine("Palauta metodia käytetty");
        return nimi;
    }
}

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Oliotesti");
        Console.WriteLine();

        //Luot ensin olion henk1 oletuskonstruktorilla ja kysyt käyttäjältä etunimen ja syntymävuoden.
        //Sitten käytät asetaTiedot metodia, jolla asetat oliolle nimen ja syntymävuoden. Seuraavaksi
        //päivität luodun olion iän metodilla laskeIka. Lopuksi tulostat konsolille alla olevan tulosteen
        //mukaisen lauseen henk1 oliosta käyttäen metodeja palautaNimi ja palautaIka. 

        //Luodaan olio
        Console.WriteLine("Luodaan olio Henk1");
        henkilo henk1 = new henkilo();
        //Kysytään nimeä ja asetetaan muuttujaan
        Console.Write("Mikä on etunimesi? ");
        string u_nimi = Console.ReadLine();
        //Kysytään ikää ja asetetaan muuttujaan
        Console.Write("Minä vuonna olet syntynyt? ");
        int u_syntymavuosi = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        //asetetaan metodilla annetut tiedot
        henk1.asetaTiedot(u_nimi, u_syntymavuosi);
        //päivitetään olion henk1 ikä
        henk1.laskeIka();
        //Tulostetaan henk1 olion tiedot
        Console.WriteLine(" {0} täytät/täytit tänä vuonna {1} vuotta", henk1.palautaNimi(), henk1.palautaIka());
        Console.WriteLine();


        //Seuraavaksi luot olion henk2 ykikuormitetulla konstruktorilla (nimi=Seppo ja syntymävuosi =1980).
        //Seuraavaksi päivität luodun olion iän metodilla laskeIka. Lopuksi tulostat konsolille alla olevan
        //tulosteen mukaisen lauseen henk2 oliosta käyttäen metodeja palautaNimi ja palautaIka. 

        //Luodaan olio/toinen henkilö käyttäen ylikuormitettua konstruktoria
        Console.WriteLine("Luodaan olio henk2");
        henkilo henk2 = new henkilo("seppo", 1980);
        //päivitetään olion henk2 ikä
        henk2.laskeIka();
        //Tulostetaan henk2 oliosta tiedot
        Console.WriteLine(" {0} täytät/täytit tänä vuonna {1} vuotta", henk2.palautaNimi(), henk2.palautaIka());
    }
}