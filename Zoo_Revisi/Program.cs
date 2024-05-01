using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            Console.Clear();
            string db = "ZOO";
            SqlConnection conn = null;
            string strKoneksi = "Data source = MSI\\ALIFIAN; " +
                  "initial catalog = {0}; " +
                  "User ID = sa; password = 123";
            conn = new SqlConnection(string.Format(strKoneksi, db));
            conn.Open();
            Console.Clear();
            while (true)
            {
                try
                {

                    Console.WriteLine("MENU UTAMA\n");
                    Console.WriteLine("1. MASTER");
                    Console.WriteLine("2. Perawatan");
                    Console.WriteLine("3. Pemeriksaan");
                    Console.WriteLine("4. Cetak Riwayat Kesehatan\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("5. EXIT");
                    Console.ResetColor();
                    Console.Write("\nEnter your choice (1-5): ");
                    char ch = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.Clear();
                    switch (ch)
                    {
                        case '1':
                            {
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("MENU MASTER");
                                        Console.WriteLine("Pilih data entitas yang akan dikelola\n");
                                        Console.WriteLine("1. HEWAN");
                                        Console.WriteLine("2. KEEPER");
                                        Console.WriteLine("3. DOKTER HEWAN\n");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("4. BACK");
                                        Console.ResetColor();
                                        Console.Write("\nEnter your choice (1-4): ");
                                        char ch1 = char.ToUpper(Console.ReadKey().KeyChar);
                                        Console.Clear();
                                        switch (ch1)
                                        {
                                            case '1':
                                                {
                                                    while (true)
                                                    {
                                                        try
                                                        {


                                                            Console.WriteLine("MENU HEWAN\n");
                                                            Console.WriteLine("ID Hewan :");
                                                            Console.WriteLine("Nama Hewan :");
                                                            Console.WriteLine("Jenis Hewan :");
                                                            Console.WriteLine("Spesies Hewan :");
                                                            Console.WriteLine("Jenis Kelamin :");
                                                            Console.WriteLine("Tanggal Lahir :");
                                                            Console.WriteLine("Tanggal Lahir :");
                                                            Console.WriteLine("Umur :");
                                                            Console.WriteLine("Berat :");
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("LIST Hewan");
                                                            Console.WriteLine("============");
                                                            pr.list(conn);
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("PILIHAN MENU");
                                                            Console.WriteLine("============");
                                                            Console.WriteLine("1. DETAIL SEMUA HEWAN");
                                                            Console.WriteLine("2. SEARCH HEWAN");
                                                            Console.WriteLine("3. INPUT HEWAN");
                                                            Console.WriteLine("4. UPDATE HEWAN");
                                                            Console.WriteLine("5. DELETE DATA HEWAN\n");
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("6. BACK");
                                                            Console.ResetColor();
                                                            Console.Write("\nEnter your choice (1-6): ");
                                                            char ch2 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            Console.Clear();
                                                            switch (ch2)
                                                            {
                                                                case '1':
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("\n============");
                                                                        Console.WriteLine("DETAIL SEMUA HEWAN");
                                                                        Console.WriteLine("============\n");
                                                                        pr.detail(conn);
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("1. BACK");
                                                                                Console.ResetColor();
                                                                                Console.Write("\nEnter your choice (1): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }

                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("\nInvalid option");
                                                                                            Console.ResetColor();
                                                                                            Console.ResetColor();
                                                                                        }
                                                                                        break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.WriteLine("\nAnda tidak dapat kembali / Data yang anda masukkan salah!");

                                                                            }
                                                                        }
                                                                    }
                                                                    break;

                                                                case '2':
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("===================");
                                                                        Console.WriteLine("LIST HEWAN TERSEDIA");
                                                                        Console.WriteLine("===================");
                                                                        pr.list(conn);
                                                                        Console.WriteLine("===================\n");
                                                                        Console.WriteLine("Masukkan ID Hewan yang Ingin Dilihat:");
                                                                        string idH = Console.ReadLine();
                                                                        Console.Clear();
                                                                        try
                                                                        {
                                                                            pr.baca(idH, conn);
                                                                        }

                                                                        catch (Exception)
                                                                        {
                                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                              "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                        }
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("1. BACK");
                                                                                Console.ResetColor();
                                                                                Console.Write("\nEnter your choice (1): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                Console.Clear();
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }

                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("!!!Pilihan tidak tersedia\n");
                                                                                            Console.ResetColor();
                                                                                        }
                                                                                        break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.WriteLine("\nAnda tidak dapat kembali / Data yang anda masukkan salah!");

                                                                            }

                                                                        }
                                                                    }
                                                                    break;
                                                                case '3':
                                                                    {
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("INPUT DATA HEWAN\n");
                                                                                Console.WriteLine("================================");
                                                                                Console.WriteLine("         TABEL KODE HEWAN       ");
                                                                                Console.WriteLine("================================");
                                                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                                                Console.WriteLine("|    Jenis   |   Ket            |");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("================================");
                                                                                Console.WriteLine("|    MM      |   Mamalia        |\n" +
                                                                                    "|    RP      |   Reptile        |\n" +
                                                                                    "|    BR      |   Burung         |\n" +
                                                                                    "|    IK      |   Ikan           |\n" +
                                                                                    "|    AM      |   Amfibi         |\n" +
                                                                                    "|    SR      |   Serangga       |\n" +
                                                                                    "|    MC      |   Molusca        |");
                                                                                Console.WriteLine("================================");
                                                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                                                Console.WriteLine("|   Spesies |   ket             |");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine("================================");
                                                                                Console.WriteLine("|   LL      |   Lumba-Lumba     |\n" +
                                                                                    "|   LL      |   Lumba-Lumba     |");
                                                                                Console.WriteLine("================================");
                                                                                Console.WriteLine("Contoh   : MMLL0001\n");
                                                                                Console.WriteLine("Masukkan ID Hewan :");
                                                                                string idH = Console.ReadLine();
                                                                                if (string.IsNullOrEmpty(idH))
                                                                                {
                                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                                    Console.WriteLine("!!!!Data Wajib Diisi\n");
                                                                                    Console.ResetColor();
                                                                                }
                                                                                Console.WriteLine("Masukkan Nama Hewan :");
                                                                                string nmH = Console.ReadLine();
                                                                                Console.WriteLine("Masukkan Jenis Hewan (Mamalia/Reptil/Burung/Ikan/Amfibi/Serangga/Molusca) :");
                                                                                string jsH = Console.ReadLine();
                                                                                if (string.IsNullOrEmpty(jsH))
                                                                                {
                                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                                    Console.WriteLine("!!!!Data Wajib Diisi\n");
                                                                                    Console.ResetColor();
                                                                                }
                                                                                Console.WriteLine("Masukkan Spesies Hewan (Harimau benggala/Harimau Sumatra/ DLL) :");
                                                                                string spH = Console.ReadLine();
                                                                                if (string.IsNullOrEmpty(spH))
                                                                                {
                                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                                    Console.WriteLine("!!!!Data Wajib Diisi\n");
                                                                                    Console.ResetColor();
                                                                                }
                                                                                Console.WriteLine("Masukkan Jenis Kelamin Hewan (Betina / Jantan) :");
                                                                                string jkH = Console.ReadLine();
                                                                                if (string.IsNullOrEmpty(jkH))
                                                                                {
                                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                                    Console.WriteLine("!!!!Data Wajib Diisi\n");
                                                                                    Console.ResetColor();
                                                                                }
                                                                                Console.WriteLine("Masukkan Tanggal Lahir Hewan (Tahun-Bulan-Tanggal) :");
                                                                                string tglH = Console.ReadLine();
                                                                                Console.WriteLine("Masukkan Tanggal Masuk Hewan (Tahun-Bulan-Tanggal) :");
                                                                                string tglmH = Console.ReadLine();
                                                                                Console.WriteLine("Masukkan Berat Hewan (Per KG) :");
                                                                                string br = Console.ReadLine();


                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. SAVE");
                                                                                Console.WriteLine("2. CANCEL\n");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("3. BACK");
                                                                                Console.ResetColor();
                                                                                Console.Write("\nEnter your choice (1-3): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                Console.Clear();
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            try
                                                                                            {
                                                                                                pr.insert(idH, nmH, jsH, spH, jkH, tglH, tglmH, br, conn);

                                                                                            }
                                                                                            catch (Exception)
                                                                                            {
                                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                                Console.WriteLine("\n!!! DATA SALAH sehingga tidak dapat disimpan (Tekan ENTER)");
                                                                                                Console.ResetColor();
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '2':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    case '3':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }

                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("\nInvalid option");
                                                                                            Console.ResetColor();
                                                                                        }
                                                                                        break;
                                                                                }
                                                                                if (ch6 == '3')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.ReadLine();
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk menambah data atau Data yang anda masukkan salah");
                                                                                Console.ResetColor();
                                                                            }
                                                                        }

                                                                    }
                                                                    break;

                                                                case '4':
                                                                    {
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Update Data Hewan\n");
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("LIST Hewan");
                                                                                Console.WriteLine("============");
                                                                                pr.list(conn);

                                                                                Console.WriteLine("Masukkan ID Hewan yang Ingin Diubah:");
                                                                                string idH = Console.ReadLine();

                                                                                // Meminta pengguna memasukkan nama baru
                                                                                Console.WriteLine("Masukkan Nama Hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                string nmH = Console.ReadLine();

                                                                                // Meminta pengguna memasukkan jenis hewan baru
                                                                                Console.WriteLine("Masukkan Jenis Hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                string jsH = Console.ReadLine();

                                                                                Console.WriteLine("Masukkan Spesies Hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                string spH = Console.ReadLine();

                                                                                Console.WriteLine("Masukkan Jenis kelamin Hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                string jkH = Console.ReadLine();

                                                                                Console.WriteLine("Masukkan Tanggal lahir Hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                string tglH = Console.ReadLine();

                                                                                Console.WriteLine("Masukkan Tanggal masuk Hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                string tglmH = Console.ReadLine();

                                                                                Console.WriteLine("Masukkan Berat Hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                string br = Console.ReadLine();

                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. UPDATE");
                                                                                Console.WriteLine("2. CANCEL");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("3. BACK");
                                                                                Console.ResetColor();
                                                                                Console.Write("\nEnter your choice (1-3): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            try
                                                                                            {
                                                                                                pr.update(idH, nmH, jsH, spH, jkH, tglH, tglmH, br, conn);
                                                                                            }

                                                                                            catch (Exception)
                                                                                            {
                                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk mengubah data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                                                Console.ResetColor();
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '2':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    case '3':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("\nInvalid option");
                                                                                            Console.ResetColor();
                                                                                        }
                                                                                        break;

                                                                                }
                                                                                if (ch6 == '3')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.ReadLine();
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk mengubah data atau Data yang anda masukkan salah");
                                                                                Console.ResetColor();
                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                                case '5':
                                                                    {
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Anda memilih DELETE.");
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("LIST Hewan");
                                                                                Console.WriteLine("============");
                                                                                pr.list(conn);
                                                                                Console.WriteLine("Masukkan ID Hewan yang Ingin Dihapus:");
                                                                                string idH = Console.ReadLine();
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. DELETE");
                                                                                Console.WriteLine("2. CANCEL");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("3. BACK");
                                                                                Console.ResetColor();
                                                                                Console.Write("\nEnter your choice (1-3): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            try
                                                                                            {
                                                                                                pr.delete(idH, conn);
                                                                                            }
                                                                                            catch (Exception)
                                                                                            {
                                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk menghapus data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                                                Console.ResetColor();

                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '2':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    case '3':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("\nInvalid option");
                                                                                            Console.ResetColor();
                                                                                        }
                                                                                        break;
                                                                                }
                                                                                if (ch6 == '3')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.ReadLine();
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }

                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk menghapus data atau Data yang anda masukkan salah");
                                                                                Console.ResetColor();

                                                                            }
                                                                        }

                                                                    }
                                                                    break;

                                                                case '6':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                        Console.WriteLine("\nInvalid option");
                                                                        Console.ResetColor();

                                                                    }
                                                                    break;

                                                            }
                                                            if (ch2 == '6')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.Clear();
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("\nCheck for the value entered.");
                                                            Console.ResetColor();
                                                        }
                                                    }
                                                }
                                                break;
                                            case '2':
                                                {
                                                    while (true)
                                                    {
                                                        try
                                                        {

                                                            Console.WriteLine("\nMenu KEEPER");
                                                            Console.WriteLine("===========");
                                                            Console.WriteLine("ID Keeper :");
                                                            Console.WriteLine("Nama Keeper :");
                                                            Console.WriteLine("Alamat Keeper :");
                                                            Console.WriteLine("Nomor Telepon Keeper :");
                                                            Console.WriteLine("\n===========");
                                                            Console.WriteLine("LIST Keeper");
                                                            Console.WriteLine("===========");
                                                            pr.list1(conn);
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("PILIHAN MENU");
                                                            Console.WriteLine("============");
                                                            Console.WriteLine("1. READ");
                                                            Console.WriteLine("2. SEARCH");
                                                            Console.WriteLine("3. INPUT");
                                                            Console.WriteLine("4. UPDATE");
                                                            Console.WriteLine("5. DELETE");
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("6. BACK");
                                                            Console.ResetColor();
                                                            Console.Write("\nEnter your choice (1-6): ");
                                                            char ch2 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch (ch2)
                                                            {
                                                                case '1':
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("\n============");
                                                                        Console.WriteLine("Data Keeper\n");
                                                                        Console.WriteLine("============");
                                                                        pr.detail1(conn);
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("1. BACK");
                                                                                Console.ResetColor();
                                                                                Console.Write("\nEnter your choice (1): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }

                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("\nInvalid option");
                                                                                            Console.WriteLine();
                                                                                        }
                                                                                        break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                                Console.ResetColor();
                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                                case '2':
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("Anda memilih SEARCH.");
                                                                        Console.WriteLine("Data Keeper\n");
                                                                        pr.list1(conn);
                                                                        Console.WriteLine("Masukkan ID Keeper yang Ingin Dilihat:");
                                                                        string idK = Console.ReadLine();
                                                                        try
                                                                        {
                                                                            pr.baca1(idK, conn);
                                                                        }
                                                                        catch (Exception)
                                                                        {
                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                                "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                            Console.ResetColor();
                                                                        }
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("1. BACK");
                                                                                Console.ResetColor();
                                                                                Console.Write("\nEnter your choice (1): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }

                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("\nInvalid option");
                                                                                            Console.ResetColor();
                                                                                        }
                                                                                        break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                                Console.ResetColor();
                                                                            }

                                                                        }
                                                                    }
                                                                    break;
                                                                case '3':
                                                                    {
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("INPUT DATA KEEPER\n");
                                                                                Console.WriteLine("|  TahunLahir(4)  |  BulanLahir(2)   |   TanggalLahir(2)   |   TahunMasuk(4)   |   BulanMasuk(2)   |   JenisKelamin(1) |   NoUrut(3) |\n" +
                                                                                    "**JenisKelamin(1): 1 untuk Pria / 2 untuk Wanita");
                                                                                Console.WriteLine("Contoh   :   200409242020101001\n");
                                                                                Console.WriteLine("Masukkan ID Keeper :");
                                                                                string idK = Console.ReadLine();
                                                                                Console.WriteLine("Masukkan Nama Keeper :");
                                                                                string nmK = Console.ReadLine();
                                                                                Console.WriteLine("Masukkan Alamat Keeper :");
                                                                                string almtK = Console.ReadLine();
                                                                                Console.WriteLine("Masukkan Nomor Telepon (08xxxxxxxxxxx maks 13 digit) :");
                                                                                string tlpK = Console.ReadLine();
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. SAVE");
                                                                                Console.WriteLine("2. CANCEL");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("3. BACK");
                                                                                Console.ResetColor();
                                                                                Console.Write("\nEnter your choice (1-3): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                Console.Clear();
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            try
                                                                                            {
                                                                                                pr.insert1(idK, nmK, almtK, tlpK, conn);

                                                                                            }
                                                                                            catch (Exception)
                                                                                            {
                                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk menambah data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                                                Console.ResetColor();
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '2':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    case '3':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("\nInvalid option");
                                                                                            Console.ResetColor();
                                                                                        }
                                                                                        break;

                                                                                }
                                                                                if (ch6 == '3')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.ReadLine();
                                                                                    Console.Clear();
                                                                                    break;

                                                                                }

                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk menambah data atau Data yang anda masukkan salah");
                                                                                Console.ResetColor();
                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                                case '4':
                                                                    {
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Update Data Keeper\n");
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("LIST Keeper");
                                                                                Console.WriteLine("============");
                                                                                pr.list1(conn);

                                                                                Console.WriteLine("Masukkan ID Keeper yang Ingin Diubah:");
                                                                                string idK = Console.ReadLine();

                                                                                Console.WriteLine("Masukkan Nama Keeper Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                string nmK = Console.ReadLine();

                                                                                Console.WriteLine("Masukkan alamat Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                string almtK = Console.ReadLine();

                                                                                Console.WriteLine("Masukkan Nomor telpon Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                string tlpK = Console.ReadLine();

                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. UPDATE");
                                                                                Console.WriteLine("2. CANCEL");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("3. BACK");
                                                                                Console.ResetColor();
                                                                                Console.Write("\nEnter your choice (1-3): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            try
                                                                                            {
                                                                                                pr.update1(idK, nmK, almtK, tlpK, conn);
                                                                                            }

                                                                                            catch (Exception)
                                                                                            {
                                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk mengubah data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                                                Console.ResetColor();
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '2':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    case '3':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("\nInvalid option");
                                                                                            Console.ResetColor();

                                                                                        }
                                                                                        break;

                                                                                }
                                                                                if (ch6 == '3')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.ReadLine();
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }

                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk mengubah data atau Data yang anda masukkan salah");
                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                                case '5':
                                                                    {
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Anda memilih DELETE.");
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("LIST Keeper");
                                                                                Console.WriteLine("============");
                                                                                pr.list1(conn);
                                                                                Console.WriteLine("Masukkan ID Keeper yang Ingin Dihapus:");
                                                                                string idK = Console.ReadLine();
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. DELETE");
                                                                                Console.WriteLine("2. CANCEL");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("3. BACK");
                                                                                Console.ResetColor();
                                                                                Console.Write("\nEnter your choice (1-3): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            try
                                                                                            {
                                                                                                pr.delete1(idK, conn);
                                                                                            }
                                                                                            catch (Exception)
                                                                                            {
                                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk menghapus data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                                                Console.ResetColor();

                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '2':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    case '3':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("\nInvalid option");
                                                                                            Console.ResetColor();
                                                                                        }
                                                                                        break;
                                                                                }
                                                                                if (ch6 == '3')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.ReadLine();
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk menghapus data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                                Console.ResetColor();

                                                                            }
                                                                        }
                                                                    }
                                                                    break;

                                                                case '6':
                                                                    {

                                                                        Console.Clear();
                                                                        break;
                                                                    }

                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                        Console.WriteLine("\nInvalid option");
                                                                        Console.ResetColor();

                                                                    }
                                                                    break;

                                                            }
                                                            if (ch2 == '6')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("\nCheck for the value entered.");
                                                        }
                                                    }
                                                }
                                                break;
                                            case '3':
                                                {
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("\nMenu DOKTER HEWAN");
                                                            Console.WriteLine("=================");
                                                            Console.WriteLine("ID Dokter Hewan :");
                                                            Console.WriteLine("Nama Dokter Hewan :");
                                                            Console.WriteLine("Alamat Dokter Hewan :");
                                                            Console.WriteLine("Nomor Telepon Dokter Hewan :");
                                                            Console.WriteLine("\n=================");
                                                            Console.WriteLine("LIST Dokter Hewan");
                                                            Console.WriteLine("=================");
                                                            pr.list2(conn);
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("PILIHAN MENU");
                                                            Console.WriteLine("============");
                                                            Console.WriteLine("1. READ");
                                                            Console.WriteLine("2. SEARCH");
                                                            Console.WriteLine("3. INPUT");
                                                            Console.WriteLine("4. UPDATE");
                                                            Console.WriteLine("5. DELETE");
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("6. BACK");
                                                            Console.ResetColor();
                                                            Console.Write("\nEnter your choice (1-6): ");
                                                            char ch2 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch (ch2)
                                                            {
                                                                case '1':
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("\n============");
                                                                        Console.WriteLine("Data Dokter Hewan\n");
                                                                        Console.WriteLine("============");
                                                                        pr.detail2(conn);
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("1. BACK");
                                                                                Console.ResetColor();
                                                                                Console.Write("\nEnter your choice (1): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }

                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("\nInvalid option");
                                                                                            Console.ResetColor();
                                                                                        }
                                                                                        break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk melihat data atau Data yang anda masukkan salah");

                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                                case '2':
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("Anda memilih SEARCH.");
                                                                        Console.Clear();
                                                                        Console.WriteLine("Data Dokter Hewan\n");
                                                                        pr.list2(conn);
                                                                        Console.WriteLine("Masukkan ID Dokter Hewan yang Ingin Dilihat:");
                                                                        string idDH = Console.ReadLine();
                                                                        try
                                                                        {
                                                                            pr.baca2(idDH, conn);
                                                                        }
                                                                        catch (Exception)
                                                                        {
                                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                                "akses untuk melihat data atau Data yang anda masukkan salah");

                                                                        }
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. BACK");
                                                                                Console.Write("\nEnter your choice (1): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }

                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("\nInvalid option");
                                                                                            Console.ResetColor();
                                                                                        }
                                                                                        break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk melihat data atau Data yang anda masukkan salah");
                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                                case '3':
                                                                    {
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Anda memilih INPUT.");
                                                                                Console.WriteLine("Input Data Dokter Hewan\n");
                                                                                Console.WriteLine("Masukkan ID Dokter hewan :");
                                                                                Console.WriteLine("KET: TahunLahir(4)BulanLahir(2)TanggalLahir(2)TahunMasuk(4)BulanMasuk(2)JenisKelamin(1)NoUrut(3)");
                                                                                Console.WriteLine("JenisKelamin(1): 1 untuk Pria / 2 untuk Wanita");
                                                                                string idDH = Console.ReadLine();
                                                                                Console.WriteLine("Masukkan Nama Dokter Hewan :");
                                                                                string nmDH = Console.ReadLine();
                                                                                Console.WriteLine("Masukkan Alamat Dokter Hewan :");
                                                                                string almtDH = Console.ReadLine();
                                                                                Console.WriteLine("Masukkan Nomor Telepon (0888888888888 maks 13 digit) :");
                                                                                string tlpDH = Console.ReadLine();
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. SAVE");
                                                                                Console.WriteLine("2. CANCEL");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("3. BACK");
                                                                                Console.ResetColor();
                                                                                Console.Write("\nEnter your choice (1-3): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            try
                                                                                            {
                                                                                                pr.insert2(idDH, nmDH, almtDH, tlpDH, conn);

                                                                                            }
                                                                                            catch (Exception)
                                                                                            {
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk menambah data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '2':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    case '3':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("\nInvalid option");
                                                                                            Console.ResetColor();

                                                                                        }
                                                                                        break;
                                                                                }
                                                                                if (ch6 == '3')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.ReadLine();
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk menambah data atau Data yang anda masukkan salah");

                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                                case '4':
                                                                    {
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Update Data Dokter Hewan\n");
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("LIST Dokter Hewan");
                                                                                Console.WriteLine("============");
                                                                                pr.list2(conn);
                                                                                Console.WriteLine("Masukkan ID Keeper yang Ingin Diubah:");
                                                                                string idDH = Console.ReadLine();

                                                                                Console.WriteLine("Masukkan Nama Dokter hewan Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                string nmDH = Console.ReadLine();

                                                                                Console.WriteLine("Masukkan alamat Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                string almtDH = Console.ReadLine();

                                                                                Console.WriteLine("Masukkan Nomor telpon Baru (biarkan kosong jika tidak ingin mengubah):");
                                                                                string tlpDH = Console.ReadLine();
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. UPDATE");
                                                                                Console.WriteLine("2. CANCEL");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("3. BACK");
                                                                                Console.ResetColor();
                                                                                Console.Write("\nEnter your choice (1-3): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            try
                                                                                            {
                                                                                                pr.update2(idDH, nmDH, almtDH, tlpDH, conn);
                                                                                            }

                                                                                            catch (Exception)
                                                                                            {
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk mengubah data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '2':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    case '3':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("\nInvalid option");
                                                                                            Console.ResetColor();
                                                                                        }
                                                                                        break;
                                                                                }
                                                                                if (ch6 == '3')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.ReadLine();
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }

                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk mengubah data atau Data yang anda masukkan salah");

                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                                case '5':
                                                                    {
                                                                        while (true)
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Anda memilih DELETE.");
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("LIST Dokter Hewan");
                                                                                Console.WriteLine("============");
                                                                                pr.list2(conn);
                                                                                Console.WriteLine("Masukkan ID Dokter Hewan yang Ingin Dihapus:");
                                                                                string idDH = Console.ReadLine();
                                                                                Console.WriteLine("\n============");
                                                                                Console.WriteLine("PILIHAN MENU");
                                                                                Console.WriteLine("============");
                                                                                Console.WriteLine("1. DELETE");
                                                                                Console.WriteLine("2. CANCEL");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("3. BACK");
                                                                                Console.ResetColor();
                                                                                Console.Write("\nEnter your choice (1-3): ");
                                                                                char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                                                switch (ch6)
                                                                                {
                                                                                    case '1':
                                                                                        {
                                                                                            try
                                                                                            {
                                                                                                pr.delete2(idDH, conn);
                                                                                            }
                                                                                            catch (Exception)
                                                                                            {
                                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                                    "akses untuk menghapus data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                                                Console.ResetColor();
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    case '2':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    case '3':
                                                                                        {
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                    default:
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                                            Console.WriteLine("\nInvalid option");
                                                                                            Console.ResetColor();
                                                                                        }
                                                                                        break;

                                                                                }
                                                                                if (ch6 == '3')
                                                                                {
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                                if (ch6 == '1')
                                                                                {
                                                                                    Console.ReadLine();
                                                                                    Console.Clear();
                                                                                    break;
                                                                                }
                                                                            }
                                                                            catch (Exception)
                                                                            {
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("\nAnda tidak memiliki " +
                                                                                    "akses untuk menghapus data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                                Console.ResetColor();

                                                                            }
                                                                        }
                                                                    }
                                                                    break;

                                                                case '6':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                        Console.WriteLine("\nInvalid option");
                                                                        Console.ResetColor();
                                                                    }
                                                                    break;
                                                            }
                                                            if (ch2 == '6')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("\nCheck for the value entered.");
                                                        }
                                                    }
                                                }
                                                break;
                                            case '4':
                                                {
                                                    Console.Clear();
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("\nInvalid option");
                                                    Console.ResetColor();
                                                }
                                                break;
                                        }
                                        if (ch1 == '4')
                                        {
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nCheck for the value entered.");
                                    }
                                }
                            }
                            break;
                        case '2':
                            {
                                while (true)
                                {
                                    try
                                    {

                                        Console.WriteLine("\nMenu Perawatan");
                                        Console.WriteLine("==============");
                                        Console.WriteLine("ID Perawatan :");
                                        Console.WriteLine("ID Keeper :");
                                        Console.WriteLine("ID Hewan :");
                                        Console.WriteLine("Tanggal Perawatan :");
                                        Console.WriteLine("Kondisi Hewan :");
                                        Console.WriteLine("Detail Perawatan :");
                                        Console.WriteLine("\n==============");
                                        Console.WriteLine("LIST Perawatan");
                                        Console.WriteLine("==============");
                                        pr.list3(conn);
                                        Console.WriteLine("\n============");
                                        Console.WriteLine("PILIHAN MENU");
                                        Console.WriteLine("============");
                                        Console.WriteLine("1. READ");
                                        Console.WriteLine("2. SEARCH");
                                        Console.WriteLine("3. INPUT");
                                        Console.WriteLine("4. UPDATE");
                                        Console.WriteLine("5. DELETE");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("6. BACK");
                                        Console.ResetColor();
                                        Console.Write("\nEnter your choice (1-6): ");
                                        char ch3 = char.ToUpper(Console.ReadKey().KeyChar);
                                        switch (ch3)
                                        {
                                            case '1':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n============");
                                                    Console.WriteLine("Data Perawatan\n");
                                                    Console.WriteLine("============");
                                                    pr.detail3(conn);
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("PILIHAN MENU");
                                                            Console.WriteLine("============");
                                                            Console.WriteLine("1. BACK");
                                                            Console.Write("\nEnter your choice (1): ");
                                                            char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch (ch6)
                                                            {
                                                                case '1':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }

                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                        Console.WriteLine("\nInvalid option");
                                                                        Console.ResetColor();
                                                                    }
                                                                    break;
                                                            }
                                                            if (ch6 == '1')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch (Exception)
                                                        {
                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                "akses untuk melihat data atau Data yang anda masukkan salah");
                                                        }
                                                    }

                                                }
                                                break;
                                            case '2':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Anda memilih SEARCH.");

                                                    Console.WriteLine("Data Perawatan\n");
                                                    pr.list3(conn);
                                                    Console.WriteLine("Masukkan ID Perawatan yang Ingin Dilihat:");
                                                    string idPR = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.baca3(idPR, conn);
                                                    }
                                                    catch (Exception)
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki " +
                                                            "akses untuk melihat data atau Data yang anda masukkan salah");
                                                    }
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("PILIHAN MENU");
                                                            Console.WriteLine("============");
                                                            Console.WriteLine("1. BACK");
                                                            Console.Write("\nEnter your choice (1): ");
                                                            char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch (ch6)
                                                            {
                                                                case '1':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }

                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                        Console.WriteLine("\nInvalid option");
                                                                        Console.ResetColor();
                                                                    }
                                                                    break;
                                                            }
                                                            if (ch6 == '1')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch (Exception)
                                                        {
                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                "akses untuk melihat data atau Data yang anda masukkan salah");
                                                        }
                                                    }
                                                }
                                                break;
                                            case '3':
                                                {
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Anda memilih INPUT.");
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("LIST Keeper");
                                                            Console.WriteLine("============");
                                                            pr.list1(conn);
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("LIST Hewan");
                                                            Console.WriteLine("============");
                                                            pr.list(conn);
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("Input Data Perawatan\n");
                                                            Console.WriteLine("Masukkan ID Perawatan :");
                                                            string idPR = Console.ReadLine();
                                                            Console.WriteLine("Masukkan ID Keeper :");
                                                            string idK = Console.ReadLine();
                                                            Console.WriteLine("Masukkan ID Hewan :");
                                                            string idH = Console.ReadLine();
                                                            Console.WriteLine("Masukkan Tanggal Perawatan (Tahun-Bulan-Tanggal) :");
                                                            string tglPR = Console.ReadLine();
                                                            Console.WriteLine("Masukkan Kondisi Hewan (Sakit / Sehat) :");
                                                            string kdsPR = Console.ReadLine();
                                                            Console.WriteLine("Masukkan Detail Perawatan :");
                                                            string PR = Console.ReadLine();
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("PILIHAN MENU");
                                                            Console.WriteLine("============");
                                                            Console.WriteLine("1. SAVE");
                                                            Console.WriteLine("2. CANCEL");
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("3. BACK");
                                                            Console.ResetColor();
                                                            Console.Write("\nEnter your choice (1-3): ");
                                                            char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch (ch6)
                                                            {
                                                                case '1':
                                                                    {
                                                                        try
                                                                        {
                                                                            pr.insert3(idPR, idK, idH, tglPR, kdsPR, PR, conn);

                                                                        }
                                                                        catch (Exception)
                                                                        {
                                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                                "akses untuk menambah data atau Data yang anda masukkan salah (Tekan ENTER)");

                                                                        }
                                                                    }
                                                                    break;
                                                                case '2':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                case '3':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                        Console.WriteLine("\nInvalid option");
                                                                        Console.ResetColor();

                                                                    }
                                                                    break;
                                                            }
                                                            if (ch6 == '3')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                            if (ch6 == '1')
                                                            {
                                                                Console.ReadLine();
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch (Exception)
                                                        {
                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                "akses untuk menambah data atau Data yang anda masukkan salah");

                                                        }
                                                    }
                                                }
                                                break;
                                            case '4':
                                                {
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Update Data Perawatan\n");
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("LIST Perawatan");
                                                            Console.WriteLine("============");
                                                            pr.list3(conn);
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("LIST Keeper");
                                                            Console.WriteLine("============");
                                                            pr.list1(conn);
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("LIST Hewan");
                                                            Console.WriteLine("============");
                                                            pr.list(conn);
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("Masukkan ID Perawatan yang Ingin Diubah:");
                                                            string idPR = Console.ReadLine();
                                                            Console.WriteLine("Masukkan ID Keeper (biarkan kosong jika tidak ingin mengubah):");
                                                            string idK = Console.ReadLine();

                                                            Console.WriteLine("Masukkan ID Hewan (biarkan kosong jika tidak ingin mengubah):");
                                                            string idH = Console.ReadLine();

                                                            Console.WriteLine("Masukkan Tanggal Perawatan (biarkan kosong jika tidak ingin mengubah):");
                                                            string tglPR = Console.ReadLine();

                                                            Console.WriteLine("Masukkan Kondisi hewan (biarkan kosong jika tidak ingin mengubah):");
                                                            string kdsPR = Console.ReadLine();

                                                            Console.WriteLine("Masukkan Detail Perawatan (biarkan kosong jika tidak ingin mengubah):");
                                                            string PR = Console.ReadLine();
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("PILIHAN MENU");
                                                            Console.WriteLine("============");
                                                            Console.WriteLine("1. UPDATE");
                                                            Console.WriteLine("2. CANCEL");
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("3. BACK");
                                                            Console.ResetColor();
                                                            Console.Write("\nEnter your choice (1-3): ");
                                                            char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch (ch6)
                                                            {
                                                                case '1':
                                                                    {
                                                                        try
                                                                        {
                                                                            pr.update3(idPR, idK, idH, tglPR, kdsPR, PR, conn);
                                                                        }

                                                                        catch (Exception)
                                                                        {
                                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                                "akses untuk mengubah data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                        }
                                                                    }
                                                                    break;
                                                                case '2':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                case '3':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                        Console.WriteLine("\nInvalid option");
                                                                        Console.ResetColor();

                                                                    }
                                                                    break;
                                                            }
                                                            if (ch6 == '3')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                            if (ch6 == '1')
                                                            {
                                                                Console.ReadLine();
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch (Exception)
                                                        {
                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                "akses untuk mengubah data atau Data yang anda masukkan salah");

                                                        }
                                                    }
                                                }
                                                break;
                                            case '5':
                                                {
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Anda memilih DELETE.");
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("LIST Perawatan");
                                                            Console.WriteLine("============");
                                                            pr.list3(conn);
                                                            Console.WriteLine("Masukkan ID Perawatan yang Ingin Dihapus:");
                                                            string idPR = Console.ReadLine();
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("PILIHAN MENU");
                                                            Console.WriteLine("============");
                                                            Console.WriteLine("1. DELETE");
                                                            Console.WriteLine("2. CANCEL");
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("3. BACK");
                                                            Console.ResetColor();
                                                            Console.Write("\nEnter your choice (1-3): ");
                                                            char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch (ch6)
                                                            {
                                                                case '1':
                                                                    {
                                                                        try
                                                                        {
                                                                            pr.delete3(idPR, conn);
                                                                        }
                                                                        catch (Exception)
                                                                        {
                                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                                "akses untuk menghapus data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                            Console.ResetColor();
                                                                        }
                                                                    }
                                                                    break;
                                                                case '2':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                case '3':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                        Console.WriteLine("\nInvalid option");
                                                                        Console.ResetColor();

                                                                    }
                                                                    break;
                                                            }
                                                            if (ch6 == '3')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                            if (ch6 == '1')
                                                            {
                                                                Console.ReadLine();
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch (Exception)
                                                        {
                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                "akses untuk mengubah data atau Data yang anda masukkan salah");

                                                        }
                                                    }
                                                }
                                                break;
                                            case '6':
                                                {
                                                    Console.Clear();
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("\nInvalid option");
                                                    Console.ResetColor();
                                                }
                                                break;

                                        }
                                        if (ch3 == '6')
                                        {
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nCheck for the value entered.");
                                    }
                                }
                            }
                            break;
                        case '3':
                            {
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("\nMenu Pemeriksaan");
                                        Console.WriteLine("================");
                                        Console.WriteLine("ID Pemeriksaan :");
                                        Console.WriteLine("ID Hewan :");
                                        Console.WriteLine("ID Keeper :");
                                        Console.WriteLine("Tanggal Pemeriksaan:");
                                        Console.WriteLine("Diagnosisl :");
                                        Console.WriteLine("Pengobatan :");
                                        Console.WriteLine("Saran: ");
                                        Console.WriteLine("\n================");
                                        Console.WriteLine("LIST Pemeriksaan");
                                        Console.WriteLine("================");
                                        pr.list4(conn);
                                        Console.WriteLine("\n===========");
                                        Console.WriteLine("PILIH MENU: ");
                                        Console.WriteLine("==========");
                                        Console.WriteLine("1. READ");
                                        Console.WriteLine("2. SEARCH");
                                        Console.WriteLine("3. INPUT");
                                        Console.WriteLine("4. UPDATE");
                                        Console.WriteLine("5. DELETE");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("6. BACK");
                                        Console.ResetColor();
                                        Console.Write("\nEnter your choice (1-6): ");
                                        char ch4 = char.ToUpper(Console.ReadKey().KeyChar);
                                        switch (ch4)
                                        {
                                            case '1':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n============");
                                                    Console.WriteLine("Data Pemeriksaan\n");
                                                    Console.WriteLine("============");
                                                    pr.detail4(conn);
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("PILIHAN MENU");
                                                            Console.WriteLine("============");
                                                            Console.WriteLine("1. BACK");
                                                            Console.Write("\nEnter your choice (1): ");
                                                            char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch (ch6)
                                                            {
                                                                case '1':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }

                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                        Console.WriteLine("\nInvalid option");
                                                                        Console.ResetColor();
                                                                    }
                                                                    break;
                                                            }
                                                            if (ch6 == '1')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch (Exception)
                                                        {
                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                "akses untuk melihat data atau Data yang anda masukkan salah");

                                                        }
                                                    }
                                                }
                                                break;
                                            case '2':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Anda memilih SEARCH.");
                                                    Console.WriteLine("Data Pemeriksaan\n");
                                                    pr.list4(conn);
                                                    Console.WriteLine("Masukkan ID Pemeriksaan yang Ingin Dilihat:");
                                                    string idPM = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.baca4(idPM, conn);
                                                    }
                                                    catch (Exception)
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki " +
                                                            "akses untuk melihat data atau Data yang anda masukkan salah");

                                                    }
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("PILIHAN MENU");
                                                            Console.WriteLine("============");
                                                            Console.WriteLine("1. BACK");
                                                            Console.Write("\nEnter your choice (1): ");
                                                            char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch (ch6)
                                                            {
                                                                case '1':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }

                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                        Console.WriteLine("\nInvalid option");
                                                                        Console.ResetColor();
                                                                    }
                                                                    break;
                                                            }
                                                            if (ch6 == '1')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch (Exception)
                                                        {
                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                "akses untuk melihat data atau Data yang anda masukkan salah");

                                                        }
                                                    }
                                                }
                                                break;
                                            case '3':
                                                {
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Anda memilih INPUT.");
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("LIST Hewan");
                                                            Console.WriteLine("============");
                                                            pr.list(conn);
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("LIST Dokter Hewan");
                                                            Console.WriteLine("============");
                                                            pr.list2(conn);
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("Input Data Pemeriksaan\n");
                                                            Console.WriteLine("Masukkan ID Pemeriksaan :");
                                                            string idPM = Console.ReadLine();
                                                            Console.WriteLine("Masukkan ID Hewan :");
                                                            string idH = Console.ReadLine();
                                                            Console.WriteLine("Masukkan ID Dokter Hewan :");
                                                            string idDH = Console.ReadLine();
                                                            Console.WriteLine("Masukkan Tanggal Pemeriksaan (Tahun-Bulan-Tanggal) :");
                                                            string tglPM = Console.ReadLine();
                                                            Console.WriteLine("Masukkan Diagnosis :");
                                                            string dgPM = Console.ReadLine();
                                                            Console.WriteLine("Masukkan Pengobatan :");
                                                            string pbPM = Console.ReadLine();
                                                            Console.WriteLine("Masukkan Saran :");
                                                            string srPM = Console.ReadLine();
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("PILIHAN MENU");
                                                            Console.WriteLine("============");
                                                            Console.WriteLine("1. SAVE");
                                                            Console.WriteLine("2. CANCEL");
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("3. BACK");
                                                            Console.ResetColor();
                                                            Console.Write("\nEnter your choice (1-3): ");
                                                            char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch (ch6)
                                                            {
                                                                case '1':
                                                                    {
                                                                        try
                                                                        {
                                                                            pr.insert4(idPM, idH, idDH, tglPM, dgPM, pbPM, srPM, conn);
                                                                        }
                                                                        catch (Exception)
                                                                        {
                                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                                "akses untuk menambah data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                        }
                                                                    }
                                                                    break;
                                                                case '2':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                case '3':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                        Console.WriteLine("\nInvalid option");
                                                                        Console.ResetColor();

                                                                    }
                                                                    break;
                                                            }
                                                            if (ch6 == '3')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                            if (ch6 == '1')
                                                            {
                                                                Console.ReadLine();
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch (Exception)
                                                        {
                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                "akses untuk menambah data atau Data yang anda masukkan salah");

                                                        }
                                                    }
                                                }
                                                break;
                                            case '4':
                                                {
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Update Data Pemeriksaan\n");
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("LIST Pemeriksaan");
                                                            Console.WriteLine("============");
                                                            pr.list4(conn);
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("LIST Hewan");
                                                            Console.WriteLine("============");
                                                            pr.list(conn);
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("LIST Dokter Hewan");
                                                            Console.WriteLine("============");
                                                            pr.list2(conn);
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("Masukkan ID Pemeriksaan yang Ingin Diubah:");
                                                            string idPM = Console.ReadLine();

                                                            Console.WriteLine("Update Data Pemeriksaan\n");

                                                            Console.WriteLine("Masukkan ID Hewan (biarkan kosong jika tidak ingin mengubah):");
                                                            string idH = Console.ReadLine();

                                                            Console.WriteLine("Masukkan ID Dokter Hewan (biarkan kosong jika tidak ingin mengubah):");
                                                            string idDH = Console.ReadLine();

                                                            Console.WriteLine("Masukkan Tanggal Pemeriksaan (biarkan kosong jika tidak ingin mengubah):");
                                                            string tglPM = Console.ReadLine();

                                                            Console.WriteLine("Masukkan Diagnois (biarkan kosong jika tidak ingin mengubah):");
                                                            string dgPM = Console.ReadLine();

                                                            Console.WriteLine("Masukkan Pengobatan (biarkan kosong jika tidak ingin mengubah):");
                                                            string pbPM = Console.ReadLine();

                                                            Console.WriteLine("Masukkan Saran (biarkan kosong jika tidak ingin mengubah):");
                                                            string srPM = Console.ReadLine();
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("PILIHAN MENU");
                                                            Console.WriteLine("============");
                                                            Console.WriteLine("1. UPDATE");
                                                            Console.WriteLine("2. CANCEL");
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("3. BACK");
                                                            Console.ResetColor();
                                                            Console.Write("\nEnter your choice (1-3): ");
                                                            char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch (ch6)
                                                            {
                                                                case '1':
                                                                    {
                                                                        try
                                                                        {
                                                                            pr.update4(idPM, idH, idDH, tglPM, dgPM, pbPM, srPM, conn);
                                                                        }

                                                                        catch (Exception)
                                                                        {
                                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                                "akses untuk mengubah data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                        }
                                                                    }
                                                                    break;
                                                                case '2':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                case '3':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                        Console.WriteLine("\nInvalid option");
                                                                        Console.ResetColor();
                                                                    }
                                                                    break;
                                                            }
                                                            if (ch6 == '3')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                            if (ch6 == '1')
                                                            {
                                                                Console.ReadLine();
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch (Exception)
                                                        {
                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                "akses untuk menambah data atau Data yang anda masukkan salah");

                                                        }
                                                    }
                                                }
                                                break;
                                            case '5':
                                                {
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Anda memilih DELETE.");
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("LIST Pemeriksaan");
                                                            Console.WriteLine("============");
                                                            pr.list4(conn);
                                                            Console.WriteLine("Masukkan ID Pemeriksaan yang Ingin Dihapus:");
                                                            string idPM = Console.ReadLine();
                                                            Console.WriteLine("\n============");
                                                            Console.WriteLine("PILIHAN MENU");
                                                            Console.WriteLine("============");
                                                            Console.WriteLine("1. DELETE");
                                                            Console.WriteLine("2. CANCEL");
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("3. BACK");
                                                            Console.ResetColor();
                                                            Console.Write("\nEnter your choice (1-3): ");
                                                            char ch6 = char.ToUpper(Console.ReadKey().KeyChar);
                                                            switch (ch6)
                                                            {
                                                                case '1':
                                                                    {
                                                                        try
                                                                        {
                                                                            pr.delete4(idPM, conn);
                                                                        }
                                                                        catch (Exception)
                                                                        {
                                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                                "akses untuk menambah data atau Data yang anda masukkan salah (Tekan ENTER)");
                                                                        }
                                                                    }
                                                                    break;
                                                                case '2':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                case '3':
                                                                    {
                                                                        Console.Clear();
                                                                        break;
                                                                    }
                                                                default:
                                                                    {
                                                                        Console.Clear();
                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                        Console.WriteLine("\nInvalid option");
                                                                        Console.ResetColor();
                                                                    }
                                                                    break;
                                                            }
                                                            if (ch6 == '3')
                                                            {
                                                                Console.Clear();
                                                                break;
                                                            }
                                                            if (ch6 == '1')
                                                            {
                                                                Console.ReadLine();
                                                                Console.Clear();
                                                                break;
                                                            }
                                                        }
                                                        catch (Exception)
                                                        {
                                                            Console.WriteLine("\nAnda tidak memiliki " +
                                                                "akses untuk menambah data atau Data yang anda masukkan salah");

                                                        }
                                                    }
                                                }
                                                break;
                                            case '6':
                                                {
                                                    Console.Clear();
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("\nInvalid option");
                                                    Console.ResetColor();

                                                }
                                                break;

                                        }
                                        if (ch4 == '6')
                                        {
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nCheck for the value entered.");
                                    }
                                }
                            }
                            break;
                        case '4':
                            {
                                while (true)
                                {
                                    try
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nINI HALAMAN Cetak Laporan.");
                                        Console.WriteLine("\n===========");
                                        Console.WriteLine("Piliah Menu: ");
                                        Console.WriteLine("==========");
                                        Console.WriteLine("1. BACK");
                                        Console.Write("\nEnter your choice (1): ");
                                        char ch5 = char.ToUpper(Console.ReadKey().KeyChar);
                                        switch (ch5)
                                        {
                                            case '1':
                                                {
                                                    Console.Clear();
                                                    break;
                                                }
                                        }
                                        if (ch5 == '1')
                                        {
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nCheck for the value entered.");
                                    }
                                }
                            }
                            break;

                        case '5':
                            return;
                        default:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("!!!Pilihan Tidak Tersedia\n");
                                Console.ResetColor();
                            }
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\nCheck for the value entered.");
                }
            }

        }
        public void list(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_hewan, Nama_hewan from Hewan", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void detail(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_hewan,Nama_hewan,Jenis_hewan, Spesies_hewan, Jk_hewan, Tgl_lahir, Tgl_masuk, Umur, Berat from Hewan", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }

        public void baca(string idHw, SqlConnection con)
        {
            string str = "";
            str = "Select Id_hewan,Nama_hewan,Jenis_hewan, Spesies_hewan, Jk_hewan, Tgl_lahir, Tgl_masuk, Umur, Berat from Hewan where Id_hewan = @idh";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idh", idHw));
            cmd.ExecuteNonQuery();

            SqlDataReader r = cmd.ExecuteReader();

            Console.WriteLine("\n=================");
            Console.WriteLine("Data Detail Hewan");
            Console.WriteLine("=================\n");

            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {

                    Console.WriteLine(r.GetValue(i));
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nData berhasil ditemukan");
                Console.ResetColor();
                Console.WriteLine();
            }
            r.Close();
        }
        public void insert(string idHw, string nmHw, string jsHw, string spHw, string jkHw, string tglHw, string tglmHw,
            string brw, SqlConnection conn)
        {
            DateTime parsedDate;
            if (DateTime.TryParseExact(tglHw, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                tglHw = parsedDate.ToString("MM-dd-yyyy");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTanggal tidak valid. Pastikan formatnya adalah 'YYYY-MM-DD'.");
                Console.ResetColor();
                return;
            }

            DateTime parsedDate1;
            if (DateTime.TryParseExact(tglmHw, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate1))
            {
                tglmHw = parsedDate1.ToString("MM-dd-yyyy");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTanggal tidak valid. Pastikan formatnya adalah 'YYYY-MM-DD'.");
                Console.ResetColor();
                return;
            }

            string str = "";
            str = "insert into Hewan (Id_hewan,Nama_hewan,Jenis_hewan, Spesies_hewan, Jk_hewan, Tgl_lahir, Tgl_masuk, Berat) " +
                "values(@idh, @nmh, @jsh, @sph, @jkh, @tglh, @tglmh, @b)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idh", idHw));
            cmd.Parameters.Add(new SqlParameter("nmh", nmHw));
            cmd.Parameters.Add(new SqlParameter("jsh", jsHw));
            cmd.Parameters.Add(new SqlParameter("sph", spHw));
            cmd.Parameters.Add(new SqlParameter("jkh", jkHw));
            cmd.Parameters.Add(new SqlParameter("tglh", tglHw));
            cmd.Parameters.Add(new SqlParameter("tglmh", tglmHw));
            cmd.Parameters.Add(new SqlParameter("b", brw));
            cmd.ExecuteNonQuery();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*Data Berhasil Ditambahkan*");
            Console.ResetColor();
            Console.WriteLine("(Tekan ENTER)");
        }

        public void update(string idHw, string nmHw, string jsHw, string spHw, string jkHw, string tglHw, string tglmHw,
                   string brw, SqlConnection conn)
        {
            // Membuat pernyataan SQL untuk UPDATE
            string updateQuery = "UPDATE Hewan SET ";
            List<string> updates = new List<string>(); // Menyimpan kolom-nilai yang akan diupdate

            // Menambahkan kolom-nilai ke dalam list jika ada input yang diberikan
            if (!string.IsNullOrEmpty(nmHw))
            {
                updates.Add("Nama_hewan = @NewName");
            }
            if (!string.IsNullOrEmpty(jsHw))
            {
                updates.Add("Jenis_hewan = @NewJenis");
            }
            if (!string.IsNullOrEmpty(spHw))
            {
                updates.Add("Spesies_hewan = @NewSpesies");
            }
            if (!string.IsNullOrEmpty(jkHw))
            {
                updates.Add("Jk_hewan = @NewJenisKelamin");
            }
            if (!string.IsNullOrEmpty(tglHw))
            {
                updates.Add("Tgl_lahir = @NewTanggalLahir");
            }
            if (!string.IsNullOrEmpty(tglmHw))
            {
                updates.Add("Tgl_masuk = @NewTanggalMasuk");
            }
            if (!string.IsNullOrEmpty(brw))
            {
                updates.Add("Berat = @NewBerat");
            }

            // Menggabungkan semua kolom-nilai yang akan diupdate menjadi satu string
            updateQuery += string.Join(", ", updates);

            // Menambahkan kondisi WHERE
            updateQuery += " WHERE Id_hewan = @IdHewan";

            // Membuat SqlCommand dengan pernyataan SQL yang disiapkan
            SqlCommand command = new SqlCommand(updateQuery, conn);

            // Menambahkan parameter untuk setiap kolom-nilai yang akan diupdate

            if (!string.IsNullOrEmpty(nmHw))
            {
                command.Parameters.Add("@NewName", SqlDbType.NVarChar).Value = nmHw;
            }
            if (!string.IsNullOrEmpty(jsHw))
            {
                command.Parameters.Add("@NewJenis", SqlDbType.NVarChar).Value = jsHw;
            }
            if (!string.IsNullOrEmpty(spHw))
            {
                command.Parameters.Add("@NewSpesies", SqlDbType.NVarChar).Value = spHw;
            }
            if (!string.IsNullOrEmpty(jkHw))
            {
                command.Parameters.Add("@NewJenisKelamin", SqlDbType.NVarChar).Value = jkHw;
            }
            if (!string.IsNullOrEmpty(tglHw))
            {
                command.Parameters.Add("@NewTanggalLahir", SqlDbType.Date).Value = tglHw;
            }
            if (!string.IsNullOrEmpty(tglmHw))
            {
                command.Parameters.Add("@NewTanggalMasuk", SqlDbType.Date).Value = tglmHw;
            }
            if (!string.IsNullOrEmpty(brw))
            {
                command.Parameters.Add("@NewBerat", SqlDbType.NVarChar).Value = brw;
            }

            // Menambahkan parameter untuk kondisi WHERE
            command.Parameters.Add("@IdHewan", SqlDbType.NVarChar).Value = idHw;

            // Eksekusi perintah UPDATE
            int rowsAffected = command.ExecuteNonQuery();

            // Memeriksa apakah baris telah diubah
            if (rowsAffected > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n*Data Berhasil diubah*");
                Console.ResetColor();
                Console.WriteLine("(Tekan ENTER)");
            }
            else
            {
                Console.WriteLine("Tidak Ada Data Yang Berubah");
            }
        }

        public void delete(string idHw, SqlConnection con)
        {
            string str = "SELECT COUNT(*) FROM Hewan WHERE Id_hewan = @idh";
            SqlCommand countCmd = new SqlCommand(str, con);
            countCmd.Parameters.AddWithValue("@idh", idHw);

            int count = (int)countCmd.ExecuteScalar();

            if (count > 0)
            {
                str = "DELETE FROM Hewan WHERE Id_hewan = @idh";
                SqlCommand deleteCmd = new SqlCommand(str, con);
                deleteCmd.Parameters.AddWithValue("@idh", idHw);

                int rowsAffected = deleteCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nData Berhasil Dihapus (Tekan ENTER)");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nGagal menghapus data (Tekan ENTER)");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("\nID Hewan tidak ditemukan (Tekan ENTER)");
            }
        }

        public void list1(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_keeper,Nama_keeper from Keeper", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }

        public void detail1(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_keeper,Nama_keeper,Almt_keeper, Notlp_keeper from Keeper", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void baca1(string idk, SqlConnection con)
        {
            string str = "";
            str = "Select Id_keeper,Nama_keeper,Almt_keeper, Notlp_keeper from Keeper where Id_keeper = @idke";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idke", idk));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n=================");
            Console.WriteLine("Data Detail Keeper");
            Console.WriteLine("=================\n");
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void insert1(string idk, string nmk, string almtk, string notlpk, SqlConnection conn)
        {

            string str = "";
            str = "insert into Keeper (Id_keeper,Nama_keeper,Almt_keeper, Notlp_keeper) " +
                "values(@idke, @nmke, @almtke, @notlpke)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idke", idk));
            cmd.Parameters.Add(new SqlParameter("nmke", nmk));
            cmd.Parameters.Add(new SqlParameter("almtke", almtk));
            cmd.Parameters.Add(new SqlParameter("notlpke", notlpk));
            cmd.ExecuteNonQuery();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nData Berhasil Ditambahkan (Tekan ENTER)");
            Console.ResetColor();
        }

        public void update1(string idk, string nmk, string almtk, string notlpk, SqlConnection conn)
        {
            // Membuat pernyataan SQL untuk UPDATE
            string updateQuery = "UPDATE Keeper SET ";
            List<string> updates = new List<string>(); // Menyimpan kolom-nilai yang akan diupdate

            // Menambahkan kolom-nilai ke dalam list jika ada input yang diberikan
            if (!string.IsNullOrEmpty(nmk))
            {
                updates.Add("Nama_keeper = @NewName");
            }
            if (!string.IsNullOrEmpty(almtk))
            {
                updates.Add("Almt_keeper = @NewAlamat");
            }
            if (!string.IsNullOrEmpty(notlpk))
            {
                updates.Add("Notlp_keeper = @NewTlpKP");
            }

            // Menggabungkan semua kolom-nilai yang akan diupdate menjadi satu string
            updateQuery += string.Join(", ", updates);

            // Menambahkan kondisi WHERE
            updateQuery += " WHERE Id_keeper = @Idkeeper";

            // Membuat SqlCommand dengan pernyataan SQL yang disiapkan
            SqlCommand command = new SqlCommand(updateQuery, conn);

            // Menambahkan parameter untuk setiap kolom-nilai yang akan diupdate

            if (!string.IsNullOrEmpty(nmk))
            {
                command.Parameters.Add("@NewName", SqlDbType.NVarChar).Value = nmk;
            }
            if (!string.IsNullOrEmpty(almtk))
            {
                command.Parameters.Add("@NewAlamat", SqlDbType.NVarChar).Value = almtk;
            }
            if (!string.IsNullOrEmpty(notlpk))
            {
                command.Parameters.Add("@NewTlpKP", SqlDbType.NVarChar).Value = notlpk;
            }
            // Menambahkan parameter untuk kondisi WHERE
            command.Parameters.Add("@Idkeeper", SqlDbType.NVarChar).Value = idk;

            // Eksekusi perintah UPDATE
            int rowsAffected = command.ExecuteNonQuery();

            // Memeriksa apakah baris telah diubah
            if (rowsAffected > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*Data Berhasil diubah!*");
                Console.ResetColor();
                Console.WriteLine("(Tekan ENTER)");
            }
            else
            {
                Console.WriteLine("No rows updated. Data not found or no changes provided.");
            }
        }

        public void delete1(string idk, SqlConnection con)
        {
            string str = "SELECT COUNT(*) FROM Keeper WHERE Id_keeper = @idke";
            SqlCommand countCmd = new SqlCommand(str, con);
            countCmd.Parameters.AddWithValue("@idke", idk);

            int count = (int)countCmd.ExecuteScalar();

            if (count > 0)
            {
                str = "DELETE FROM Keeper WHERE Id_keeper = @idke";
                SqlCommand deleteCmd = new SqlCommand(str, con);
                deleteCmd.Parameters.AddWithValue("@idke", idk);

                int rowsAffected = deleteCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nData Berhasil Dihapus (Tekan ENTER)");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nGagal menghapus data (Tekan ENTER)");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("\nID Keeper tidak ditemukan (Tekan ENTER)");
            }
        }

        public void list2(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_Dhewan, Nama_Dhewan from Dokter_hewan", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }

        public void detail2(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_Dhewan,Nama_Dhewan,Almt_Dhewan, Notlp_Dhewan from Dokter_hewan", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void baca2(string iddh, SqlConnection con)
        {
            string str = "";
            str = "Select Id_Dhewan,Nama_Dhewan,Almt_Dhewan, Notlp_Dhewan from Dokter_hewan where Id_Dhewan= @iddhe";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("iddhe", iddh));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n=================");
            Console.WriteLine("Data Detail Dokter Hewan");
            Console.WriteLine("=================\n");
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void insert2(string iddh, string nmdh, string almtdh, string notlpdh, SqlConnection conn)
        {

            string str = "";
            str = "insert into Dokter_hewan (Id_Dhewan,Nama_Dhewan,Almt_Dhewan, Notlp_Dhewan) " +
                "values(@iddhe, @nmdhe, @almtdhe, @notlpdhe)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("iddhe", iddh));
            cmd.Parameters.Add(new SqlParameter("nmdhe", nmdh));
            cmd.Parameters.Add(new SqlParameter("almtdhe", almtdh));
            cmd.Parameters.Add(new SqlParameter("notlpdhe", notlpdh));
            cmd.ExecuteNonQuery();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nData Berhasil Ditambahkan (Tekan ENTER)");
            Console.ResetColor();
        }

        public void update2(string iddh, string nmdh, string almtdh, string notlpdh, SqlConnection conn)
        {
            // Membuat pernyataan SQL untuk UPDATE
            string updateQuery = "UPDATE Dokter_hewan SET ";
            List<string> updates = new List<string>(); // Menyimpan kolom-nilai yang akan diupdate

            // Menambahkan kolom-nilai ke dalam list jika ada input yang diberikan
            if (!string.IsNullOrEmpty(nmdh))
            {
                updates.Add("Nama_Dhewan = @NewName");
            }
            if (!string.IsNullOrEmpty(almtdh))
            {
                updates.Add("Almt_Dhewan = @NewAlamat");
            }
            if (!string.IsNullOrEmpty(notlpdh))
            {
                updates.Add("Notlp_Dhewan = @NewTlpDH");
            }

            // Menggabungkan semua kolom-nilai yang akan diupdate menjadi satu string
            updateQuery += string.Join(", ", updates);

            // Menambahkan kondisi WHERE
            updateQuery += " WHERE Id_Dhewan = @IdDhewan";

            // Membuat SqlCommand dengan pernyataan SQL yang disiapkan
            SqlCommand command = new SqlCommand(updateQuery, conn);

            // Menambahkan parameter untuk setiap kolom-nilai yang akan diupdate

            if (!string.IsNullOrEmpty(nmdh))
            {
                command.Parameters.Add("@NewName", SqlDbType.NVarChar).Value = nmdh;
            }
            if (!string.IsNullOrEmpty(almtdh))
            {
                command.Parameters.Add("@NewAlamat", SqlDbType.NVarChar).Value = almtdh;
            }
            if (!string.IsNullOrEmpty(notlpdh))
            {
                command.Parameters.Add("@NewTlpDH", SqlDbType.NVarChar).Value = notlpdh;
            }
            // Menambahkan parameter untuk kondisi WHERE
            command.Parameters.Add("@IdDhewan", SqlDbType.NVarChar).Value = iddh;

            // Eksekusi perintah UPDATE
            int rowsAffected = command.ExecuteNonQuery();

            // Memeriksa apakah baris telah diubah
            if (rowsAffected > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*Data Berhasil diubah!*");
                Console.ResetColor();
                Console.WriteLine("(Tekan ENTER)");
            }
            else
            {
                Console.WriteLine("No rows updated. Data not found or no changes provided.");
            }
        }

        public void delete2(string iddh, SqlConnection con)
        {
            string str = "SELECT COUNT(*) FROM Dokter_hewan WHERE Id_Dhewan = @iddhe";
            SqlCommand countCmd = new SqlCommand(str, con);
            countCmd.Parameters.AddWithValue("@iddhe", iddh);

            int count = (int)countCmd.ExecuteScalar();

            if (count > 0)
            {
                str = "DELETE FROM Dokter_hewan WHERE Id_Dhewan = @iddhe";
                SqlCommand deleteCmd = new SqlCommand(str, con);
                deleteCmd.Parameters.AddWithValue("@iddhe", iddh);

                int rowsAffected = deleteCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nData Berhasil Dihapus (Tekan ENTER)");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nGagal menghapus data (Tekan ENTER)");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("\nID Dokter hewan tidak ditemukan (Tekan ENTER)");
            }
        }

        public void list3(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_prwtn from Perawatan", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }

        public void detail3(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_prwtn, Id_keeper, Id_hewan, Tgl_prwtn, Kondisi_hewan, Detail_prwtn from Perawatan", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void baca3(string idpr, SqlConnection con)
        {
            string str = "";
            str = "Select Id_prwtn, Id_keeper, Id_hewan, Tgl_prwtn, Kondisi_hewan, Detail_prwtn from Perawatan where Id_prwtn= @idpre";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idpre", idpr));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n==================");
            Console.WriteLine("Data Detail Perawatan");
            Console.WriteLine("==================\n");
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void insert3(string idpr, string idk, string idHw, string tglpr, string Kdhw, string Dtpr, SqlConnection conn)
        {
            DateTime parsedDate;
            if (DateTime.TryParseExact(tglpr, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                tglpr = parsedDate.ToString("MM-dd-yyyy");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTanggal tidak valid. Pastikan formatnya adalah 'YYYY-MM-DD'.");
                Console.ResetColor();
                return;
            }

            string str = "";
            str = "insert into Perawatan (Id_prwtn, Id_keeper, Id_hewan, Tgl_prwtn, Kondisi_hewan, Detail_prwtn) " +
                "values(@idpre, @idke, @idh, @tglpre, @Kdhwe, @Dtpre)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idpre", idpr));
            cmd.Parameters.Add(new SqlParameter("idke", idk));
            cmd.Parameters.Add(new SqlParameter("idh", idHw));
            cmd.Parameters.Add(new SqlParameter("tglpre", tglpr));
            cmd.Parameters.Add(new SqlParameter("Kdhwe", Kdhw));
            cmd.Parameters.Add(new SqlParameter("Dtpre", Dtpr));
            cmd.ExecuteNonQuery();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nData Berhasil Ditambahkan (Tekan ENTER)");
            Console.ResetColor();
        }

        public void update3(string idpr, string idk, string idHw, string tglpr, string Kdhw, string Dtpr, SqlConnection conn)
        {
            // Membuat pernyataan SQL untuk UPDATE
            string updateQuery = "UPDATE Perawatan SET ";
            List<string> updates = new List<string>(); // Menyimpan kolom-nilai yang akan diupdate

            // Menambahkan kolom-nilai ke dalam list jika ada input yang diberikan
            if (!string.IsNullOrEmpty(idk))
            {
                updates.Add("Id_keeper = @NewidKe");
            }
            if (!string.IsNullOrEmpty(idHw))
            {
                updates.Add("Id_hewan = @NewIdHpr");
            }
            if (!string.IsNullOrEmpty(tglpr))
            {
                updates.Add("Tgl_Prwtn = @Newtglpr");
            }
            if (!string.IsNullOrEmpty(Kdhw))
            {
                updates.Add("Kondisi_hewan = @NewkdHpr");
            }
            if (!string.IsNullOrEmpty(Dtpr))
            {
                updates.Add("Detail_prwtn = @NewDpr");
            }

            // Menggabungkan semua kolom-nilai yang akan diupdate menjadi satu string
            updateQuery += string.Join(", ", updates);

            // Menambahkan kondisi WHERE
            updateQuery += " WHERE Id_prwtn = @Idprwtn";

            // Membuat SqlCommand dengan pernyataan SQL yang disiapkan
            SqlCommand command = new SqlCommand(updateQuery, conn);

            // Menambahkan parameter untuk setiap kolom-nilai yang akan diupdate

            if (!string.IsNullOrEmpty(idk))
            {
                command.Parameters.Add("@NewidKe", SqlDbType.NVarChar).Value = idk;
            }
            if (!string.IsNullOrEmpty(idHw))
            {
                command.Parameters.Add("@NewIdHpr", SqlDbType.NVarChar).Value = idHw;
            }
            if (!string.IsNullOrEmpty(tglpr))
            {
                command.Parameters.Add("@Newtglpr", SqlDbType.Date).Value = tglpr;
            }
            if (!string.IsNullOrEmpty(Kdhw))
            {
                command.Parameters.Add("@NewkdHpr", SqlDbType.NVarChar).Value = Kdhw;
            }
            if (!string.IsNullOrEmpty(Dtpr))
            {
                command.Parameters.Add("@NewDpr", SqlDbType.NVarChar).Value = Dtpr;
            }
            // Menambahkan parameter untuk kondisi WHERE
            command.Parameters.Add("@Idprwtn", SqlDbType.NVarChar).Value = idpr;

            // Eksekusi perintah UPDATE
            int rowsAffected = command.ExecuteNonQuery();

            // Memeriksa apakah baris telah diubah
            if (rowsAffected > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*Data Berhasil diubah!*");
                Console.ResetColor();
                Console.WriteLine("(Tekan ENTER)");
            }
            else
            {
                Console.WriteLine("No rows updated. Data not found or no changes provided.");
            }
        }
        public void delete3(string idpr, SqlConnection con)
        {
            string str = "SELECT COUNT(*) FROM Perawatan WHERE Id_prwtn = @idpre";
            SqlCommand countCmd = new SqlCommand(str, con);
            countCmd.Parameters.AddWithValue("@idpre", idpr);

            int count = (int)countCmd.ExecuteScalar();

            if (count > 0)
            {
                str = "DELETE FROM Perawatan WHERE Id_prwtn = @idpre";
                SqlCommand deleteCmd = new SqlCommand(str, con);
                deleteCmd.Parameters.AddWithValue("@idpre", idpr);

                int rowsAffected = deleteCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nData Berhasil Dihapus (Tekan ENTER)");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nGagal menghapus data (Tekan ENTER)");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("\nID Perawatan tidak ditemukan (Tekan ENTER)");
            }
        }



        public void list4(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_Periksa from Pemeriksaan", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }

        public void detail4(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select Id_Periksa, Id_hewan, Id_Dhewan, Tgl_Periksa, Diagnosis, Pengobatan, Saran from Pemeriksaan", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void baca4(string idpm, SqlConnection con)
        {
            string str = "";
            str = "Select Id_Periksa, Id_hewan, Id_Dhewan, Tgl_Periksa, Diagnosis, Pengobatan, Saran from Pemeriksaan where Id_Periksa= @idpme";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idpme", idpm));
            cmd.ExecuteNonQuery();
            Console.WriteLine("\n======================");
            Console.WriteLine("Data Detail Pemeriksaan");
            Console.WriteLine("=======================\n");
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void insert4(string idpm, string idHw, string idDh, string tglpm, string dgpm, string pbpm, string srpm, SqlConnection conn)
        {
            DateTime parsedDate;
            if (DateTime.TryParseExact(tglpm, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                tglpm = parsedDate.ToString("MM-dd-yyyy");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTanggal tidak valid. Pastikan formatnya adalah 'YYYY-MM-DD'.");
                Console.ResetColor();
                return;
            }

            string str = "";
            str = "insert into Pemeriksaan (Id_Periksa, Id_hewan, Id_Dhewan, Tgl_Periksa, Diagnosis, Pengobatan, Saran) " +
                "values(@idpme, @idh, @idke, @tglpme, @dgpme, @pbpme, @srpme)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idpme", idpm));
            cmd.Parameters.Add(new SqlParameter("idh", idHw));
            cmd.Parameters.Add(new SqlParameter("idke", idDh));
            cmd.Parameters.Add(new SqlParameter("tglpme", tglpm));
            cmd.Parameters.Add(new SqlParameter("dgpme", dgpm));
            cmd.Parameters.Add(new SqlParameter("pbpme", pbpm));
            cmd.Parameters.Add(new SqlParameter("srpme", srpm));
            cmd.ExecuteNonQuery();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nData Berhasil Ditambahkan (Tekan ENTER)");
            Console.ResetColor();
        }

        public void update4(string idpm, string idHw, string idDh, string tglpm, string dgpm, string pbpm, string srpm, SqlConnection conn)
        {
            // Membuat pernyataan SQL untuk UPDATE
            string updateQuery = "UPDATE Pemeriksaan SET ";
            List<string> updates = new List<string>(); // Menyimpan kolom-nilai yang akan diupdate

            // Menambahkan kolom-nilai ke dalam list jika ada input yang diberikan
            if (!string.IsNullOrEmpty(idHw))
            {
                updates.Add("Id_hewan = @NewidH");
            }
            if (!string.IsNullOrEmpty(idDh))
            {
                updates.Add("Id_Dhewan = @NewIdDH");
            }
            if (!string.IsNullOrEmpty(tglpm))
            {
                updates.Add("Tgl_Periksa = @Newtglpm");
            }
            if (!string.IsNullOrEmpty(dgpm))
            {
                updates.Add("Diagnosis = @NewDgs");
            }
            if (!string.IsNullOrEmpty(pbpm))
            {
                updates.Add("Pengobatan = @NewPeng");
            }
            if (!string.IsNullOrEmpty(srpm))
            {
                updates.Add("Saran = @NewSR");
            }

            // Menggabungkan semua kolom-nilai yang akan diupdate menjadi satu string
            updateQuery += string.Join(", ", updates);

            // Menambahkan kondisi WHERE
            updateQuery += " WHERE Id_periksa = @idpme";

            // Membuat SqlCommand dengan pernyataan SQL yang disiapkan
            SqlCommand command = new SqlCommand(updateQuery, conn);

            // Menambahkan parameter untuk setiap kolom-nilai yang akan diupdate

            if (!string.IsNullOrEmpty(idHw))
            {
                command.Parameters.Add("@NewidH", SqlDbType.NVarChar).Value = idHw;
            }

            if (!string.IsNullOrEmpty(idDh))
            {
                command.Parameters.Add("@NewIdDH", SqlDbType.NVarChar).Value = idDh;
            }
            if (!string.IsNullOrEmpty(tglpm))
            {
                command.Parameters.Add("@Newtglpm", SqlDbType.Date).Value = Convert.ToDateTime(tglpm);
            }
            if (!string.IsNullOrEmpty(dgpm))
            {
                command.Parameters.Add("@NewDgs", SqlDbType.NVarChar).Value = dgpm;
            }
            if (!string.IsNullOrEmpty(pbpm))
            {
                command.Parameters.Add("@NewPeng", SqlDbType.NVarChar).Value = pbpm;
            }
            if (!string.IsNullOrEmpty(srpm))
            {
                command.Parameters.Add("@NewSR", SqlDbType.NVarChar).Value = srpm;
            }
            // Menambahkan parameter untuk kondisi WHERE
            command.Parameters.Add("@Idpme", SqlDbType.NVarChar).Value = idpm;

            // Eksekusi perintah UPDATE
            int rowsAffected = command.ExecuteNonQuery();

            // Memeriksa apakah baris telah diubah
            if (rowsAffected > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*Data Berhasil diubah!*");
                Console.ResetColor();
                Console.WriteLine("(Tekan ENTER)");
            }
            else
            {
                Console.WriteLine("No rows updated. Data not found or no changes provided.");
            }
        }

        public void delete4(string idpm, SqlConnection con)
        {
            string str = "SELECT COUNT(*) FROM Pemeriksaan WHERE Id_Periksa = @idpme";
            SqlCommand countCmd = new SqlCommand(str, con);
            countCmd.Parameters.AddWithValue("@idpme", idpm);

            int count = (int)countCmd.ExecuteScalar();

            if (count > 0)
            {
                str = "DELETE FROM Pemeriksaan WHERE Id_Periksa = @idpme";
                SqlCommand deleteCmd = new SqlCommand(str, con);
                deleteCmd.Parameters.AddWithValue("@idpme", idpm);

                int rowsAffected = deleteCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nData Berhasil Dihapus (Tekan ENTER)");
                    Console.ResetColor();
                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nGagal menghapus data (Tekan ENTER)");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("\nID Pemeriksaan tidak ditemukan (Tekan ENTER)");
            }
        }

    }
}
