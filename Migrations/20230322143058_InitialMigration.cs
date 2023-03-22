using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Challenge_Flextech.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movimientosBcra",
                columns: table => new
                {
                    operatoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    transaccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entidadDeudora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cuentaDeudora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entidadAcreedora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cuentaAcreedora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    importe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    instruccionDePago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaProcesado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numeroInterno = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movimientosBcra");
        }
    }
}
