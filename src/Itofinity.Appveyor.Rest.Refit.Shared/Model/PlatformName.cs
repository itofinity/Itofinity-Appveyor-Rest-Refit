/* 
 * AppVeyor REST API
 *
 * AppVeyor is a hosted continuous integration service which runs on Microsoft Windows.  The AppVeyor REST API provides a RESTful way to interact with the AppVeyor service.  This includes managing projects, builds, deployments, and the teams that build them.  Additional help and discussion of the AppVeyor REST API is available at http://help.appveyor.com/discussions  This Swagger definition is an **unofficial** description of the AppVeyor REST API maintained at https://github.com/kevinoid/appveyor-swagger Please report any issues or suggestions for this Swagger definition at https://github.com/kevinoid/appveyor-swagger/issues/new  #### API Conventions  Fields which are missing from update operations (`PUT` requests) are typically reset to their default values.  So although most fields are not technically required, they should usually be specified in practice. 
 *
 * OpenAPI spec version: 0.20170106.0
 * Contact: team@appveyor.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Itofinity.Appveyor.Rest.Refit.Model
{
    /// <summary>
    /// Defines PlatformName
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PlatformName
    {
        
        /// <summary>
        /// Enum ARM for "ARM"
        /// </summary>
        [EnumMember(Value = "ARM")]
        ARM,
        
        /// <summary>
        /// Enum AnyCPU for "Any CPU"
        /// </summary>
        [EnumMember(Value = "Any CPU")]
        AnyCPU,
        
        /// <summary>
        /// Enum X64 for "x64"
        /// </summary>
        [EnumMember(Value = "x64")]
        X64,
        
        /// <summary>
        /// Enum X86 for "x86"
        /// </summary>
        [EnumMember(Value = "x86")]
        X86
    }

}
