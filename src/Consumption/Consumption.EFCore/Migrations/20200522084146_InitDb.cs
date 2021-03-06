﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Consumption.EFCore.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthName = table.Column<string>(type: "TEXT", nullable: true),
                    AuthValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Basics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeCode = table.Column<string>(type: "TEXT", nullable: true),
                    DataCode = table.Column<string>(type: "TEXT", nullable: true),
                    NativeName = table.Column<string>(type: "TEXT", nullable: true),
                    EnglishName = table.Column<string>(type: "TEXT", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreateBy = table.Column<string>(type: "TEXT", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdateBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BasicTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeCode = table.Column<string>(type: "TEXT", nullable: true),
                    TypeName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Remark = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    ConsumptionType = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateDate = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupFuncs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupCode = table.Column<string>(type: "TEXT", nullable: true),
                    MenuCode = table.Column<string>(type: "TEXT", nullable: true),
                    Auth = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupFuncs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupCode = table.Column<string>(type: "TEXT", nullable: true),
                    GroupName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupCode = table.Column<string>(type: "TEXT", nullable: true),
                    Account = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MenuCode = table.Column<string>(type: "TEXT", nullable: true),
                    MenuName = table.Column<string>(type: "TEXT", nullable: true),
                    MenuCaption = table.Column<string>(type: "TEXT", nullable: true),
                    MenuNameSpace = table.Column<string>(type: "TEXT", nullable: true),
                    MenuAuth = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyBillDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    No = table.Column<string>(type: "TEXT", nullable: true),
                    ConsumptionType = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyBillDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyBills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    No = table.Column<string>(type: "TEXT", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyBills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    PlanDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PlanStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Content = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Account = table.Column<string>(type: "TEXT", nullable: true),
                    ExpectedOut = table.Column<decimal>(type: "TEXT", nullable: false),
                    ExpectedIn = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserConfigs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Account = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    Tel = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    LastLoginTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastLogouTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsLocked = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FlagAdmin = table.Column<int>(type: "INTEGER", nullable: false),
                    FlagOnline = table.Column<string>(type: "TEXT", nullable: true),
                    LoginCounter = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthItems");

            migrationBuilder.DropTable(
                name: "Basics");

            migrationBuilder.DropTable(
                name: "BasicTypes");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "GroupFuncs");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "GroupUsers");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "MonthlyBillDetails");

            migrationBuilder.DropTable(
                name: "MonthlyBills");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "UserConfigs");

            migrationBuilder.DropTable(
                name: "UserLogs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
