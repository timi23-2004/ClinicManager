
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace VegsoProjekt
{
    internal class Adatbazis
    {
        private static SQLiteConnection connection;
        public Adatbazis()
        {
            if (!File.Exists("Klinika.sqlite"))
            {
                SQLiteConnection.CreateFile("Klinika.sqlite");
                Console.WriteLine("ExampleDatabase created");
            }

            try
            {
                connection = new SQLiteConnection("Data Source=Klinika.sqlite;Version=3");
                connection.Open();
                //Console.WriteLine("Connection OK");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            string createSzemelyekTable = @"
                    CREATE TABLE IF NOT EXISTS Szemelyek (
                    Cnp TEXT PRIMARY KEY,
                    Nev TEXT NOT NULL,
                    Telefonszam TEXT NOT NULL,
                    Tipus TEXT NOT NULL 
                );";
            string createDoktorokTable = @"
                    CREATE TABLE IF NOT EXISTS Doktorok (
                    Cnp TEXT PRIMARY KEY,
                    Szakterulet TEXT NOT NULL,
                    FOREIGN KEY(Cnp) REFERENCES Szemelyek(Cnp)
                );";
            string createPaciensekTable = @"
                    CREATE TABLE IF NOT EXISTS Paciensek (
                    Cnp TEXT PRIMARY KEY,
                    EgeszsegugyiMult TEXT,
                    BiztositoSzam TEXT,
                    FOREIGN KEY(Cnp) REFERENCES Szemelyek(Cnp)
                );";
            string createSzakrendelesekTable = @"
                    
                    CREATE TABLE IF NOT EXISTS Szakrendelesek (
                    SzakNev TEXT NOT NULL PRIMARY KEY
                );";
            string createSzolgaltatasokTable = @"
                    CREATE TABLE IF NOT EXISTS Szolgaltatasok (
                    SzolgaltatasNev TEXT,
                    SzolgalatasAra INTEGER,
                    SzakNev TEXT,
                    FOREIGN KEY(SzakNev) REFERENCES Szakrendelesek(Szaknev)
                );";
            string createProgramalasokTable = @"
                    CREATE TABLE IF NOT EXISTS Programalasok (
                    ProgramalasId INTEGER PRIMARY KEY AUTOINCREMENT,
                    PaciensCnp TEXT,
                    SzolgaltatasNev TEXT,
                    DoktorCnp TEXT NOT NULL,
                    Idopont DATE NOT NULL,
                    FOREIGN KEY(PaciensCnp) REFERENCES Paciensek(PaciensCnp),
                    FOREIGN KEY(SzolgaltatasNev) REFERENCES Szolgaltatasok(SzolgaltatasNev),
                    FOREIGN KEY(DoktorCnp) REFERENCES Doktorok(Cnp),
                    UNIQUE (Idopont, SzolgaltatasNev, DoktorCnp)
                );";
            using (var command = new SQLiteCommand(createSzemelyekTable, connection))
            {
                command.ExecuteNonQuery();
            }
            using (var command = new SQLiteCommand(createDoktorokTable, connection))
            {
                command.ExecuteNonQuery();
            }
            using (var command = new SQLiteCommand(createPaciensekTable, connection))
            {
                command.ExecuteNonQuery();
            }
            using (var command = new SQLiteCommand(createSzakrendelesekTable, connection))
            {
                command.ExecuteNonQuery();
            }
            using (var command = new SQLiteCommand(createSzolgaltatasokTable, connection))
            {
                command.ExecuteNonQuery();
            }
            using (var command = new SQLiteCommand(createProgramalasokTable, connection))
            {
                command.ExecuteNonQuery();
            }

        }
        public void InsertSzakrendele(string szaknev)
        {
            string query = "INSERT INTO Szakrendelesek(SzakNev) VALUES (@szaknev)";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@szaknev", szaknev);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"Szakrendeles hozzaadva: {szaknev}");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba a beszuras soran: " + ex.Message);
                }
            }

        }
        public void InsertSzolgaltatas(string szolgaltatasnev, int szolgalatasar, string szaknev)
        {
            string query = "INSERT INTO Szolgaltatasok(SzolgaltatasNev,SzolgalatasAra,SzakNev) VALUES (@szolgaltatasnev,@szolgalatasar,@szaknev)";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@szolgaltatasnev", szolgaltatasnev);
                command.Parameters.AddWithValue("@szolgalatasar", szolgalatasar);
                command.Parameters.AddWithValue("@szaknev", szaknev);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"Szolgaltatas hozzaadva: {szolgaltatasnev},{szolgalatasar},{szaknev}");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba a beszuras soran: " + ex.Message);
                }
            }

        }
        public void InsertSzemely(string cnp, string nev, string telSzam, string tipus)
        {
            string query = "INSERT INTO Szemelyek (Cnp, Nev, Telefonszam, Tipus) VALUES (@cnp, @nev, @telSzam, @tipus)";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@cnp", cnp);
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@telSzam", telSzam);
                command.Parameters.AddWithValue("@tipus", tipus);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"Szemely hozzaadva: {cnp},{nev},{telSzam},{tipus}");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba a beszuras soran: " + ex.Message);
                }
            }

        }
        public void InsertDoktor(string cnp, string szakterulet)
        {
            string query = "INSERT INTO Doktorok (Cnp, Szakterulet) VALUES (@cnp,@szakterulet)";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@cnp", cnp);
                command.Parameters.AddWithValue("@szakterulet", szakterulet);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"Doktor hozzaadva: {cnp},{szakterulet}");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba a beszuras soran: " + ex.Message);
                }
            }

        }
        public void InsertPaciens(string cnp, string egeszsegugyiMult, string biztositoSzam)
        {
            string query = "INSERT INTO Paciensek (Cnp, EgeszsegugyiMult, BiztositoSzam) VALUES (@cnp, @egeszsegugyiMult, @biztositoSzam)";

            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@cnp", cnp);
                command.Parameters.AddWithValue("@egeszsegugyiMult", egeszsegugyiMult);
                command.Parameters.AddWithValue("@biztositoSzam", biztositoSzam);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"Páciens hozzáadva: CNP = {cnp}, Egészségügyi múlt = {egeszsegugyiMult}, Biztosító szám = {biztositoSzam}");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba a paciens beszúrás során: " + ex.Message);
                }
            }
        }

        public void InsertProgramalas(
                    string paciensCnp,
                    string szolgaltatasNev,
                    string doktorCnp,
                    DateTime iopont)
        {
            string query = "INSERT INTO Programalasok (PaciensCnp ,SzolgaltatasNev , DoktorCnp ,Idopont) VALUES (@paciensCnp ,@szolgaltatasNev , @doktorCnp , @iopont)";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@paciensCnp", paciensCnp);
                command.Parameters.AddWithValue("@szolgaltatasNev", szolgaltatasNev);
                command.Parameters.AddWithValue("@doktorCnp", doktorCnp);
                command.Parameters.AddWithValue("@iopont", iopont);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"Programalas hozzaadva: {paciensCnp},{doktorCnp},{iopont}");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba a beszuras soran: " + ex.Message);
                }
            }

        }
        public List<ProgramalaClass> GetProgramalasok()
        {
            List<ProgramalaClass> programalasok = new List<ProgramalaClass>();

            string query = @" SELECT ProgramalasId, PaciensCnp, SzolgaltatasNev, DoktorCnp, Idopont FROM Programalasok";

            using (var command = new SQLiteCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        ProgramalaClass programalas = new ProgramalaClass
                        {
                            ProgramalasId = reader.GetInt32(0),
                            PaciensCnp = reader.GetString(1),
                            SzolgaltatasNev = reader.GetString(2),
                            DoktorCnp = reader.GetString(3),
                            Idopont = reader.GetDateTime(4)
                        };

                        programalasok.Add(programalas);
                    }
                }
            }

            return programalasok;
        }

        public List<string> GetSzakrendelesek()
        {
            List<string> szakrendelesek = new List<string>();

            string query = "SELECT SzakNev FROM Szakrendelesek";
            using (var command = new SQLiteCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    szakrendelesek.Add(reader.GetString(0));
                }
            }
            return szakrendelesek;
        }
        public async Task<List<string>> GetSzakrendelesekAsync()
        {
            List<string> szakrendelesek = new List<string>();

            string query = "SELECT SzakNev FROM Szakrendelesek";

            try
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            szakrendelesek.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error: {ex.Message}");
            }

            return szakrendelesek;
        }


        public List<Szolgaltatas> GetSzolgaltatasok(string szakNev)
        {
            List<Szolgaltatas> szolgaltatasok = new List<Szolgaltatas>();

            string query = "SELECT SzolgaltatasNev, SzolgalatasAra FROM Szolgaltatasok WHERE SzakNev = @szakNev";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@szakNev", szakNev);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Szolgaltatas szolgaltatas = new Szolgaltatas
                        {
                            szolgalatasNev = reader.GetString(0),
                            szolgalatasAra = reader.GetInt32(1)
                        };
                        szolgaltatasok.Add(szolgaltatas);
                    }
                }
            }
            return szolgaltatasok;
        }

        public List<string> GetDoktorneve(string szakNev)
        {
            List<string> doktorok = new List<string>();

            string query = "SELECT Szemelyek.Nev " +
                           "FROM Doktorok " +
                           "JOIN Szemelyek ON Doktorok.Cnp = Szemelyek.Cnp " +
                           "WHERE Doktorok.Szakterulet = @szakNev ";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@szakNev", szakNev);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        doktorok.Add(reader.GetString(0));
                    }
                }
            }

            return doktorok;

        }
        public string GetDoktornevecnp(string nev)
        {
            string doktorok = null;

            string query = @"
                        SELECT Doktorok.Cnp 
                        FROM Doktorok 
                        JOIN Szemelyek ON Doktorok.Cnp = Szemelyek.Cnp 
                        WHERE Szemelyek.Nev = @nev";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nev", nev);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        doktorok = reader.GetString(0);
                    }
                }
            }

            return doktorok;

        }
        public List<Doktor> GetDoktorok()
        {
            List<Doktor> doktorok = new List<Doktor>();

            string query = @"
                SELECT Szemelyek.Nev, Doktorok.Cnp, Doktorok.Szakterulet 
                FROM Doktorok 
                JOIN Szemelyek ON Doktorok.Cnp = Szemelyek.Cnp";

            using (var command = new SQLiteCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var doktor = new Doktor
                        {
                            Nev = reader.GetString(0),
                            Cnp = reader.GetString(1),
                            Szakterulet = reader.GetString(2)
                        };
                        doktorok.Add(doktor);
                    }
                }
            }

            return doktorok;
        }

        public List<Paciens> GetPaciensek()
        {
            List<Paciens> paciensek = new List<Paciens>();

            string query = @"
                    SELECT Szemelyek.Nev, Paciensek.Cnp, Paciensek.EgeszsegugyiMult, Paciensek.BiztositoSzam, Szemelyek.Telefonszam
                    FROM Paciensek 
                    JOIN Szemelyek ON Paciensek.Cnp = Szemelyek.Cnp";

            using (var command = new SQLiteCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var paciens = new Paciens
                        {
                            Nev = reader.GetString(0),
                            Cnp = reader.GetString(1),
                            EgeszsegugyiMult = reader.GetString(2),
                            BiztositoSzam = reader.GetString(3),
                            TelefonSzam = reader.GetString(4),
                        };
                        paciensek.Add(paciens);
                    }
                }
            }

            return paciensek;
        }

        public void DeleteProgramalast(string paciensCnp, string szolgaltatasNev, string doktorCnp, DateTime idopont)
        {

            {

                string query = @"
                              DELETE FROM Programalasok 
                              WHERE PaciensCnp = @PaciensCnp 
                                AND SzolgaltatasNev = @SzolgaltatasNev 
                                AND DoktorCnp = @DoktorCnp 
                                AND Idopont = @Idopont";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@paciensCnp", paciensCnp);
                    command.Parameters.AddWithValue("@szolgaltatasNev", szolgaltatasNev);
                    command.Parameters.AddWithValue("@doktorCnp", doktorCnp);
                    command.Parameters.AddWithValue("@iopont", idopont);
                    
                }
            }
        }
    }
}