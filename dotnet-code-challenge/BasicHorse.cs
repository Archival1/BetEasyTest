using System;

namespace dotnet_code_challenge
{
    /**Generated via online .Json to C#
     * While the use case here is rather small, expected data types should still be defined
    **/
    public partial class Race
    {
        public string FixtureId { get; set; }

        public DateTimeOffset Timestamp { get; set; }

        public RawData RawData { get; set; }
    }

    public partial class RawData
    {
        public string FixtureName { get; set; }

        public string Id { get; set; }

        public DateTimeOffset StartTime { get; set; }

        public long Sequence { get; set; }

        public RawDataTags Tags { get; set; }

        public Market[] Markets { get; set; }

        public Participant[] Participants { get; set; }
    }

    public partial class Market
    {
        public string Id { get; set; }

        public Selection[] Selections { get; set; }

        public MarketTags Tags { get; set; }
    }

    public partial class Selection
    {
        public string Id { get; set; }

        public double Price { get; set; }

        public SelectionTags Tags { get; set; }
    }

    public partial class SelectionTags
    {
        public long Participant { get; set; }

        public string Name { get; set; }
    }

    public partial class MarketTags
    {
        public long Places { get; set; }

        public string Type { get; set; }
    }

    public partial class Participant
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public ParticipantTags Tags { get; set; }
    }

    public partial class ParticipantTags
    {
        public string Weight { get; set; }

        public long Drawn { get; set; }

        public string Jockey { get; set; }

        public long Number { get; set; }

        public string Trainer { get; set; }
    }

    public partial class RawDataTags
    {
        public string CourseType { get; set; }

        public string Distance { get; set; }

        public string Going { get; set; }

        public long Runners { get; set; }

        public long MeetingCode { get; set; }

        public string TrackCode { get; set; }

        public string Sport { get; set; }
    }
}
