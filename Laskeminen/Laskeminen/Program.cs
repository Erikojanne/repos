// See https://aka.ms/new-console-template for more information

int luku;

Console.Write(" Anna luku 1 ja 10 välistä ? ");
luku = int.Parse(Console.ReadLine());
Console.WriteLine();

int tulo = luku * 1;
int tulo1 = luku * 2;
int tulo2 = luku * 3;
int tulo3 = luku * 4;
int tulo4 = luku * 5;


int osamaara = 1 / luku;
int osamaara1 = 2 / luku;
int osamaara2= 3 / luku;
int osamaara3 = 4/ luku;
int osamaara4 = 5 / luku;

int jakojaannos = luku % 1;
int jakojaannos1 = luku % 2;
int jakojaannos2 = luku % 3;
int jakojaannos3 = luku % 4;
int jakojaannos4 = luku % 5;

Console.WriteLine(" 1 * " + luku + " = " + tulo + "    1 / " + luku + " = " + osamaara + "   1 % " + luku + " = " + jakojaannos);
Console.WriteLine(" 2 * " + luku + " = " + tulo1 + "   1 / " + luku + " = " + osamaara1 + "   2 % " + luku + " = " + jakojaannos1);
Console.WriteLine(" 3 * " + luku + " = " + tulo2 + "   2 / " + luku + " = " + osamaara2 + "   3 % " + luku + " = " + jakojaannos2);
Console.WriteLine(" 4 * " + luku + " = " + tulo3 + "   3 / " + luku + " = " + osamaara3 + "   4 % " + luku + " = " + jakojaannos3);
Console.WriteLine(" 5 * " + luku + " = " + tulo4 + "   4 / " + luku + " = " + osamaara4 + "   5 % " + luku + " = " + jakojaannos4);