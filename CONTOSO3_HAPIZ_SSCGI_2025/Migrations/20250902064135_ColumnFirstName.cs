﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CONTOSO3_HAPIZ_SSCGI_2025.Migrations
{
    /// <inheritdoc />
    public partial class ColumnFirstName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstMidName",
                table: "Student",
                newName: "FirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Student",
                newName: "FirstMidName");
        }
    }
}
