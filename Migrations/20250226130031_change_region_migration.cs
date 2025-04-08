﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZwalks.Migrations
{
    /// <inheritdoc />
    public partial class change_region_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Walks_Regions_RegionsId",
                table: "Walks");

            migrationBuilder.DropIndex(
                name: "IX_Walks_RegionsId",
                table: "Walks");

            migrationBuilder.DropColumn(
                name: "RegionsId",
                table: "Walks");

            migrationBuilder.CreateIndex(
                name: "IX_Walks_RegionId",
                table: "Walks",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Walks_Regions_RegionId",
                table: "Walks",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Walks_Regions_RegionId",
                table: "Walks");

            migrationBuilder.DropIndex(
                name: "IX_Walks_RegionId",
                table: "Walks");

            migrationBuilder.AddColumn<Guid>(
                name: "RegionsId",
                table: "Walks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Walks_RegionsId",
                table: "Walks",
                column: "RegionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Walks_Regions_RegionsId",
                table: "Walks",
                column: "RegionsId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
