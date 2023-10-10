using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LockedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "LockedBy", "Name", "Notes", "Phone" },
                values: new object[,]
                {
                    { new Guid("1a25b416-007e-4f7c-9cfb-afb2cebb9d1d"), "Cairo", "", "sdwdwed", "", "+2015168139999" },
                    { new Guid("32712d3c-3baa-43bf-89b2-d18acd665be4"), "Cairo", "", "reer", "", "+201515553845" },
                    { new Guid("3306a4e1-9144-44bf-af59-0f3571cfe5ae"), "Cairo", "", "Ahbcvbmed", "", "+2067867868384" },
                    { new Guid("54fa99c7-4cba-4665-9a9b-ce6e20b558d3"), "Cairo", "", "Ahmed", "", "+2015168138451" },
                    { new Guid("5ccb79d7-9714-464c-afa1-0943c891b25e"), "Cairo", "", "fdsf", "", "+201544443445" },
                    { new Guid("5e2e9bd5-f05b-4cb2-a3ef-12cc224ed133"), "Cairo", "", "regetrge", "", "+2018888888884" }
            
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
