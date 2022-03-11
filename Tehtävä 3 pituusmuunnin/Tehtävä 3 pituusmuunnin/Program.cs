// See https://aka.ms/new-console-template for more information


double pituus;

    Console.Write( "Anna pituutesi senttimetreinä ? ");
    pituus = double.Parse(Console.ReadLine());

Console.WriteLine();

    double metri = pituus / 100;
    double maili = pituus / 160934.7;
    double jaardi = pituus / 91.44;
    double tuuma = pituus / 02.54;

string metrit = string.Format("{0:0.00}", metri);
string mailit = string.Format("{0:0.00}", maili);
string jaardit = string.Format("{0:0.00}", jaardi);
string tuumat = string.Format("{0:0.00}", tuuma);

Console.WriteLine( metrit + " metriä");
Console.WriteLine( mailit + " mailia");
Console.WriteLine( jaardit + " jaardia");
Console.WriteLine( tuumat + " tuumaa");

Console.WriteLine();