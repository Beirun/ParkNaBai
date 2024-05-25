create table Vehicles(
	VehicleID int primary key identity,
	PlateNumber nvarchar(7) Unique,
	VehicleType nvarchar(30),
	VehicleBrand nvarchar(30),
)

create table TransactionDetails(
	VehicleID int primary key references Vehicles(VehicleID),
	Active int,
	ParkingID int,

)
create table ParkingRecords(
	ParkingID int primary key identity,
	usrID int,
	VehicleID int,
	ParkInTime datetime,
	FloorSlot int,
	ColumnSlot int,
	RowSlot int,
	foreign key (usrID) references Users(usrID),
	foreign key (VehicleID) references TransactionDetails(VehicleID)
)
create table Payments(
	PaymentID int primary key identity,
	usrID int,
	VehicleID int,
	ParkInTime datetime,
	ParkOutTime datetime,
	Payment int,
	foreign key (VehicleID) references TransactionDetails(VehicleID),
	foreign key (usrID) references Users(usrID),
)
Select Sum(payment) as 'Total Income' from Payments
Select vehicles.PlateNumber, Vehicles.VehicleType, Vehicles.VehicleBrand, ParkingRecords.ParkInTime, Payments.ParkOutTime, Payments.Payment from Payments left join ParkingRecords on ParkingRecords.VehicleID = Payments.VehicleID left join TransactionDetails on ParkingRecords.VehicleID = TransactionDetails.VehicleID left Join Vehicles on Vehicles.VehicleID = TransactionDetails.VehicleID where (TransactionDetails.ParkingID != ParkingRecords.ParkingID and TransactionDetails.Active != 1) and (Payments.ParkOutTime >= 'May 1, 2024 00:00:00' and Payments.ParkOutTime <= 'May 31, 2024 00:00:00')
select UserLogs.usrLogDate as 'Log Date', Users.usrName as UserName, Users.usrFN as 'First Name', Users.usrLN as 'Last Name', Users.usrMI as 'Middle Initial' from users left join userlogs on users.usrid = userlogs.usrId where UserLogs.usrLogNo IS NOT NULL order by UserLogs.usrLogDate desc 
select ParkingRecords.RowSlot from ParkingRecords left join TransactionDetails on transactiondetails.parkingid = parkingrecords.parkingid left join Vehicles on TransactionDetails.vehicleid = vehicles.vehicleid  where Vehicles.PlateNumber = 'test123'
select  vehicles.vehicletype from ParkingRecords left join TransactionDetails on transactiondetails.parkingid = parkingrecords.parkingid left join Vehicles on TransactionDetails.vehicleid = vehicles.vehicleid  where ParkingRecords.FloorSlot = 1 and ParkingRecords.ColumnSlot = 2 and ParkingRecords.RowSlot = 1 and vehicles.vehicletype IS NOT NULL
select  vehicles.VehicleType from vehicles left join Transactiondetails on TransactionDetails.vehicleid = vehicles.vehicleid left join Parkingrecords on transactiondetails.parkingid = parkingrecords.parkingid where ParkingRecords.FloorSlot = 1 and ParkingRecords.ColumnSlot = 1 and ParkingRecords.RowSlot = 1
select * from vehicles
select * from TransactionDetails
select * from ParkingRecords
select * from Payments
Select vehicles.PlateNumber, Vehicles.VehicleType, Vehicles.VehicleBrand, ParkingRecords.ParkInTime, Payments.ParkOutTime, Payments.Payment from Payments left join ParkingRecords on ParkingRecords.VehicleID = Payments.VehicleID left join TransactionDetails on ParkingRecords.VehicleID = TransactionDetails.VehicleID left Join Vehicles on Vehicles.VehicleID = TransactionDetails.VehicleID where (TransactionDetails.ParkingID != ParkingRecords.ParkingID and TransactionDetails.Active != 1)and (Payments.Parkouttime >= '25 May 2024 00:00:00' and Payments.Parkouttime <= '25 May 2024 23:59:59')

select vehicles.platenumber from vehicles left join transactiondetails on transactiondetails.vehicleid = vehicles.vehicleid where transactiondetails.Active = 1 and vehicles.platenumber like 'a%'
select Payments.Payment from Payments where ParkOutTime >= '2024-05-01 00:00:00' and ParkOutTime <= '2024-05-18 02:45:00'
select ParkingRecords.ParkInTime, vehicles.platenumber, vehicles.vehicletype, vehicles.vehiclebrand, parkingrecords.floorslot, parkingrecords.columnslot, parkingrecords.rowslot from vehicles left join Transactiondetails on TransactionDetails.vehicleid = vehicles.vehicleid left join Parkingrecords on transactiondetails.parkingid = parkingrecords.parkingid ;
select ParkingRecords.ParkInTime, vehicles.platenumber, vehicles.vehicletype, vehicles.vehiclebrand from vehicles left join Transactiondetails on TransactionDetails.vehicleid = vehicles.vehicleid left join Parkingrecords on transactiondetails.parkingid = parkingrecords.parkingid where ParkingRecords.FloorSlot = 1 and ParkingRecords.ColumnSlot = 1 and ParkingRecords.RowSlot = 1;
select parkingrecords.floorslot from parkingrecords left join TransactionDetails on TransactionDetails.vehicleid = parkingrecords.vehicleid where parkingrecords.FloorSlot = 1 and TransactionDetails.Active = 1;
update parkingrecords set columnslot = 2, rowslot = 1 where ParkingID = 3
delete from vehicles where vehicleid = 2;
select vehicles.vehicletype from vehicles left join parkingrecords on vehicles.VehicleID = parkingrecords.VehicleID where parkingrecords.floorslot = 1 and parkingrecords.columnslot = 2 and parkingrecords.rowslot = 1;

select * from UserLogs
delete from UserLogs where UserLogs.usrLogDate < 'May 1, 2024 00:00:00'