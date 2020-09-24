using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administratori",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    IsSuperAdmin = table.Column<bool>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administratori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BannedKupci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumDo = table.Column<DateTime>(nullable: false),
                    Zauvijek = table.Column<bool>(nullable: false),
                    Razlog = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannedKupci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    RequestId = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    StackTrace = table.Column<string>(nullable: true),
                    RequestPath = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true),
                    ActionDescriptor = table.Column<string>(nullable: true),
                    IpAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperativniSustavi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Verzija = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperativniSustavi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Popusti",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumOd = table.Column<DateTime>(nullable: false),
                    DatumDo = table.Column<DateTime>(nullable: false),
                    PostotakPopusta = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Popusti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodjaci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodjaci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmsLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Broj = table.Column<string>(nullable: true),
                    Poruka = table.Column<string>(nullable: true),
                    Dodatnisadrzaj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zupanije",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zupanije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mobiteli",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    KratkiOpis = table.Column<string>(nullable: true),
                    Megapikseli = table.Column<float>(nullable: false),
                    Ram_Gb = table.Column<float>(nullable: false),
                    StanjeNaSkladistu = table.Column<int>(nullable: false),
                    EksternaMemorija = table.Column<bool>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    KapacitetBaterije = table.Column<int>(nullable: false),
                    Tezina = table.Column<int>(nullable: false),
                    Rezolucija = table.Column<string>(nullable: true),
                    DijagonalaEkrana = table.Column<float>(nullable: false),
                    Procesor = table.Column<string>(nullable: true),
                    Graficka = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ProizvodjacId = table.Column<int>(nullable: true),
                    OperativniSustavId = table.Column<int>(nullable: true),
                    PopustId = table.Column<int>(nullable: true),
                    ProdanoKomada = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobiteli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mobiteli_OperativniSustavi_OperativniSustavId",
                        column: x => x.OperativniSustavId,
                        principalTable: "OperativniSustavi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mobiteli_Popusti_PopustId",
                        column: x => x.PopustId,
                        principalTable: "Popusti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mobiteli_Proizvodjaci_ProizvodjacId",
                        column: x => x.ProizvodjacId,
                        principalTable: "Proizvodjaci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    PostanskiBroj = table.Column<int>(nullable: false),
                    ZupanijaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gradovi_Zupanije_ZupanijaId",
                        column: x => x.ZupanijaId,
                        principalTable: "Zupanije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Slike",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlikaFull = table.Column<byte[]>(nullable: true),
                    SlikaThumb = table.Column<byte[]>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    MobitelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slike", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slike_Mobiteli_MobitelId",
                        column: x => x.MobitelId,
                        principalTable: "Mobiteli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kupci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BrojPokusaja = table.Column<int>(nullable: false),
                    DatumPokusaja = table.Column<DateTime>(nullable: false),
                    BrojMobitela = table.Column<string>(nullable: true),
                    GradId = table.Column<int>(nullable: false),
                    BannedKupacId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kupci_BannedKupci_BannedKupacId",
                        column: x => x.BannedKupacId,
                        principalTable: "BannedKupci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kupci_Gradovi_GradId",
                        column: x => x.GradId,
                        principalTable: "Gradovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Komentari",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sadrzaj = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    MobitelId = table.Column<int>(nullable: false),
                    KupacId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Komentari_Kupci_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Komentari_Mobiteli_MobitelId",
                        column: x => x.MobitelId,
                        principalTable: "Mobiteli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Narudzbe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UkupnaCijena = table.Column<double>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Stanje = table.Column<int>(nullable: false),
                    KontaktTelefon = table.Column<string>(nullable: true),
                    KupacId = table.Column<int>(nullable: false),
                    Opcina = table.Column<string>(nullable: true),
                    Kanton = table.Column<string>(nullable: true),
                    PostanskiBroj = table.Column<string>(nullable: true),
                    Ulica = table.Column<string>(nullable: true),
                    ZaposlenikId = table.Column<int>(nullable: true),
                    GradId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzbe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Narudzbe_Gradovi_GradId",
                        column: x => x.GradId,
                        principalTable: "Gradovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Narudzbe_Kupci_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StavkeNarudzbe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<int>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    MobitelId = table.Column<int>(nullable: false),
                    NarudzbaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkeNarudzbe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StavkeNarudzbe_Mobiteli_MobitelId",
                        column: x => x.MobitelId,
                        principalTable: "Mobiteli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StavkeNarudzbe_Narudzbe_NarudzbaId",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzbe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Administratori",
                columns: new[] { "Id", "Email", "Ime", "IsSuperAdmin", "Prezime" },
                values: new object[] { 1, "admin@admin.com", "admin", true, "admin" });

            migrationBuilder.InsertData(
                table: "OperativniSustavi",
                columns: new[] { "Id", "Naziv", "Verzija" },
                values: new object[,]
                {
                    { 1, "Android", 11f },
                    { 2, "iOS", 13.4f }
                });

            migrationBuilder.InsertData(
                table: "Popusti",
                columns: new[] { "Id", "DatumDo", "DatumOd", "PostotakPopusta" },
                values: new object[] { 1, new DateTime(2020, 9, 23, 4, 19, 35, 116, DateTimeKind.Local).AddTicks(9684), new DateTime(2020, 9, 23, 4, 19, 35, 114, DateTimeKind.Local).AddTicks(4229), 0.1f });

            migrationBuilder.InsertData(
                table: "Proizvodjaci",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Samsung" },
                    { 2, "Apple" },
                    { 3, "Huawei" },
                    { 4, "Xiaomi" },
                    { 5, "Nokia" },
                    { 6, "Google" },
                    { 7, "CAT" },
                    { 8, "YEZZ" }
                });

            migrationBuilder.InsertData(
                table: "Zupanije",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Hercegovacko-Neretvanska" },
                    { 2, "Zapadno-Hercegovacka" }
                });

            migrationBuilder.InsertData(
                table: "Gradovi",
                columns: new[] { "Id", "Naziv", "PostanskiBroj", "ZupanijaId" },
                values: new object[,]
                {
                    { 2, "Siroki Brijeg", 88520, 2 },
                    { 1, "Citluk", 88260, 1 }
                });

            migrationBuilder.InsertData(
                table: "Mobiteli",
                columns: new[] { "Id", "Cijena", "DijagonalaEkrana", "EksternaMemorija", "Graficka", "IsDeleted", "KapacitetBaterije", "KratkiOpis", "Megapikseli", "Naziv", "OperativniSustavId", "Opis", "PopustId", "Procesor", "ProdanoKomada", "ProizvodjacId", "Ram_Gb", "Rezolucija", "StanjeNaSkladistu", "Tezina" },
                values: new object[,]
                {
                    { 12, 30.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "Classic c221", 1, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", null, "Xenon A5G", 0, 8, 8f, "FULL HD IPS", 10, 320 },
                    { 11, 250.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "B26", 1, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", null, "Xenon A5G", 0, 7, 8f, "FULL HD IPS", 10, 320 },
                    { 5, 1320.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "Pixel 4", 1, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", 1, "Xenon A5G", 0, 6, 8f, "FULL HD IPS", 10, 320 },
                    { 14, 430.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "210", 1, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", null, "Xenon A5G", 0, 5, 8f, "FULL HD IPS", 10, 320 },
                    { 13, 430.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "42", 1, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", null, "Xenon A5G", 0, 5, 8f, "FULL HD IPS", 10, 320 },
                    { 4, 440.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "Redmi Note 9", 1, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", 1, "Xenon A5G", 0, 4, 8f, "FULL HD IPS", 10, 320 },
                    { 10, 990.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "Mate 30 Pro", 1, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", null, "Xenon A5G", 0, 3, 8f, "FULL HD IPS", 10, 320 },
                    { 8, 880.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "iPhone 8", 2, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", null, "Xenon A5G", 0, 2, 8f, "FULL HD IPS", 10, 320 },
                    { 7, 1220.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "iPhone XR", 2, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", null, "Xenon A5G", 0, 2, 8f, "FULL HD IPS", 10, 320 },
                    { 6, 2350.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "iPhone 11 pro", 2, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", 1, "Xenon A5G", 0, 2, 8f, "FULL HD IPS", 10, 320 },
                    { 15, 670.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "A71", 1, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", 1, "Xenon A5G", 0, 1, 8f, "FULL HD IPS", 10, 320 },
                    { 3, 990.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "S10 Lite", 1, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", 1, "Xenon A5G", 0, 1, 8f, "FULL HD IPS", 10, 320 },
                    { 2, 1580.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "S20", 1, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", 1, "Xenon A5G", 0, 1, 8f, "FULL HD IPS", 10, 320 },
                    { 9, 390.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "Honor 9", 1, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", null, "Xenon A5G", 0, 3, 8f, "FULL HD IPS", 10, 320 },
                    { 1, 1210.0, 6.1f, true, "Ardent", false, 3200, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća", 12.3f, "S10", 1, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", 1, "Xenon A5G", 0, 1, 8f, "FULL HD IPS", 10, 320 }
                });

            migrationBuilder.InsertData(
                table: "Kupci",
                columns: new[] { "Id", "BannedKupacId", "BrojMobitela", "BrojPokusaja", "DatumPokusaja", "Email", "GradId", "Ime", "Prezime" },
                values: new object[] { 1, null, "063525555", 0, new DateTime(2020, 9, 23, 4, 19, 35, 118, DateTimeKind.Local).AddTicks(3930), "kupac@kupac.com", 1, "kupac", "kupic" });

            migrationBuilder.InsertData(
                table: "Komentari",
                columns: new[] { "Id", "Datum", "IsDeleted", "KupacId", "MobitelId", "Sadrzaj" },
                values: new object[] { 1, new DateTime(2020, 9, 23, 4, 19, 35, 117, DateTimeKind.Local).AddTicks(9652), false, 1, 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_ZupanijaId",
                table: "Gradovi",
                column: "ZupanijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_KupacId",
                table: "Komentari",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_MobitelId",
                table: "Komentari",
                column: "MobitelId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupci_BannedKupacId",
                table: "Kupci",
                column: "BannedKupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupci_GradId",
                table: "Kupci",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobiteli_OperativniSustavId",
                table: "Mobiteli",
                column: "OperativniSustavId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobiteli_PopustId",
                table: "Mobiteli",
                column: "PopustId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobiteli_ProizvodjacId",
                table: "Mobiteli",
                column: "ProizvodjacId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzbe_GradId",
                table: "Narudzbe",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzbe_KupacId",
                table: "Narudzbe",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Slike_MobitelId",
                table: "Slike",
                column: "MobitelId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeNarudzbe_MobitelId",
                table: "StavkeNarudzbe",
                column: "MobitelId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeNarudzbe_NarudzbaId",
                table: "StavkeNarudzbe",
                column: "NarudzbaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administratori");

            migrationBuilder.DropTable(
                name: "Komentari");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Slike");

            migrationBuilder.DropTable(
                name: "SmsLog");

            migrationBuilder.DropTable(
                name: "StavkeNarudzbe");

            migrationBuilder.DropTable(
                name: "Mobiteli");

            migrationBuilder.DropTable(
                name: "Narudzbe");

            migrationBuilder.DropTable(
                name: "OperativniSustavi");

            migrationBuilder.DropTable(
                name: "Popusti");

            migrationBuilder.DropTable(
                name: "Proizvodjaci");

            migrationBuilder.DropTable(
                name: "Kupci");

            migrationBuilder.DropTable(
                name: "BannedKupci");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Zupanije");
        }
    }
}
