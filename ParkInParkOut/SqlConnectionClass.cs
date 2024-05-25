using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;

namespace ParkInParkOut
{
    internal class SqlConnectionClass
    {
        SqlConnection conn;
        public SqlConnectionClass() {
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Data\\ParkingSystemDB.mdf;Integrated Security=True");
        }
        public void addVehicle(string plateNumber, string vehicleType, string vehicleBrand) {
            conn.Open();
            
            string commandString = "INSERT INTO Vehicles VALUES ('"  + plateNumber + "', '" + vehicleType + "', '" + vehicleBrand + "');";
            SqlCommand comm = new SqlCommand(commandString,conn);
            comm.ExecuteNonQuery();

            commandString = "INSERT INTO TransactionDetails VALUES("+ getVehicleID(plateNumber)+", 1, 0)"; 
            comm = new SqlCommand(commandString,conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public List<String>[] getPaymentSheet(String text, string start, string end)
        {
            List<String>[] list = new List<string>[6];
            for (int i = 0; i < 6; i++) list[i] = new List<string>();

            conn.Open();
            
                string commandString = "Select vehicles.PlateNumber, Vehicles.VehicleType, Vehicles.VehicleBrand, ParkingRecords.ParkInTime, Payments.ParkOutTime, Payments.Payment from Payments " +
                "left join ParkingRecords on ParkingRecords.VehicleID = Payments.VehicleID left join TransactionDetails on ParkingRecords.VehicleID = TransactionDetails.VehicleID left Join " +
                "Vehicles on Vehicles.VehicleID = TransactionDetails.VehicleID where (TransactionDetails.ParkingID != ParkingRecords.ParkingID and TransactionDetails.Active != 1)";
                if (text.Equals("Monthly")) commandString += "and (Payments.Parkouttime >= '" + DateTime.Now.ToString("MMMM") + " 1, " + DateTime.Now.Year.ToString() + " 00:00:00' and Payments.Parkouttime <= '" + DateTime.Now.ToString("MMMM") + " " + DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month).ToString() + ", " + DateTime.Now.Year.ToString() + " 23:59:59')";
                else if (text.Equals("Yearly")) commandString += "and (Payments.Parkouttime >= 'January 1, " + DateTime.Now.Year.ToString() + " 00:00:00' and Payments.Parkouttime <= 'December 31, " + DateTime.Now.Year + " 23:59:59')";
                else if (text.Equals("Weekly")) commandString += "and (Payments.Parkouttime >= '" + DateTime.Today.AddDays((int)DayOfWeek.Monday - (int)DateTime.Today.DayOfWeek).ToString() + "' and Payments.Parkouttime <= '" + DateTime.Today.AddDays((int)DayOfWeek.Sunday - (int)DateTime.Today.DayOfWeek + 7).ToShortDateString().ToString() + " 23:59:59')";
                else if (text.Equals("Daily")) commandString += "and (Payments.Parkouttime >= '" + DateTime.Now.ToShortDateString().ToString() + " 00:00:00' and Payments.Parkouttime <= '" + DateTime.Now.ToShortDateString().ToString() + " 23:59:59')";
                else if (text.Equals("Custom")) commandString += "and (Payments.Parkouttime >= '" + start+ "' and Payments.Parkouttime <= '" + end+ "')";
                commandString += " ORDER by Payments.Parkouttime desc";
            /*if (text != "") MessageBox.Show(commandString);
            Console.WriteLine(commandString);*/
            SqlCommand comm = new SqlCommand(commandString, conn);
                var reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    list[0].Add(reader.GetString(0));
                    list[1].Add(reader.GetString(1));
                    list[2].Add(reader.GetString(2));
                    list[3].Add(reader.GetDateTime(3).ToString());
                    list[4].Add(reader.GetDateTime(4).ToString());
                    list[5].Add(reader.GetInt32(5).ToString());
                }
                reader.Close();

            
            
            conn.Close();
            return list;
        }
        public List<String>[] getLogs()
        {
            List<String>[] list = new List<string>[5];
            for (int i = 0; i < 5; i++) list[i] = new List<string>();
            conn.Open();
            string commandString = "select UserLogs.usrLogDate as 'Log Date', Users.usrName as UserName, Users.usrFN as 'First Name', Users.usrLN as 'Last Name', Users.usrMI as " +
                "'Middle Initial' from users left join userlogs on users.usrid = userlogs.usrId where UserLogs.usrLogNo IS NOT NULL order by UserLogs.usrLogDate desc";
            SqlCommand comm = new SqlCommand(commandString,conn);
            var reader = comm.ExecuteReader();
            while (reader.Read())
            {
                list[0].Add(reader.GetDateTime(0).ToString());
                list[1].Add(reader.GetString(1));
                list[2].Add(reader.GetString(2));
                list[3].Add(reader.GetString(3));
                list[4].Add(reader.GetString(4));
            }
            reader.Close();
            conn.Close();
            return list;
        }
        public string getSlotVehicleType(int floor, int column, int row)
        {
            string vehicleType = "";
            conn.Open();
            try
            {
                string commandString = "select  vehicles.vehicleType from ParkingRecords left join TransactionDetails on transactiondetails.parkingid = " +
                "parkingrecords.parkingid left join Vehicles on TransactionDetails.vehicleid = vehicles.vehicleid " +
                "where parkingrecords.floorslot = " + floor + " and parkingrecords.columnslot = " + column + " and parkingrecords.rowslot = " + row + " and vehicles.vehicletype != 'NULL';";
                SqlCommand comm = new SqlCommand(commandString, conn);
                var reader = comm.ExecuteReader();
                while (reader.Read()) { vehicleType = reader.GetString(0); }
                reader.Close();
            }
            catch
            {
                
            }
            conn.Close();
            return vehicleType;

        }
        public int getSearchedVehicle(string column, string plateNumber)
        {
            conn.Open();
            int number = 0;
            string commandString = "select " + column + " from ParkingRecords left join TransactionDetails on transactiondetails.parkingid = parkingrecords.parkingid " +
                "left join Vehicles on TransactionDetails.vehicleid = vehicles.vehicleid  where Vehicles.PlateNumber = '"+plateNumber+"'";
            SqlCommand cmd = new SqlCommand(commandString,conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read()) { number = reader.GetInt32(0); }
            reader.Close();
            conn.Close();
            return number;
        }
        public void addParkingRecord(string userName, string plateNumber, int floor, int column, int row)
        {
            conn.Open();
            int vehicleID = getVehicleID(plateNumber);
            string commandString = "INSERT INTO ParkingRecords VALUES(" + getUserID(userName) + ", " + vehicleID + ", GETDATE(), " + floor + ", " + column + ", " + row + ")";
            SqlCommand comm = new SqlCommand(commandString,conn);
            comm.ExecuteNonQuery();

            commandString = "UPDATE TransactionDetails SET Active = 1, ParkingID = " + getParkingID(vehicleID) + " WHERE VehicleID = " + vehicleID + ";";
            comm = new SqlCommand(commandString, conn);
            comm.ExecuteNonQuery();
            conn.Close();

        }
        public bool isVehicleActive(string plateNumber)
        {
            conn.Open();
            int isActive = 0;
            string query = "select Active from TransactionDetails where VehicleID = '" + getVehicleID(plateNumber) + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read()) { isActive = reader.GetInt32(0);}
            reader.Close();
            conn.Close();
            if (isActive == 1) return true;
            else return false;
        }
        public string getSelectedVehicle(string itemList, int floor, int column, int row)
        {
            string item = "";
            conn.Open();
            string commanString = "select "+ itemList +" from vehicles left join Transactiondetails on TransactionDetails.vehicleid = " +
                "vehicles.vehicleid left join Parkingrecords on transactiondetails.parkingid = parkingrecords.parkingid where " +
                "ParkingRecords.FloorSlot = "+floor+" and ParkingRecords.ColumnSlot = "+column+" and ParkingRecords.RowSlot = "+row+";";
            SqlCommand comm  = new SqlCommand(commanString, conn);
            var reader = comm.ExecuteReader();
            while (reader.Read())
            {
                if (itemList.ToLower().Equals("parkingrecords.parkintime")) item = reader.GetDateTime(0).ToString();
                else item = reader.GetString(0);
            }
            reader.Close();
            conn.Close();
            return item;
        }

        public List<String> searchPlateNumber(String text)
        {
            List<String> list = new List<String>();
            conn.Open();
            string commandString = "select vehicles.platenumber from vehicles left join transactiondetails on " +
                "transactiondetails.vehicleid = vehicles.vehicleid where transactiondetails.Active = 1 and vehicles.platenumber like '"+text+"%'";
            SqlCommand cmd = new SqlCommand(commandString, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read()){ list.Add(reader.GetString(0)); }
            reader.Close();
            conn.Close();
            return list;
        }
        public void parkOutVehicle(string userName, string plateNumber, int payment)
        {
            conn.Open();
            int vehicleID = getVehicleID(plateNumber);
            string commandString = "INSERT INTO Payments VALUES(" + getUserID(userName) + ", " + vehicleID + ", '" + getParkInTime(vehicleID) + "', GETDATE(), " + payment + ");";
            SqlCommand comm = new SqlCommand(commandString, conn);
            comm.ExecuteNonQuery();

            commandString = "UPDATE TransactionDetails SET Active = 0, ParkingID = 0 WHERE VehicleID = " + vehicleID + ";";
            comm = new SqlCommand(commandString, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            
        }
        public int getParkedInFloor(int floorSlot)
        {
            conn.Open();
            int count = 0;
            string commandString = "select parkingrecords.floorslot from parkingrecords left join TransactionDetails on TransactionDetails.vehicleid = parkingrecords.vehicleid where parkingrecords.FloorSlot = " + floorSlot + " and TransactionDetails.Active = 1;\r\n";
            SqlCommand comm = new SqlCommand(commandString,conn);
            var reader  = comm.ExecuteReader();
            while (reader.Read()) { count++; }
            reader.Close();
            conn.Close();
            return count;
        }

        public DateTime getParkInTime(int vehicleID)
        {
            DateTime parkInTime = new DateTime();
            string commandString = "Select ParkInTime from ParkingRecords where ParkingID = " + getParkingID(vehicleID);
            SqlCommand comm = new SqlCommand(commandString, conn);
            var reader = comm.ExecuteReader();
            while (reader.Read()) { parkInTime = reader.GetDateTime(0); }
            reader.Close();
            return parkInTime;
        }

        public int getUserID(String userName)
        {
            int userID = 0;
            string commandString = "Select * from Users where usrname = '" + userName + "'";
            SqlCommand comm = new SqlCommand(commandString, conn);
            var reader = comm.ExecuteReader();
            while (reader.Read()) { userID = reader.GetInt32(0); }
            reader.Close();
            return userID;
        }
        public int getParkingID(int vehicleID)
        {
            int parkingID = 0;
            string commandString = "Select * from ParkingRecords where VehicleID = " + vehicleID + "";
            SqlCommand comm = new SqlCommand(commandString, conn);
            var reader = comm.ExecuteReader();
            while (reader.Read()) { parkingID = reader.GetInt32(0); }
            reader.Close();
            return parkingID;
        }
        public int getVehicleID(String plateNumber)
        {
            int vehicleID = 0;
            string commandString = "Select * from Vehicles where plateNumber = '" + plateNumber + "'";
            SqlCommand comm = new SqlCommand(commandString, conn);
            var reader = comm.ExecuteReader();
            while (reader.Read()) { vehicleID = reader.GetInt32(0); }
            reader.Close();
            return vehicleID;
        }
        public int getList()
        {
            int counter = 0;
            conn.Open();
            string commandString = "SELECT Active From TransactionDetails where active = 1";
            SqlCommand comm = new SqlCommand(commandString, conn);
            var reader = comm.ExecuteReader();
            while (reader.Read())
            {
                counter++;
            }
            reader.Close();
            conn.Close();
            return counter;
        }

        public void addUserLog(string userName) {
            try
            {
                conn.Open();
                int userID = getUserID(userName.Trim());
                string commandString = "INSERT INTO UserLogs VALUES (" + userID + ",'" + userName + "', GETDATE());";
                SqlCommand comm = new SqlCommand(commandString, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }catch(Exception) { conn.Close(); }
        }
        public bool isPasswordCorrect(string userName, string passwordEntered) 
        {
            string password = "‎ ";
            conn.Open();
            string commandString = "Select usrPW from Users where usrname = '" + userName + "'";
            SqlCommand comm = new SqlCommand(commandString, conn);
            var reader = comm.ExecuteReader();
            while (reader.Read()) { password = reader.GetString(0); }
            reader.Close();
            conn.Close();
            return password.Equals(passwordEntered);
        }
        public void addUser(string firstName, string lastName, string middleInitial, string userName, string password)
        {
            
             conn.Open();
             string query = "INSERT INTO Users VALUES ('" + firstName + "', '" + lastName + "', '" + middleInitial + "', '" + userName + "', '" + password + "')";

             SqlCommand sqlCommand = new SqlCommand(query, conn);

             sqlCommand.ExecuteNonQuery();
            conn.Close();
            
        }
        public bool isVehicleInDB(string plateNumberEntered, string vehicleTypeEntered, string vehicleBrandEntered)
        {
            try
            {
                string plateNumber = "";
                string vehicleType = "";
                string vehicleBrand = "";
                conn.Open();
                string query = "select PlateNumber, VehicleType, VehicleBrand from Vehicles where PlateNumber = '"+ plateNumberEntered+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read()) { plateNumber = reader.GetString(0); vehicleType = reader.GetString(1); vehicleBrand = reader.GetString(2); }
                reader.Close();
                conn.Close();
                if (plateNumber.Equals(plateNumberEntered) && vehicleType.Equals(vehicleTypeEntered) && vehicleBrand.Equals(vehicleBrandEntered) ) return true;
                else return false;
            }
            catch (Exception) { conn.Close(); return true; }
        }
        public bool isDuplicatePlateNumbber(string plateNumberEntered)
        {
            try
            {
                string plateNumber = "";
                conn.Open();
                string query = "select PlateNumber from Vehicles where PlateNumber = '" + plateNumberEntered + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read()) { plateNumber = reader.GetString(0); }
                reader.Close();
                conn.Close();
                if (plateNumber.Equals(plateNumberEntered)) return true;
                else return false;
            }
            catch (Exception) { conn.Close(); return true; }
        }
        public bool isUserNameTaken(string userName)
        {
            try {
                conn.Open();
                string query = "insert into users(usrName) values('"+ userName +"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                query = "delete from users where usrname = '" + userName + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return false;
            }catch(Exception) { conn.Close();  return true; }
        }
       
    }

    
}
