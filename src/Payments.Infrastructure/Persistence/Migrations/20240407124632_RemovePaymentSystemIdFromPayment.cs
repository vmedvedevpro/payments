using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Payments.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemovePaymentSystemIdFromPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentSystems_PaymentSystemId",
                table: "Payments");

            migrationBuilder.AlterColumn<Guid>(
                name: "PaymentSystemId",
                table: "Payments",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentSystems_PaymentSystemId",
                table: "Payments",
                column: "PaymentSystemId",
                principalTable: "PaymentSystems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentSystems_PaymentSystemId",
                table: "Payments");

            migrationBuilder.AlterColumn<Guid>(
                name: "PaymentSystemId",
                table: "Payments",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentSystems_PaymentSystemId",
                table: "Payments",
                column: "PaymentSystemId",
                principalTable: "PaymentSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
