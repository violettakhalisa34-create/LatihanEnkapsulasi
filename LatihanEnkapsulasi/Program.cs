RekeningBank newrekening = new RekeningBank("123456789");

string pilihan;
double jumlah;

while (true)
{
    Console.WriteLine("selamat datang di atm moklet");
    Console.WriteLine("1. display info rekening");
    Console.WriteLine("2. setor uang");
    Console.WriteLine("3. Tarik uang");
    Console.WriteLine("4. keluar");
    Console.Write("pilihan anda: ");
    pilihan = Console.ReadLine();

    if (pilihan == "1")
    {
        newrekening.DisplayInfo();
    }
    else if (pilihan == "2")
    {
        Console.Write("\nMasukkan jumlah uang: Rp ");
        jumlah = double.Parse(Console.ReadLine());

        newrekening.SetorUang(jumlah);
    }
    else if (pilihan == "3")
    {
        Console.Write("\nMasukkan jumlah uang: Rp ");
        jumlah = double.Parse(Console.ReadLine());
    }
    else if (pilihan == "4")
    {
        Console.WriteLine("Terima kasih telah menggunakan layanan ATM SIGMA");
        break;
    }
    else
    {
        Console.WriteLine("Pilihan Anda tidak valid!");
    }

        Console.ReadLine();
}

public class RekeningBank
{
    private double _Saldo;
    private string _noRekening;

    public double Saldo
    {
        get { return _Saldo; }
        set
        {
            if (value >= 0) _Saldo = value;
            else Console.WriteLine("nilai saldo tidak boleh negatif!");
        }
    }
    
    public string NoRekening
    {
        get { return _noRekening; }
    }

    public RekeningBank(string norekening)
    {

        _Saldo = 100000;
        _noRekening = norekening;

    }

    public void TarikUang(double jumlah)
    {
        if (jumlah >= 0)
        {
            if (Saldo >= jumlah)
            {
                Saldo -= jumlah;
            }
            else
            {
                Console.WriteLine("saldo tidak mencukupi!");
            }
        }
        else
        {
            Console.WriteLine("jumlah uang tidak valid");
        }
    }

    public void SetorUang(double jumlah)
    {
        if (jumlah > 0)
        {
            Saldo += jumlah;
            Console.WriteLine("Berhenti sektor uang!");
        }
        else
        {
            Console.WriteLine("jumlah uang tidak valid");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("\nDisplay Info Rekening");
        Console.WriteLine($"no.rekening: {NoRekening}");
        Console.WriteLine($"Saldo saat ini: RP {Saldo}");

    }
}