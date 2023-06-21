using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThieuNhiTT.Api.Migrations
{
    /// <inheritdoc />
    public partial class SecondDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Profile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_XuDoan_HiepDoanId",
                table: "XuDoan",
                column: "HiepDoanId");

            migrationBuilder.CreateIndex(
                name: "IX_MonHoc_KetQuaHocTapId",
                table: "MonHoc",
                column: "KetQuaHocTapId");

            migrationBuilder.CreateIndex(
                name: "IX_LienDoan_TongLienDoanId",
                table: "LienDoan",
                column: "TongLienDoanId");

            migrationBuilder.CreateIndex(
                name: "IX_HiepDoan_LienDoanId",
                table: "HiepDoan",
                column: "LienDoanId");

            migrationBuilder.AddForeignKey(
                name: "FK_HiepDoan_LienDoan_LienDoanId",
                table: "HiepDoan",
                column: "LienDoanId",
                principalTable: "LienDoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LienDoan_TongLienDoan_TongLienDoanId",
                table: "LienDoan",
                column: "TongLienDoanId",
                principalTable: "TongLienDoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonHoc_KetQuaHocTap_KetQuaHocTapId",
                table: "MonHoc",
                column: "KetQuaHocTapId",
                principalTable: "KetQuaHocTap",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_XuDoan_HiepDoan_HiepDoanId",
                table: "XuDoan",
                column: "HiepDoanId",
                principalTable: "HiepDoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HiepDoan_LienDoan_LienDoanId",
                table: "HiepDoan");

            migrationBuilder.DropForeignKey(
                name: "FK_LienDoan_TongLienDoan_TongLienDoanId",
                table: "LienDoan");

            migrationBuilder.DropForeignKey(
                name: "FK_MonHoc_KetQuaHocTap_KetQuaHocTapId",
                table: "MonHoc");

            migrationBuilder.DropForeignKey(
                name: "FK_XuDoan_HiepDoan_HiepDoanId",
                table: "XuDoan");

            migrationBuilder.DropIndex(
                name: "IX_XuDoan_HiepDoanId",
                table: "XuDoan");

            migrationBuilder.DropIndex(
                name: "IX_MonHoc_KetQuaHocTapId",
                table: "MonHoc");

            migrationBuilder.DropIndex(
                name: "IX_LienDoan_TongLienDoanId",
                table: "LienDoan");

            migrationBuilder.DropIndex(
                name: "IX_HiepDoan_LienDoanId",
                table: "HiepDoan");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Profile");
        }
    }
}
