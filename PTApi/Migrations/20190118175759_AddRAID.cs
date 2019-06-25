using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class AddRAID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assumptions",
                columns: table => new
                {
                    AssumptionId = table.Column<string>(nullable: false),
                    Actiontovalidate = table.Column<string>(nullable: true),
                    AssumptionCode = table.Column<string>(nullable: true),
                    Cascade = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<string>(nullable: true),
                    DateRaised = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Impactifassumptionfails = table.Column<string>(nullable: true),
                    Latestupdate = table.Column<string>(nullable: true),
                    LatestupdateDate = table.Column<DateTime>(nullable: true),
                    ProjectId = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    Reviewstatus = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assumptions", x => x.AssumptionId);
                    table.ForeignKey(
                        name: "FK_Assumptions_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dependencies",
                columns: table => new
                {
                    DependencyId = table.Column<string>(nullable: false),
                    Cascade = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<string>(nullable: true),
                    DateRaised = table.Column<DateTime>(nullable: true),
                    Dateclosed = table.Column<DateTime>(nullable: true),
                    Deliverables = table.Column<string>(nullable: true),
                    DeliveryDate = table.Column<string>(nullable: true),
                    DependencyCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Importance = table.Column<string>(nullable: true),
                    Latestupdate = table.Column<string>(nullable: true),
                    LatestupdateDate = table.Column<DateTime>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(nullable: true),
                    Reviewstatus = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependencies", x => x.DependencyId);
                    table.ForeignKey(
                        name: "FK_Dependencies_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    IssueId = table.Column<string>(nullable: false),
                    Cascade = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<string>(nullable: true),
                    DateRaised = table.Column<DateTime>(nullable: true),
                    Dateclosed = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Impact = table.Column<string>(nullable: true),
                    IssueCode = table.Column<string>(nullable: true),
                    Latestupdate = table.Column<string>(nullable: true),
                    LatestupdateDate = table.Column<DateTime>(nullable: true),
                    Mitigationplan = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    Priority = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(nullable: true),
                    Reviewstatus = table.Column<string>(nullable: true),
                    Severity = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.IssueId);
                    table.ForeignKey(
                        name: "FK_Issues_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Risks",
                columns: table => new
                {
                    RiskId = table.Column<string>(nullable: false),
                    Cascade = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<string>(nullable: true),
                    DateRaised = table.Column<DateTime>(nullable: true),
                    Dateclosed = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Impact = table.Column<string>(nullable: true),
                    Latestupdate = table.Column<string>(nullable: true),
                    LatestupdateDate = table.Column<DateTime>(nullable: true),
                    Likelihood = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(nullable: true),
                    Reviewstatus = table.Column<string>(nullable: true),
                    RiskCode = table.Column<string>(nullable: true),
                    Severity = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risks", x => x.RiskId);
                    table.ForeignKey(
                        name: "FK_Risks_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assumptions_ProjectId",
                table: "Assumptions",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Dependencies_ProjectId",
                table: "Dependencies",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_ProjectId",
                table: "Issues",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Risks_ProjectId",
                table: "Risks",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assumptions");

            migrationBuilder.DropTable(
                name: "Dependencies");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "Risks");
        }
    }
}
