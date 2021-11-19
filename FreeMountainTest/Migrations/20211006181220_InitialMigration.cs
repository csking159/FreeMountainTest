using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeMountainTest.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CAMPAIGNS",
                columns: table => new
                {
                    MFID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MFID_DESCRIPTION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PROMOTION = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    CLIENT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CHANNEL = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    SEED_LIST = table.Column<int>(type: "int", nullable: true),
                    DTS_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    EXTRACT_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRINT_VENDOR = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    WAVE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EXTRACT_SQL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AML_UNIVERSE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    AV_REQUIRED = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    ALLOW_RENTAL_LIST = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    RECURRANCE = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    ALERT_NUM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    REVISION_NUM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EXTRACT_VIEW = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HTML_LOCATION = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AMAZON_CODE = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    EMAIL_SUBJECT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ISCONSUMER = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    ISINFLUENCER = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    WORK_FLOW = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CUSTOMER_SEARCH = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    SEQ_NUM = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAIGNS", x => x.MFID);
                });

            migrationBuilder.CreateTable(
                name: "RESPONSES",
                columns: table => new
                {
                    RESPONSE_CODE = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    RESPONSE_DESCRIPTION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RESPONSE_TYPE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PROMOTION = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CHANNEL = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    START_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    END_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    LAST_UPDATE_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RESPONSES", x => x.RESPONSE_CODE);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAMPAIGNS");

            migrationBuilder.DropTable(
                name: "RESPONSES");
        }
    }
}
