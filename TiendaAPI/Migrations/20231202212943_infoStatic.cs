using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InfoStatic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table:"Sizes",
                columns: new [] { "SizeName" },
                values: new object[,] {
                    {"S-Small"},
                    {"M-Midium"},
                    {"L-Large"},
                    {"XL-Extra Large"},
                    {"XXL-Extra Extra Large"}
                 }
                
                );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
