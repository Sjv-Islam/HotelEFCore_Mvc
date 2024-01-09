using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class sp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sqlCode = @"create proc spDeleteGuest
@GuestId int

as

delete from Rooms where RoomId = @GuestId
delete from Guests where Id = @GuestId";
            migrationBuilder.Sql(sqlCode);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop proc spDeleteGuest");
        }
    }
}
