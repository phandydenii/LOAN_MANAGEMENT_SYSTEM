using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LOAN_MANAGEMENT_API.Migrations
{
    public partial class alltable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_borrow",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    contact_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_borrow", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_loan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    references_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type_id = table.Column<int>(type: "int", nullable: false),
                    borrow_id = table.Column<int>(type: "int", nullable: false),
                    purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    amount = table.Column<double>(type: "float", nullable: false),
                    plan_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    date_release = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_create = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_loan", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_loan_plan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    month = table.Column<int>(type: "int", nullable: false),
                    interest = table.Column<float>(type: "real", nullable: false),
                    penalty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_loan_plan", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_loan_schedule",
                columns: table => new
                {
                    loan_schedule_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    loan_id = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_loan_schedule", x => x.loan_schedule_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_loan_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_loan_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_payment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    loan_id = table.Column<int>(type: "int", nullable: false),
                    payee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pay_amount = table.Column<float>(type: "real", nullable: false),
                    penalty = table.Column<float>(type: "real", nullable: false),
                    overdue = table.Column<int>(type: "int", nullable: false),
                    date_create = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_payment", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_tbl",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateadd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    expiredate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_tbl", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_borrow");

            migrationBuilder.DropTable(
                name: "tbl_loan");

            migrationBuilder.DropTable(
                name: "tbl_loan_plan");

            migrationBuilder.DropTable(
                name: "tbl_loan_schedule");

            migrationBuilder.DropTable(
                name: "tbl_loan_type");

            migrationBuilder.DropTable(
                name: "tbl_payment");

            migrationBuilder.DropTable(
                name: "user_tbl");
        }
    }
}
