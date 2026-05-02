using System;
using Modul9_103022400138;

public class Program
{
    public static void Main(string[] args)
    {
        BankTransferConfig bankTransferConfig = new BankTransferConfig();
        bankTransferConfig.ReadConfigFile();

        if (bankTransferConfig.config.lang == "en") 
        { 
            Console.WriteLine("Please insert the amount of money to \r\ntransfer: ");
        }
        else
        {
            Console.WriteLine("Masukkan jumlah uang yang akan ditransfer: ");
        }

        string Input = Console.ReadLine();

        if(Input <= bankTransferConfig.config.transfer.threshold)
        {
            bankTransferConfig.config.transfer_fee = bankTransferConfig.config.low_fee;
        }
        else
        {
            bankTransferConfig.config.transfer_fee = bankTransferConfig.config.high_fee;
        }

        if(bankTransferConfig.config.lang == "en") 
        { 
            Console.WriteLine("Transfer Fee = ");
            Console.WriteLine("Amount = ");
            Console.WriteLine("Select transfer method: ");
        }
        else
        {
            Console.WriteLine("Biaya Transfer = ");
            Console.WriteLine("Total Biaya = ");
            Console.WriteLine("Pilih metode transfer: ");
        }

        for (int i = 0; i < bankTransferConfig.config.methods.Count; i++)
        {
            Console.WriteLine($"{i+1}. {bankTransferConfig.config.methods[i]}");
        }

        string Json = Console.ReadLine();
    }
}