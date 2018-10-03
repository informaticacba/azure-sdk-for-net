// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SegmentTerminatorSuffix.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SegmentTerminatorSuffix
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "CR")]
        CR,
        [EnumMember(Value = "LF")]
        LF,
        [EnumMember(Value = "CRLF")]
        CRLF
    }
    internal static class SegmentTerminatorSuffixEnumExtension
    {
        internal static string ToSerializedValue(this SegmentTerminatorSuffix? value)
        {
            return value == null ? null : ((SegmentTerminatorSuffix)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SegmentTerminatorSuffix value)
        {
            switch( value )
            {
                case SegmentTerminatorSuffix.NotSpecified:
                    return "NotSpecified";
                case SegmentTerminatorSuffix.None:
                    return "None";
                case SegmentTerminatorSuffix.CR:
                    return "CR";
                case SegmentTerminatorSuffix.LF:
                    return "LF";
                case SegmentTerminatorSuffix.CRLF:
                    return "CRLF";
            }
            return null;
        }

        internal static SegmentTerminatorSuffix? ParseSegmentTerminatorSuffix(this string value)
        {
            switch( value )
            {
                case "NotSpecified":
                    return SegmentTerminatorSuffix.NotSpecified;
                case "None":
                    return SegmentTerminatorSuffix.None;
                case "CR":
                    return SegmentTerminatorSuffix.CR;
                case "LF":
                    return SegmentTerminatorSuffix.LF;
                case "CRLF":
                    return SegmentTerminatorSuffix.CRLF;
            }
            return null;
        }
    }
}
