using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopPilot.Api.Migrations.Application;

/// <inheritdoc />
public partial class Add_Products : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.EnsureSchema(
            name: "shop_pilot");

        migrationBuilder.CreateTable(
            name: "products",
            schema: "shop_pilot",
            columns: table => new
            {
                id = table.Column<Guid>(type: "uuid", nullable: false),
                name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                price = table.Column<decimal>(type: "numeric", nullable: false),
                stock = table.Column<int>(type: "integer", nullable: false),
                image_url = table.Column<string>(type: "text", nullable: true),
                created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_products", x => x.id);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "products",
            schema: "shop_pilot");
    }
}
