//VOID
string cifrazione(string frase, int spostamento, int cambio)
{
    string lettere = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    char[]finale= new char[frase.Length];
    int t = spostamento, c = cambio;
    for (int i=0;i< frase.Length; i++)
    {
        spostamento = t;
        cambio = c;
        while (i + spostamento >= frase.Length)
        {
            spostamento -= frase.Length;
        }
        finale[i+spostamento] = frase[i];
        int pos=lettere.IndexOf(finale[i+spostamento]);
        while (pos + cambio >= lettere.Length)
        {
            cambio-=lettere.Length;
        }
        finale[i + spostamento] = lettere[pos + cambio];
    }
    string frase2="";
    for(int i = 0; i < finale.Length; i++)
    {
        frase2 += finale[i];
    }
    return frase2;
}
string decifrazione(string frase, int spostamento, int cambio)
{
    string lettere = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    char[] finale = new char[frase.Length];
    int t=spostamento, c=cambio;
    for(int i = 0; i < frase.Length; i++)
    {
        spostamento = t;
        cambio = c;
        while(i-spostamento < 0)
        {
            spostamento -= frase.Length;
        }
        finale[i - spostamento] = frase[i];
        int pos = lettere.IndexOf(finale[i - spostamento]);
        while (pos - cambio < 0)
        {
            cambio -= lettere.Length;
        }
        finale[i - spostamento] = lettere[pos - cambio];
    }
    string frase2 = "";
    for (int i = 0; i < finale.Length; i++)
    {
        frase2 += finale[i];
    }
    return frase2;
}
//MAIN
Console.WriteLine("Dammi la frase da cifrare");
string frase = Console.ReadLine();
Console.WriteLine("Di quante posizioni vuoi spostare i valori?");
int spostamento=int.Parse(Console.ReadLine());
Console.WriteLine("Di quanto vuoi modificare le lettere?");
int cambio=int.Parse(Console.ReadLine());
string fraseCifrata=cifrazione(frase.ToUpper(), spostamento, cambio);
Console.WriteLine($"La frase cifrata è {fraseCifrata}");
Console.WriteLine($"La frase decifrata è {decifrazione(fraseCifrata, spostamento, cambio)}");