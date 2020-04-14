namespace DioklecijanovaLegija.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMembersTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Ivan Kalinić','24-Sep-98 12:00:00 AM','095 863 3706',2,2)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Duje Vidović','25-Oct-96 12:00:00 AM','095 575 5816',2,1)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Mislav Matić','05-Mar-98 12:00:00 AM','095 575 9469',0,4)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Filip Šego','08-Mar-99 12:00:00 AM','095 396 0939',2,2)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Josip Vučica','29-Dec-96 12:00:00 AM','098 194 4562',2,1)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Frane Maleš','05-Apr-97 12:00:00 AM','098 930 3023',2,1)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Ante Režić','23-Mar-99 12:00:00 AM','098 9279 948',2,1)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Domagoj Jelić','14-Jun-96 12:00:00 AM','091 150 0838',2,1)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Bruno Farac','10-Apr-98 12:00:00 AM','097 7935 824',2,1)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Zvonimir Šegvić','05-Mar-97 12:00:00 AM','091 575 6244',2,1)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Danijel Vlah','01-Jan-00 12:00:00 AM','095 890 3055',2,5)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Atino Franić','20-Nov-99 12:00:00 AM','095 520 7579',2,2)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Marko Štetner','07-Jun-95 12:00:00 AM','099 340 6304',2,2)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Duje Mikelić','01-May-91 12:00:00 AM','095 820 6136',2,1)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Frane Peslać','15-Aug-98 12:00:00 AM','099 434 7373',2,1)");
            Sql("INSERT INTO Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Blaž Čajo','01-Jan-00 12:00:00 AM','nepoznato',2,1)");

        }

        public override void Down()
        {
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Blaž Čajo','01-Jan-00 12:00:00 AM','nepoznato',2,1)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Frane Peslać','15-Aug-98 12:00:00 AM','099 434 7373',2,1)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Duje Mikelić','01-May-91 12:00:00 AM','095 820 6136',2,1)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Marko Štetner','07-Jun-95 12:00:00 AM','099 340 6304',2,2)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Atino Franić','20-Nov-99 12:00:00 AM','095 520 7579',2,2)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Danijel Vlah','01-Jan-00 12:00:00 AM','095 890 3055',2,5)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Zvonimir Šegvić','05-Mar-97 12:00:00 AM','091 575 6244',2,1)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Bruno Farac','10-Apr-98 12:00:00 AM','097 7935 824',2,1)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Domagoj Jelić','14-Jun-96 12:00:00 AM','091 150 0838',2,1)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Ante Režić','23-Mar-99 12:00:00 AM','098 9279 948',2,1)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Frane Maleš','05-Apr-97 12:00:00 AM','098 930 3023',2,1)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Josip Vučica','29-Dec-96 12:00:00 AM','098 194 4562',2,1)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Filip Šego','08-Mar-99 12:00:00 AM','095 396 0939',2,2)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Mislav Matić','05-Mar-98 12:00:00 AM','095 575 9469',0,4)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Duje Vidović','25-Oct-96 12:00:00 AM','095 575 5816',2,1)");
            Sql("DELETE FROM Members(Name,BirthDate,PhoneNumber,NumberOfAllowedShifts,SoldierTypeId) VALUES('Ivan Kalinić','24-Sep-98 12:00:00 AM','095 863 3706',2,2)");
        }
    }
}
