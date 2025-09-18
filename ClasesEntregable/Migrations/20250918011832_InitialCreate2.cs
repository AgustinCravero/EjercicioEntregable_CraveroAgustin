using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesEntregable.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Salario",
                table: "Empleados",
                newName: "salario");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Empleados",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Empleados",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Empleados",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Departamentos",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Departamentos",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Departamentos",
                newName: "id");

            migrationBuilder.AlterColumn<decimal>(
                name: "salario",
                table: "Empleados",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "salario",
                table: "Empleados",
                newName: "Salario");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Empleados",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Empleados",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Empleados",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Departamentos",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "Departamentos",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Departamentos",
                newName: "Id");

            migrationBuilder.AlterColumn<double>(
                name: "Salario",
                table: "Empleados",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
