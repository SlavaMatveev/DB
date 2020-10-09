using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RESTAURANT.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ID_dish_1",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Volume_Ingredient_1 = table.Column<int>(nullable: false),
                    Cooking_time = table.Column<DateTime>(nullable: false),
                    Name_dish = table.Column<string>(nullable: true),
                    Volume_Ingredient_2 = table.Column<int>(nullable: false),
                    Volume_Ingredient_3 = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_dish_1", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ID_employees",
                columns: table => new
                {
                    Time = table.Column<DateTime>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    check = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    FGS_employer = table.Column<string>(nullable: true),
                    Telefon = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ID_Positions",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Positions = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    Responsibilities = table.Column<string>(nullable: true),
                    Requirements = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_Positions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ID_Ingredient_1",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shelf_life = table.Column<DateTime>(nullable: false),
                    Name_Ingredient = table.Column<string>(nullable: true),
                    Incept_date = table.Column<string>(nullable: true),
                    Volume = table.Column<int>(nullable: false),
                    Producer = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    MenuID = table.Column<long>(nullable: true),
                    MenuID1 = table.Column<long>(nullable: true),
                    MenuID2 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_Ingredient_1", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ID_Ingredient_1_ID_dish_1_MenuID",
                        column: x => x.MenuID,
                        principalTable: "ID_dish_1",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ID_Ingredient_1_ID_dish_1_MenuID1",
                        column: x => x.MenuID1,
                        principalTable: "ID_dish_1",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ID_Ingredient_1_ID_dish_1_MenuID2",
                        column: x => x.MenuID2,
                        principalTable: "ID_dish_1",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ID_Ingredient_1_MenuID",
                table: "ID_Ingredient_1",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_ID_Ingredient_1_MenuID1",
                table: "ID_Ingredient_1",
                column: "MenuID1");

            migrationBuilder.CreateIndex(
                name: "IX_ID_Ingredient_1_MenuID2",
                table: "ID_Ingredient_1",
                column: "MenuID2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ID_employees");

            migrationBuilder.DropTable(
                name: "ID_Ingredient_1");

            migrationBuilder.DropTable(
                name: "ID_Positions");

            migrationBuilder.DropTable(
                name: "ID_dish_1");
        }
    }
}
