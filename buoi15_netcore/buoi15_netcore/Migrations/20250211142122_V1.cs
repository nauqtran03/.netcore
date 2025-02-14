using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace buoi15_netcore.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NOTE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CATEGORY__3214EC270117D524", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ORDERS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TOTAL_PRICE = table.Column<double>(type: "float", nullable: true),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PHONE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ADDRESS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ORDERS__3214EC27D3E551C4", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NOTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRICE = table.Column<double>(type: "float", nullable: true),
                    IMAGES = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CATEGORY_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PRODUCT__3214EC279F8E9405", x => x.ID);
                    table.ForeignKey(
                        name: "FK__PRODUCT__CATEGOR__398D8EEE",
                        column: x => x.CATEGORY_ID,
                        principalTable: "CATEGORY",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ORDERS_DETAIL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ORDERS_ID = table.Column<int>(type: "int", nullable: true),
                    PRODUCT_ID = table.Column<int>(type: "int", nullable: true),
                    PRICE = table.Column<double>(type: "float", nullable: true),
                    QUANTITY = table.Column<int>(type: "int", nullable: true),
                    TOTAL_PRICE = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ORDERS_D__3214EC274CECCFB9", x => x.ID);
                    table.ForeignKey(
                        name: "FK__ORDERS_DE__ORDER__3E52440B",
                        column: x => x.ORDERS_ID,
                        principalTable: "ORDERS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__ORDERS_DE__PRODU__3F466844",
                        column: x => x.PRODUCT_ID,
                        principalTable: "PRODUCT",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_DETAIL_ORDERS_ID",
                table: "ORDERS_DETAIL",
                column: "ORDERS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_DETAIL_PRODUCT_ID",
                table: "ORDERS_DETAIL",
                column: "PRODUCT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_CATEGORY_ID",
                table: "PRODUCT",
                column: "CATEGORY_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ORDERS_DETAIL");

            migrationBuilder.DropTable(
                name: "ORDERS");

            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "CATEGORY");
        }
    }
}
