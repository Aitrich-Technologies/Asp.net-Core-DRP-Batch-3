using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParticipantInformation_TourBookingForm_LeadId",
                table: "ParticipantInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_TourBookingForm_Tours_TourId",
                table: "TourBookingForm");

            migrationBuilder.DropForeignKey(
                name: "FK_TourBookingForm_Users_UserId",
                table: "TourBookingForm");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Destination_DestinationId",
                table: "Tours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TourBookingForm",
                table: "TourBookingForm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParticipantInformation",
                table: "ParticipantInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Destination",
                table: "Destination");

            migrationBuilder.RenameTable(
                name: "TourBookingForm",
                newName: "TourBookingForms");

            migrationBuilder.RenameTable(
                name: "ParticipantInformation",
                newName: "ParticipantInformations");

            migrationBuilder.RenameTable(
                name: "Destination",
                newName: "Destinations");

            migrationBuilder.RenameIndex(
                name: "IX_TourBookingForm_UserId",
                table: "TourBookingForms",
                newName: "IX_TourBookingForms_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TourBookingForm_TourId",
                table: "TourBookingForms",
                newName: "IX_TourBookingForms_TourId");

            migrationBuilder.RenameIndex(
                name: "IX_ParticipantInformation_LeadId",
                table: "ParticipantInformations",
                newName: "IX_ParticipantInformations_LeadId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TourBookingForms",
                table: "TourBookingForms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParticipantInformations",
                table: "ParticipantInformations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Destinations",
                table: "Destinations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParticipantInformations_TourBookingForms_LeadId",
                table: "ParticipantInformations",
                column: "LeadId",
                principalTable: "TourBookingForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourBookingForms_Tours_TourId",
                table: "TourBookingForms",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourBookingForms_Users_UserId",
                table: "TourBookingForms",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Destinations_DestinationId",
                table: "Tours",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParticipantInformations_TourBookingForms_LeadId",
                table: "ParticipantInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_TourBookingForms_Tours_TourId",
                table: "TourBookingForms");

            migrationBuilder.DropForeignKey(
                name: "FK_TourBookingForms_Users_UserId",
                table: "TourBookingForms");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Destinations_DestinationId",
                table: "Tours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TourBookingForms",
                table: "TourBookingForms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParticipantInformations",
                table: "ParticipantInformations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Destinations",
                table: "Destinations");

            migrationBuilder.RenameTable(
                name: "TourBookingForms",
                newName: "TourBookingForm");

            migrationBuilder.RenameTable(
                name: "ParticipantInformations",
                newName: "ParticipantInformation");

            migrationBuilder.RenameTable(
                name: "Destinations",
                newName: "Destination");

            migrationBuilder.RenameIndex(
                name: "IX_TourBookingForms_UserId",
                table: "TourBookingForm",
                newName: "IX_TourBookingForm_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TourBookingForms_TourId",
                table: "TourBookingForm",
                newName: "IX_TourBookingForm_TourId");

            migrationBuilder.RenameIndex(
                name: "IX_ParticipantInformations_LeadId",
                table: "ParticipantInformation",
                newName: "IX_ParticipantInformation_LeadId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TourBookingForm",
                table: "TourBookingForm",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParticipantInformation",
                table: "ParticipantInformation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Destination",
                table: "Destination",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParticipantInformation_TourBookingForm_LeadId",
                table: "ParticipantInformation",
                column: "LeadId",
                principalTable: "TourBookingForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourBookingForm_Tours_TourId",
                table: "TourBookingForm",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TourBookingForm_Users_UserId",
                table: "TourBookingForm",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Destination_DestinationId",
                table: "Tours",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
