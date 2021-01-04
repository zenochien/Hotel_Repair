using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_APIs.Migrations
{
    public partial class hotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookingStatuses",
                columns: table => new
                {
                    BookingStatusID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingStatuses", x => x.BookingStatusID);
                });

            migrationBuilder.CreateTable(
                name: "guests",
                columns: table => new
                {
                    GuestID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCOde = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CellularNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eMailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guests", x => x.GuestID);
                });

            migrationBuilder.CreateTable(
                name: "hotels",
                columns: table => new
                {
                    HotelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Motto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCOde = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainPhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TooIIFreeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyeMailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebsiteAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Main = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotels", x => x.HotelID);
                });

            migrationBuilder.CreateTable(
                name: "paymentTypes",
                columns: table => new
                {
                    PaymentTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentTypes", x => x.PaymentTypeID);
                });

            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    PositionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions", x => x.PositionID);
                });

            migrationBuilder.CreateTable(
                name: "rateTypes",
                columns: table => new
                {
                    RateTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RateType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rateTypes", x => x.RateTypeID);
                });

            migrationBuilder.CreateTable(
                name: "reservationAgents",
                columns: table => new
                {
                    ReservationAgentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCOde = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CellularNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eMailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservationAgents", x => x.ReservationAgentID);
                });

            migrationBuilder.CreateTable(
                name: "roomStatuses",
                columns: table => new
                {
                    RoomStatusID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomsStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomStatuses", x => x.RoomStatusID);
                });

            migrationBuilder.CreateTable(
                name: "roomTypes",
                columns: table => new
                {
                    RoomTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomTypes", x => x.RoomTypeID);
                });

            migrationBuilder.CreateTable(
                name: "paymentStatuses",
                columns: table => new
                {
                    PaymentStatusID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentTypesPaymentTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentStatuses", x => x.PaymentStatusID);
                    table.ForeignKey(
                        name: "FK_paymentStatuses_paymentTypes_PaymentTypesPaymentTypeID",
                        column: x => x.PaymentTypesPaymentTypeID,
                        principalTable: "paymentTypes",
                        principalColumn: "PaymentTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "staffs",
                columns: table => new
                {
                    StaffID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PositionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCOde = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CellularNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eMailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffs", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_staffs_positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "positions",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    BookingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuestID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservationAgentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoomCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingStatusID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_bookings_bookingStatuses_BookingStatusID",
                        column: x => x.BookingStatusID,
                        principalTable: "bookingStatuses",
                        principalColumn: "BookingStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookings_guests_GuestID",
                        column: x => x.GuestID,
                        principalTable: "guests",
                        principalColumn: "GuestID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookings_hotels_HotelID",
                        column: x => x.HotelID,
                        principalTable: "hotels",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookings_reservationAgents_ReservationAgentID",
                        column: x => x.ReservationAgentID,
                        principalTable: "reservationAgents",
                        principalColumn: "ReservationAgentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    RoomsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomStatusID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.RoomsID);
                    table.ForeignKey(
                        name: "FK_rooms_hotels_HotelID",
                        column: x => x.HotelID,
                        principalTable: "hotels",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rooms_roomStatuses_RoomStatusID",
                        column: x => x.RoomStatusID,
                        principalTable: "roomStatuses",
                        principalColumn: "RoomStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rooms_roomTypes_RoomTypeID",
                        column: x => x.RoomTypeID,
                        principalTable: "roomTypes",
                        principalColumn: "RoomTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    PaymentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Payment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentStatsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentStatusID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_payments_paymentStatuses_PaymentStatusID",
                        column: x => x.PaymentStatusID,
                        principalTable: "paymentStatuses",
                        principalColumn: "PaymentStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payments_paymentTypes_PaymentTypeID",
                        column: x => x.PaymentTypeID,
                        principalTable: "paymentTypes",
                        principalColumn: "PaymentTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_payments_rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "rooms",
                        principalColumn: "RoomsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rates",
                columns: table => new
                {
                    RateID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RateTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionsPositionID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoomsID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rates", x => x.RateID);
                    table.ForeignKey(
                        name: "FK_rates_positions_PositionsPositionID",
                        column: x => x.PositionsPositionID,
                        principalTable: "positions",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_rates_rateTypes_RateTypeID",
                        column: x => x.RateTypeID,
                        principalTable: "rateTypes",
                        principalColumn: "RateTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rates_rooms_RoomsID",
                        column: x => x.RoomsID,
                        principalTable: "rooms",
                        principalColumn: "RoomsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "roomsBookeds",
                columns: table => new
                {
                    RoomBookedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomsBookeds", x => x.RoomBookedID);
                    table.ForeignKey(
                        name: "FK_roomsBookeds_bookings_BookingID",
                        column: x => x.BookingID,
                        principalTable: "bookings",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_roomsBookeds_rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "rooms",
                        principalColumn: "RoomsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "staffRooms",
                columns: table => new
                {
                    StaffRoomID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffRooms", x => x.StaffRoomID);
                    table.ForeignKey(
                        name: "FK_staffRooms_rates_StaffID",
                        column: x => x.StaffID,
                        principalTable: "rates",
                        principalColumn: "RateID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_staffRooms_rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "rooms",
                        principalColumn: "RoomsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_staffRooms_staffs_StaffID1",
                        column: x => x.StaffID1,
                        principalTable: "staffs",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "bookingStatuses",
                columns: new[] { "BookingStatusID", "Active", "Description", "SortOrder", "Status" },
                values: new object[,]
                {
                    { new Guid("a802c953-279a-42d6-85c2-5af08f518e10"), "Có", "Đẹp và sạch sẽ", "1", "Tốt" },
                    { new Guid("406c4555-70a5-4d0e-b9c5-24b505fcf9a5"), "Có", "Đẹp và sạch sẽ", "1", "Tốt" }
                });

            migrationBuilder.InsertData(
                table: "bookings",
                columns: new[] { "BookingID", "BookingStatusID", "DateFrom", "DateTo", "GuestID", "HotelID", "ReservationAgentID", "RoomCount" },
                values: new object[,]
                {
                    { new Guid("50469b72-0bf1-4bfa-845c-0d7e9260840b"), new Guid("1aa26beb-3cef-4499-97f8-ff964ef2876b"), new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01fc5db6-74c6-4155-806e-0a2f3b8c845e"), new Guid("5e514666-c609-424d-b7e8-99d09f159e4f"), new Guid("c39f757e-df5f-4541-8039-8dd8295d9bb9"), "03" },
                    { new Guid("d3958cbb-2024-46f2-84c1-f520e2e8554e"), new Guid("a91889bc-b326-4d50-97f6-6f005a53599a"), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9dc4e06-31fc-4255-ab68-216d498afaf2"), new Guid("d798875a-ce7e-4930-858e-370b04bbc291"), new Guid("56775fa2-368a-4f0c-baf4-4777766d96ea"), "23" }
                });

            migrationBuilder.InsertData(
                table: "guests",
                columns: new[] { "GuestID", "Address", "Address2", "CellularNumber", "City", "Country", "FirstName", "Gender", "HomePhoneNumber", "LastName", "State", "ZipCOde", "eMailAddress" },
                values: new object[,]
                {
                    { new Guid("0aa0f433-1464-4b19-bcbc-a2094f745cdd"), "20 Thông Nhất", "43 Nguyễn Thị Sáu", "0123456789", "Hồ Chí Minh", "VietNam", "Anh", "Vietnam", "0123456789", "Nguyễn Văn", "?", "007", "nguyenvananh@mail.com" },
                    { new Guid("19df4cd2-dc82-4e00-8228-d6f0a9f2c40f"), "21 Thông Nhất", "33 Nguyễn Minh Khai", "0123456789", "Hồ Chí Minh", "VietNam", "Mạnh", "Vietnam", "0123456789", "Nguyễn Văn", "?", "007", "nguyenvanmanh@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "hotels",
                columns: new[] { "HotelID", "Address", "Address2", "City", "CompanyeMailAddress", "FaxNumber", "HotelCode", "ImagePath", "Main", "MainPhoneNumber", "Motto", "Name", "State", "TooIIFreeNumber", "WebsiteAddress", "ZipCOde" },
                values: new object[,]
                {
                    { new Guid("d04d0ea3-57ed-4921-b2da-23bc36c94e4d"), "43 Nguyễn Thị Sáu", "", "Hồ Chí Minh", "nguyenvananh@mail.com", "0123456789", "1234", "AAAAA", "AAAA", "123456789", "SSS", "Spa Biển Đep5", "?", "0123456789", "Vietnam", "007" },
                    { new Guid("189775b6-0c79-4815-bce7-aaf56c70278f"), "43 Nguyễn Thị Sáu", "", "Hồ Chí Minh", "nguyenvananh@mail.com", "0123456789", "1234", "AAAAA", "AAAA", "123456789", "SSS", "Spa Biển Đep5", "?", "0123456789", "Vietnam", "007" }
                });

            migrationBuilder.InsertData(
                table: "paymentStatuses",
                columns: new[] { "PaymentStatusID", "Active", "Description", "PaymentTypesPaymentTypeID", "SortOrder", "Status" },
                values: new object[,]
                {
                    { new Guid("287164df-848f-433e-8cec-ad9c49b27ef1"), "123123", "12334", null, "2312", "123" },
                    { new Guid("cceeb6f5-11a2-4ee4-895f-54b1734cbeec"), "123123", "12334", null, "2312", "123" }
                });

            migrationBuilder.InsertData(
                table: "paymentTypes",
                columns: new[] { "PaymentTypeID", "Active", "PaymentType", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("907d7997-2383-480f-a104-322297b94543"), "có", "vip", "123" },
                    { new Guid("c9aba73e-61cf-47d6-b0ee-30bd6a7d90bc"), "có", "vip", "123" }
                });

            migrationBuilder.InsertData(
                table: "payments",
                columns: new[] { "PaymentID", "Date", "Payment", "PaymentStatsID", "PaymentStatusID", "PaymentTypeID", "RoomID" },
                values: new object[,]
                {
                    { new Guid("19bfdec8-f11b-4674-a4c7-11054b276239"), new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "3025", new Guid("4becb208-5027-4d1d-a226-b29525953276"), null, new Guid("35669263-bc8c-4ce9-aa16-d23c9882a7b5"), new Guid("b1e87f4c-14d0-4e05-804b-d4f2ebc9c5b8") },
                    { new Guid("535343c0-3902-4ed9-8d5c-be5c53963ede"), new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "2450", new Guid("5d929da4-49b8-4eda-a25a-242be600f577"), null, new Guid("d8e77541-01e6-44f6-869b-b0d1e1647e0b"), new Guid("d6e6e0e9-841f-414b-8772-b31f3b4e2a40") }
                });

            migrationBuilder.InsertData(
                table: "positions",
                columns: new[] { "PositionID", "Active", "Position", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("abd6096b-950b-4169-abce-1153f482a268"), "có", "asdf", "123" },
                    { new Guid("9a7ed028-a9d3-4b46-9a9d-deb0d86d932e"), "có", "asdf", "123" }
                });

            migrationBuilder.InsertData(
                table: "rateTypes",
                columns: new[] { "RateTypeID", "Active", "Description", "RateType", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("69ddab80-3711-4369-b027-8838ca0d156e"), "có", "aaa", "thường", "aaa" },
                    { new Guid("73d7fcf1-7d8e-4441-99eb-4fd86b05b336"), "có", "sss", "vip", "123" }
                });

            migrationBuilder.InsertData(
                table: "rates",
                columns: new[] { "RateID", "FromDate", "PositionsPositionID", "Rate", "RateTypeID", "RoomID", "RoomsID", "ToDate" },
                values: new object[,]
                {
                    { new Guid("035dacbf-678b-41a7-8654-ba874dea741f"), new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, new Guid("fe26d890-b8fb-4267-9dea-0d8796ab92dc"), new Guid("4cba4895-d255-4e66-8841-cde129f4fbe6"), null, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a37ca5a5-1a8c-4213-91f3-1122e129433b"), new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, new Guid("65193574-ba90-4074-8c07-5c7fc8f764ab"), new Guid("468aed02-e2c8-481b-9a2b-3ce88ae77d02"), null, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "reservationAgents",
                columns: new[] { "ReservationAgentID", "Address", "Address2", "CellularNumber", "City", "Country", "FirstName", "Gender", "HomePhoneNumber", "LastName", "State", "ZipCOde", "eMailAddress" },
                values: new object[,]
                {
                    { new Guid("53594b80-d2a1-4558-8a18-087e24aa8f76"), "32 Thị Yến", "21 Nguyễn Thị Sáu", "0123456789", "Hồ Chí Minh", "VietNam", "Hùng", "Vietnam", "0123456789", "Phạm Mạnh", "?", "333", "phammanhhung@mail.com" },
                    { new Guid("620ec1f2-0a2c-4501-923f-566b1071a061"), "21 Thông Mông", "33 Nguyễn Minh Mạnh", "0123456789", "Hồ Chí Minh", "VietNam", "Thìa", "Vietnam", "0123456789", "Hương Văn", "?", "443", "huongvanthia@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "roomStatuses",
                columns: new[] { "RoomStatusID", "Active", "Description", "RoomsStatus", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("cc5d77a1-0490-4047-9b0a-09266191da10"), "có", "sss", "vip", "123" },
                    { new Guid("86795895-cf34-4da4-bc18-3a8094c915c1"), "có", "sss", "vip", "123" }
                });

            migrationBuilder.InsertData(
                table: "roomTypes",
                columns: new[] { "RoomTypeID", "Active", "Description", "RoomType", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("c7896cb8-61f2-433e-a6ca-e4d3ffe825f0"), "có", "sss", "vip", "123" },
                    { new Guid("9b8c0682-54be-4a3f-8e63-bdd2c6930f8b"), "có", "aaa", "thường", "aaa" }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomsID", "Desription", "Floor", "HotelID", "RoomNumber", "RoomStatusID", "RoomTypeID" },
                values: new object[,]
                {
                    { new Guid("ded7c2a2-805a-44b5-85e2-9bebd89ad69c"), "abc", "5", new Guid("51fb0ce3-52c3-4d9d-867a-6bc6d3ac70d8"), "123", new Guid("193d51af-aca6-44a0-809d-354312cb4b67"), new Guid("79d7ee38-37f9-4a04-85d7-692f192ae610") },
                    { new Guid("e6b539ca-d015-4288-ba3f-d8621909162c"), "abc", "3", new Guid("16549811-0f78-4d4a-bb9c-fadc9a176ad1"), "123", new Guid("08b223c0-565c-4303-8162-8ecb52cb3c32"), new Guid("ca954313-d7bd-4bab-803f-afcc8c793449") }
                });

            migrationBuilder.InsertData(
                table: "roomsBookeds",
                columns: new[] { "RoomBookedID", "BookingID", "Rate", "RoomID" },
                values: new object[,]
                {
                    { new Guid("3226aeeb-4bea-48c6-9855-b70fe0a0b968"), new Guid("20ab6aff-2db5-472e-8040-b564296470a6"), 10, new Guid("a988b2c8-a774-4e75-bfd5-829c798cd0c7") },
                    { new Guid("c2df2b97-1d91-42f5-ba41-780172d4af41"), new Guid("a66614c8-b07e-4cd0-8dd5-210c31ded9c2"), 5, new Guid("18e9fb62-43b8-4823-bf38-65c28a4d9b75") }
                });

            migrationBuilder.InsertData(
                table: "staffRooms",
                columns: new[] { "StaffRoomID", "RoomID", "StaffID", "StaffID1" },
                values: new object[,]
                {
                    { new Guid("36e75b49-68b3-4302-9ce4-0fbdf0b982cc"), new Guid("40ec36b6-cf1c-4b17-b865-5c37c191d6f9"), new Guid("5906f1af-b3b2-48dc-9898-e1247c1f1de1"), null },
                    { new Guid("45b8c233-89b5-41e3-8727-40b35577b14c"), new Guid("8c18e180-317c-4b7c-b87c-b156d61f77cc"), new Guid("6aad94c2-656b-4338-9476-5feb0bb031a0"), null }
                });

            migrationBuilder.InsertData(
                table: "staffs",
                columns: new[] { "StaffID", "Address", "Address2", "CellularNumber", "City", "Country", "FirstName", "Gender", "HomePhoneNumber", "LastName", "PositionID", "State", "ZipCOde", "eMailAddress" },
                values: new object[,]
                {
                    { new Guid("66481b59-63cc-4e36-a398-432fe5bb3d2a"), "20 Thông Nhất", "43 Nguyễn Thị Sáu", "0123456789", "Hồ Chí Minh", "VietNam", "Anh", "Vietnam", "0123456789", "Nguyễn Văn", new Guid("00000000-0000-0000-0000-000000000000"), "?", "007", "nguyenvananh@mail.com" },
                    { new Guid("94ac807e-8252-4a80-913a-c943b0208864"), "20 Thông Nhất", "43 Nguyễn Thị Sáu", "0123456789", "Hồ Chí Minh", "VietNam", "Anh", "Vietnam", "0123456789", "Nguyễn Văn", new Guid("00000000-0000-0000-0000-000000000000"), "?", "007", "nguyenvananh@mail.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookings_BookingStatusID",
                table: "bookings",
                column: "BookingStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_GuestID",
                table: "bookings",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_HotelID",
                table: "bookings",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_ReservationAgentID",
                table: "bookings",
                column: "ReservationAgentID");

            migrationBuilder.CreateIndex(
                name: "IX_payments_PaymentStatusID",
                table: "payments",
                column: "PaymentStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_payments_PaymentTypeID",
                table: "payments",
                column: "PaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_payments_RoomID",
                table: "payments",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_paymentStatuses_PaymentTypesPaymentTypeID",
                table: "paymentStatuses",
                column: "PaymentTypesPaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_rates_PositionsPositionID",
                table: "rates",
                column: "PositionsPositionID");

            migrationBuilder.CreateIndex(
                name: "IX_rates_RateTypeID",
                table: "rates",
                column: "RateTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_rates_RoomsID",
                table: "rates",
                column: "RoomsID");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_HotelID",
                table: "rooms",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_RoomStatusID",
                table: "rooms",
                column: "RoomStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_RoomTypeID",
                table: "rooms",
                column: "RoomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_roomsBookeds_BookingID",
                table: "roomsBookeds",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_roomsBookeds_RoomID",
                table: "roomsBookeds",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_staffRooms_RoomID",
                table: "staffRooms",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_staffRooms_StaffID",
                table: "staffRooms",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_staffRooms_StaffID1",
                table: "staffRooms",
                column: "StaffID1");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_PositionID",
                table: "staffs",
                column: "PositionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "roomsBookeds");

            migrationBuilder.DropTable(
                name: "staffRooms");

            migrationBuilder.DropTable(
                name: "paymentStatuses");

            migrationBuilder.DropTable(
                name: "bookings");

            migrationBuilder.DropTable(
                name: "rates");

            migrationBuilder.DropTable(
                name: "staffs");

            migrationBuilder.DropTable(
                name: "paymentTypes");

            migrationBuilder.DropTable(
                name: "bookingStatuses");

            migrationBuilder.DropTable(
                name: "guests");

            migrationBuilder.DropTable(
                name: "reservationAgents");

            migrationBuilder.DropTable(
                name: "rateTypes");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropTable(
                name: "hotels");

            migrationBuilder.DropTable(
                name: "roomStatuses");

            migrationBuilder.DropTable(
                name: "roomTypes");
        }
    }
}
