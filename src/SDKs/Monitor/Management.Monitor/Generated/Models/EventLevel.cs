// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EventLevel.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventLevel
    {
        [EnumMember(Value = "Critical")]
        Critical,
        [EnumMember(Value = "Error")]
        Error,
        [EnumMember(Value = "Warning")]
        Warning,
        [EnumMember(Value = "Informational")]
        Informational,
        [EnumMember(Value = "Verbose")]
        Verbose
    }
    internal static class EventLevelEnumExtension
    {
        internal static string ToSerializedValue(this EventLevel? value)
        {
            return value == null ? null : ((EventLevel)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EventLevel value)
        {
            switch( value )
            {
                case EventLevel.Critical:
                    return "Critical";
                case EventLevel.Error:
                    return "Error";
                case EventLevel.Warning:
                    return "Warning";
                case EventLevel.Informational:
                    return "Informational";
                case EventLevel.Verbose:
                    return "Verbose";
            }
            return null;
        }

        internal static EventLevel? ParseEventLevel(this string value)
        {
            switch( value )
            {
                case "Critical":
                    return EventLevel.Critical;
                case "Error":
                    return EventLevel.Error;
                case "Warning":
                    return EventLevel.Warning;
                case "Informational":
                    return EventLevel.Informational;
                case "Verbose":
                    return EventLevel.Verbose;
            }
            return null;
        }
    }
}
