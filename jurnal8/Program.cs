using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnal8
{
    class program
    {
        static bool Main(string[] args)
        {
            int trf, pilih;
            BankTransferConfig Conf = new BankTransferConfig();
            Console.WriteLine("Language / Bahasa :");
            Conf.configuration.lang = Console.ReadLine();
            if (Conf.configuration.lang == "en") ;
            {
                Console.WriteLine("please insert the amountof the money to transfer" );
                trf = Convert.ToInt(Console.ReadLine());

                if ( trf < Conf.configuration.transfer.thereshold)
                {
                    Console.WriteLine("Transfer Fee = " + Conf.cofigutation.low_fee);
                    Console.WriteLine("Total Amount = " + (trf + Conf.configuration.transfer.transfer.low_fee));
                    Console.WriteLine("Select Transfer Method : ");
                    for (int i = 0; i < Conf.configuration.methods.Count; i++)
                    {
                        Console.WriteLine((i+1) + " " + Conf.configuration.methods[i]);
                    }

                    pilih = Convert.ToInt32(Console.ReadLine());
                    if (pilih == 1)
                    {
                        Console.WriteLine("Please type 'yes' to confirm to the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmation.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("The transfer is cancelied");
                            Console.Read ();
                        }
                    }
                    else if (pilih == 2)
                    {
                        Console.WriteLine("please type 'yes' to confirm to the transaction :");
                        string crf = Console.ReadLine();
                        if (crf == Configuration.confirmations.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("The transer is cancelled");
                            Console.Read ();
                        }
                    }
                    else if ((pilih == 3)
                    {
                        Console.WriteLine("Please type 'yes' to confirm to the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmation.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("The transfer is cancelied");
                            Console.Read();
                        }
                    }
                    else if ((pilih == 4)
                    {
                        Console.WriteLine("Please type 'yes' to confirm to the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmation.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("The transfer is cancelied");
                            Console.Read();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Transfer Fee = " + Conf.configuration.transfer.high.fee);
                    Console.WriteLine("Total Amount = " + (trf + Conf.configuration.transfer.transfer.high_fee));
                    Console.WriteLine("Select Transfer Method : ");
                    for (int i = 0; i < Conf.configuration.methods.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " " + Conf.configuration.methods[i]);
                    }
                    pilih = Convert.ToInt32(Console.ReadLine());
                    if (pilih == 1) 
                    {
                        Console.WriteLine("Please type 'yes' to confirm to the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmation.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("The transfer is cancelied");
                            Console.Read();
                        }
                    }
                    else if(pilih == 2)
                    {
                        Console.WriteLine("Please type 'yes' to confirm to the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmation.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("The transfer is cancelied");
                            Console.Read();
                        }
                    }
                    else if (pilih == 3)
                    {
                        Console.WriteLine("Please type 'yes' to confirm to the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmation.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("The transfer is cancelied");
                            Console.Read();
                        }
                    }
                    else if ((pilih == 4) 
                    {
                        Console.WriteLine("Please type 'yes' to confirm to the transaction : ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmation.en)
                        {
                            Console.WriteLine("The transfer is completed");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("The transfer is cancelied");
                            Console.Read();
                        }
                    }
                }
            }else if (Conf.configuration.confirmation.lang == "id")
            {
                Console.WriteLine("Masukan jumlah uang yang akan di-transfer: ");
                trf = Convert.ToInt32(Console.ReadLine());
                if (trf <= Conf.configuration.transfer.thereshold)
                {
                    Console.WriteLine("Biaya Transfer = " + Conf.configuration.transfer.low_fee);
                    Console.WriteLine("Total Biaya = " + (trf + Conf.configuration.transfer.transfer.low_fee));
                    Console.WriteLine("Pilih Metode Transfer : ");
                    Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi: ");
                    if (ComRegisterFunctionAttribute == Conf.configuration.confirmations.id)
                    {
                        Console.WriteLine("Proses transfer berhasil");
                    }
                    else 
                    {
                        Console.WriteLine("Transfer dibatalkan");
                    }
                }
                else
                {
                    Console.WriteLine("Biaya Transfer = " + Conf.configuration.transfer.high_fee);
                    Console.WriteLine("Total Biaya = " + (trf + Conf.configuration.transfer.transfer.high_fee));
                    Console.WriteLine("Pilih Metode Transfer : ");
                    for (int i = 0; i < Conf.configuration.methods.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " " + Conf.configuration.methods[i]);
                    }
                    pilih = Convert.ToInt32(Console.ReadLine());
                    if (pilih == 1)
                    {
                        Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi: ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmation.en)
                        {
                            Console.WriteLine("Proses transfer berhasil");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("ransfer dibatalkan");
                            Console.Read();
                        }
                    }
                    else if (pilih == 2)
                    {
                        Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi: ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmation.en)
                        {
                            Console.WriteLine("Proses transfer berhasil");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("ransfer dibatalkan");
                            Console.Read();
                        }
                    }
                    else if(pilih == 3)
                    {
                        Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi: ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmation.en)
                        {
                            Console.WriteLine("Proses transfer berhasil");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("ransfer dibatalkan");
                            Console.Read();
                        }
                    }
                    else if ((pilih == 4)
                    {
                        Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi: ");
                        string crf = Console.ReadLine();
                        if (crf == Conf.configuration.confirmation.en)
                        {
                            Console.WriteLine("Proses transfer berhasil");
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("ransfer dibatalkan");
                            Console.Read();
                        }
                    }
            }
        }
    }
}
    public class Config
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public Confirmations confirmations { get; set; }

        public Config()
        {

        }
        public Config(string bhs, Transfer trf, List<string> mtd, Confirmations cfr)
        {
            lang = bhs;
            transfer = trf;
            methods = mtd;
            confirmations = cfr;
        }
        public class Transfer
        {
            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }
            public Transfer(int threshold, int low_fee, int high_fee)
            {
                this.threshold = threshold;
                this.low_fee = low_fee;
                this.high_fee = high_fee;
            }
        }
        public class Methods
        {
            public string metode { get; set; }
        }
        public class Confirmations
        {
            public string en { get; set; }
            public string id { get; set; }

            public Confirmations(string en, string id)
            {
                this.en = en;
                this.id = id;

            }
        }
    }
    public class BankTransferConfig
    {
        public Config configuration;
        public const string filePath = "D:\SEMESTER 4\PRAK KPL\MOD8\jurnal8\bin\Debug\\bank_transfer_config.json";

        public BankTransferConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }

        private void SetDefault()
        {

            List<string> met = new List<string>();
            met.Add("RTO(real - time)");
            met.Add("SKN");
            met.Add("RTGS");
            met.Add("BI FAST");
            configuration = new Config("en", new Config.Transfer(25000000, 6500, 15000), met, new Config.Confirmations("yes", "ya"));
        }

        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String jsonString = System.Text.Json.JsonSerializer.Serialize(configuration, options);
            File.WriteAllText(filePath, jsonString);
        }

        private Config ReadConfigFile()
        {
            String configJsonData = File.ReadAllText(filePath);
            configuration = System.Text.Json.JsonSerializer.Deserialize<Config>(configJsonData);
            return configuration;
        }
    }
}
