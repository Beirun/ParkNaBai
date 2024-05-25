insert into Users values('Admin','Admin','A','admin','admin')

select * from Users;

create Table Vehicles(
	TimeIn nvarchar(30),
	PlateNumber nvarchar(7) unique,
	VehicleType nvarchar(20),
	VehicleBrand nvarchar(20),
)

select * from vehicles