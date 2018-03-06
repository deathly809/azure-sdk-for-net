// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for QueryStringCachingBehavior.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueryStringCachingBehavior
    {
        [EnumMember(Value = "IgnoreQueryString")]
        IgnoreQueryString,
        [EnumMember(Value = "BypassCaching")]
        BypassCaching,
        [EnumMember(Value = "UseQueryString")]
        UseQueryString,
        [EnumMember(Value = "NotSet")]
        NotSet
    }
    internal static class QueryStringCachingBehaviorEnumExtension
    {
        internal static string ToSerializedValue(this QueryStringCachingBehavior? value)
        {
            return value == null ? null : ((QueryStringCachingBehavior)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this QueryStringCachingBehavior value)
        {
            switch( value )
            {
                case QueryStringCachingBehavior.IgnoreQueryString:
                    return "IgnoreQueryString";
                case QueryStringCachingBehavior.BypassCaching:
                    return "BypassCaching";
                case QueryStringCachingBehavior.UseQueryString:
                    return "UseQueryString";
                case QueryStringCachingBehavior.NotSet:
                    return "NotSet";
            }
            return null;
        }

        internal static QueryStringCachingBehavior? ParseQueryStringCachingBehavior(this string value)
        {
            switch( value )
            {
                case "IgnoreQueryString":
                    return QueryStringCachingBehavior.IgnoreQueryString;
                case "BypassCaching":
                    return QueryStringCachingBehavior.BypassCaching;
                case "UseQueryString":
                    return QueryStringCachingBehavior.UseQueryString;
                case "NotSet":
                    return QueryStringCachingBehavior.NotSet;
            }
            return null;
        }
    }
}
