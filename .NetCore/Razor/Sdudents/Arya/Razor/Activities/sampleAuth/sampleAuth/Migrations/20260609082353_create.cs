using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

<<<<<<<< HEAD:.NetCore/Razor/Sdudents/Arya/Razor/Activities/sampleAuth/sampleAuth/Migrations/20260609082353_create.cs
namespace sampleAuth.Migrations
{
    /// <inheritdoc />
    public partial class create : Migration
========
namespace BlazorAuthenticationSample.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
>>>>>>>> 72d82c91693b9e35788e1e94f879a16858273e20:.NetCore/Blazor/Students/Sanjay/Blazor_Authentication_Sample/Blazor_Authentication_Sample/Migrations/20260623061500_Initial.cs
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
<<<<<<<< HEAD:.NetCore/Razor/Sdudents/Arya/Razor/Activities/sampleAuth/sampleAuth/Migrations/20260609082353_create.cs
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
========
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
>>>>>>>> 72d82c91693b9e35788e1e94f879a16858273e20:.NetCore/Blazor/Students/Sanjay/Blazor_Authentication_Sample/Blazor_Authentication_Sample/Migrations/20260623061500_Initial.cs
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
