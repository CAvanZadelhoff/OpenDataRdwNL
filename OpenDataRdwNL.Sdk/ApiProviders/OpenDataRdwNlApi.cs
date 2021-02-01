using System.Net.Http;

namespace OpenDataRdwNL.Sdk.ApiProviders
{
    public static class OpenDataRdwNlApi
    {
        public static class Basic
        {
            public static string ResourceUrl { get; } = "/resource/";
        }
        
        public static class GetCarDetail
        {
            public static string ResourceId { get; } = "m9d7-ebf2";
        }
        
        public static class GetCarFuelTypeDetail
        {
            public static string ResourceId { get; } = "8ys7-d773";

        }
        
        public static class GetCarVehicleBodyWorkDetail
        {
            public static string ResourceId { get; } = "vezc-m2t6";

        }
    }

    public enum ResourceType
    {
        Json,
        Csv
    }
}