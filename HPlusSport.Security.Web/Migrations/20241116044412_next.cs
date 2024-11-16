using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPlusSport.Security.Web.Migrations
{
    /// <inheritdoc />
    public partial class next : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "HGyjn+CnM3U1Xu+5usflPKD63Pw=", "SdN8x5Tkc2PG+eqy6JLfoO5BUTSES8WMng+HI8/balo=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "HGyjn+CnM3U1Xu+5usflPKD63Pw=", "XakRB7SFt4r5BJUYQHMiLkulVbb2oHt09WMAkoiNY5E=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "dyKqMosDLiR/Ykzqqm3dV3LNx+c=", "G0EtOU8uhsIDtN+aIC8Bftbl1g9jgi+oU0JJA1l2yF0=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Salt" },
                values: new object[] { "dyKqMosDLiR/Ykzqqm3dV3LNx+c=", "GpDl2CotoPiYlULoaoFQXQYL37P333GLDzi0y3+F2gU=" });
        }
    }
}
