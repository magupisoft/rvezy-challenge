using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rvezy.CodeChallenge.DataContext.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Listing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ListingUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScrapeId = table.Column<long>(type: "bigint", nullable: true),
                    LastScraped = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Space = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperiencesOffered = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeighborhoodOverview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediumUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XlPictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostId = table.Column<int>(type: "int", nullable: true),
                    HostUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostSince = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HostLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostAbout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostResponseTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostResponseRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostAcceptanceRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostIsSuperhost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostPictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostNeighbourhood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostListingsCount = table.Column<int>(type: "int", nullable: true),
                    HostTotalListingsCount = table.Column<int>(type: "int", nullable: true),
                    HostVerifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostHasProfilePic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostIdentityVerified = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Neighbourhood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeighbourhoodCleansed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeighbourhoodGroupCleansed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zipcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Market = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmartLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    IsLocationExact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accommodates = table.Column<int>(type: "int", nullable: true),
                    Bathrooms = table.Column<double>(type: "float", nullable: true),
                    Bedrooms = table.Column<int>(type: "int", nullable: true),
                    Beds = table.Column<int>(type: "int", nullable: true),
                    BedType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amenities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SquareFeet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeeklyPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthlyPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityDeposit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CleaningFee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuestsIncluded = table.Column<int>(type: "int", nullable: true),
                    ExtraPeople = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimumNights = table.Column<int>(type: "int", nullable: true),
                    MaximumNights = table.Column<int>(type: "int", nullable: true),
                    CalendarUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasAvailability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Availability30 = table.Column<int>(type: "int", nullable: true),
                    Availability60 = table.Column<int>(type: "int", nullable: true),
                    Availability90 = table.Column<int>(type: "int", nullable: true),
                    Availability365 = table.Column<int>(type: "int", nullable: true),
                    CalendarLastScraped = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumberOfReviews = table.Column<int>(type: "int", nullable: true),
                    FirstReview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastReview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewScoresRating = table.Column<int>(type: "int", nullable: true),
                    ReviewScoresAccuracy = table.Column<int>(type: "int", nullable: true),
                    ReviewScoresCleanliness = table.Column<int>(type: "int", nullable: true),
                    ReviewScoresCheckin = table.Column<int>(type: "int", nullable: true),
                    ReviewScoresCommunication = table.Column<int>(type: "int", nullable: true),
                    ReviewScoresLocation = table.Column<int>(type: "int", nullable: true),
                    ReviewScoresValue = table.Column<int>(type: "int", nullable: true),
                    RequiresLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    License = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JurisdictionNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstantBookable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancellationPolicy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequireGuestProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequireGuestPhoneVerification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CalculatedHostListingsCount = table.Column<int>(type: "int", nullable: true),
                    ReviewsPerMonth = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calendar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListingId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Available = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendar_Listing_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ListingId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewerId = table.Column<int>(type: "int", nullable: false),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Listing_ListingId",
                        column: x => x.ListingId,
                        principalTable: "Listing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calendar_ListingId",
                table: "Calendar",
                column: "ListingId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_ListingId",
                table: "Review",
                column: "ListingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calendar");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Listing");
        }
    }
}
