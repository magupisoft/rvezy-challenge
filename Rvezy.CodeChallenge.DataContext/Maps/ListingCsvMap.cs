using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using Rvezy.CodeChallenge.Models;

namespace Rvezy.CodeChallenge.DataContext.Maps
{
    public class ListingCsvMap : ClassMap<ListingModel>
    {
        public ListingCsvMap()
        {
            Map(m => m.Id).Name("id");
            Map(m => m.ListingUrl).Name("listing_url");
            Map(m => m.ScrapeId).Name("scrape_id");
            Map(m => m.LastScraped).Name("last_scraped");
            Map(m => m.Name).Name("name");
            Map(m => m.Summary).Name("summary");
            Map(m => m.Space).Name("space");
            Map(m => m.Description).Name("description");
            Map(m => m.ExperiencesOffered).Name("experiences_offered");
            Map(m => m.NeighborhoodOverview).Name("neighborhood_overview");
            Map(m => m.Notes).Name("notes");
            Map(m => m.Transit).Name("transit");
            Map(m => m.ThumbnailUrl).Name("thumbnail_url");
            Map(m => m.MediumUrl).Name("medium_url");
            Map(m => m.PictureUrl).Name("picture_url");
            Map(m => m.XlPictureUrl).Name("xl_picture_url");
            Map(m => m.HostId).Name("host_id");
            Map(m => m.HostUrl).Name("host_url");
            Map(m => m.HostName).Name("host_name");
            Map(m => m.HostSince).Name("host_since");
            Map(m => m.HostLocation).Name("host_location");
            Map(m => m.HostAbout).Name("host_about");
            Map(m => m.HostResponseTime).Name("host_response_time");
            Map(m => m.HostResponseRate).Name("host_response_rate");
            Map(m => m.HostAcceptanceRate).Name("host_acceptance_rate");
            Map(m => m.HostIsSuperhost).Name("host_is_superhost");
            Map(m => m.HostThumbnailUrl).Name("host_thumbnail_url");
            Map(m => m.HostPictureUrl).Name("host_picture_url");
            Map(m => m.HostNeighbourhood).Name("host_neighbourhood");
            Map(m => m.HostListingsCount).Name("host_listings_count");
            Map(m => m.HostTotalListingsCount).Name("host_total_listings_count");
            Map(m => m.HostVerifications).Name("host_verifications");
            Map(m => m.HostHasProfilePic).Name("host_has_profile_pic");
            Map(m => m.HostIdentityVerified).Name("host_identity_verified");
            Map(m => m.Street).Name("street");
            Map(m => m.Neighbourhood).Name("neighbourhood");
            Map(m => m.NeighbourhoodCleansed).Name("neighbourhood_cleansed");
            Map(m => m.NeighbourhoodGroupCleansed).Name("neighbourhood_group_cleansed");
            Map(m => m.City).Name("city");
            Map(m => m.State).Name("state");
            Map(m => m.Zipcode).Name("zipcode");
            Map(m => m.Market).Name("market");
            Map(m => m.SmartLocation).Name("smart_location");
            Map(m => m.CountryCode).Name("country_code");
            Map(m => m.Country).Name("country");
            Map(m => m.Latitude).Name("latitude");
            Map(m => m.Longitude).Name("longitude");
            Map(m => m.IsLocationExact).Name("is_location_exact");
            Map(m => m.PropertyType).Name("property_type");
            Map(m => m.RoomType).Name("room_type");
            Map(m => m.Accommodates).Name("accommodates");
            Map(m => m.Bathrooms).Name("bathrooms");
            Map(m => m.Bedrooms).Name("bedrooms");
            Map(m => m.Beds).Name("beds");
            Map(m => m.BedType).Name("bed_type");
            Map(m => m.Amenities).Name("amenities");
            Map(m => m.SquareFeet).Name("square_feet");
            Map(m => m.Price).Name("price");
            Map(m => m.WeeklyPrice).Name("weekly_price");
            Map(m => m.MonthlyPrice).Name("monthly_price");
            Map(m => m.SecurityDeposit).Name("security_deposit");
            Map(m => m.CleaningFee).Name("cleaning_fee");
            Map(m => m.GuestsIncluded).Name("guests_included");
            Map(m => m.ExtraPeople).Name("extra_people");
            Map(m => m.MinimumNights).Name("minimum_nights");
            Map(m => m.MaximumNights).Name("maximum_nights");
            Map(m => m.CalendarUpdated).Name("calendar_updated");
            Map(m => m.HasAvailability).Name("has_availability");
            Map(m => m.Availability30).Name("availability_30");
            Map(m => m.Availability60).Name("availability_60");
            Map(m => m.Availability90).Name("availability_90");
            Map(m => m.Availability365).Name("availability_365");
            Map(m => m.CalendarLastScraped).Name("calendar_last_scraped");
            Map(m => m.NumberOfReviews).Name("number_of_reviews");
            Map(m => m.FirstReview).Name("first_review");
            Map(m => m.LastReview).Name("last_review");
            Map(m => m.ReviewScoresRating).Name("review_scores_rating");
            Map(m => m.ReviewScoresAccuracy).Name("review_scores_accuracy");
            Map(m => m.ReviewScoresCleanliness).Name("review_scores_cleanliness");
            Map(m => m.ReviewScoresCheckin).Name("review_scores_checkin");
            Map(m => m.ReviewScoresCommunication).Name("review_scores_communication");
            Map(m => m.ReviewScoresLocation).Name("review_scores_location");
            Map(m => m.ReviewScoresValue).Name("review_scores_value");
            Map(m => m.RequiresLicense).Name("requires_license");
            Map(m => m.License).Name("license");
            Map(m => m.JurisdictionNames).Name("jurisdiction_names");
            Map(m => m.InstantBookable).Name("instant_bookable");
            Map(m => m.CancellationPolicy).Name("cancellation_policy");
            Map(m => m.RequireGuestProfilePicture).Name("require_guest_profile_picture");
            Map(m => m.RequireGuestPhoneVerification).Name("require_guest_phone_verification");
            Map(m => m.CalculatedHostListingsCount).Name("calculated_host_listings_count");
            Map(m => m.ReviewsPerMonth).Name("reviews_per_month");
        }
    }
}
