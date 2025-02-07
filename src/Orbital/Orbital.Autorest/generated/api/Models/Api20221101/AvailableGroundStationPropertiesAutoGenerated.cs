// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Extensions;

    /// <summary>The properties bag for this resource.</summary>
    public partial class AvailableGroundStationPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesAutoGeneratedInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationProperties __availableGroundStationProperties = new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.AvailableGroundStationProperties();

        /// <summary>Altitude of the ground station.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        public float? AltitudeMeter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesInternal)__availableGroundStationProperties).AltitudeMeter; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesInternal)__availableGroundStationProperties).AltitudeMeter = value ?? default(float); }

        /// <summary>City of ground station.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        public string City { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesInternal)__availableGroundStationProperties).City; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesInternal)__availableGroundStationProperties).City = value ?? null; }

        /// <summary>Latitude of the ground station in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        public float? LatitudeDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesInternal)__availableGroundStationProperties).LatitudeDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesInternal)__availableGroundStationProperties).LatitudeDegree = value ?? default(float); }

        /// <summary>Longitude of the ground station in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        public float? LongitudeDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesInternal)__availableGroundStationProperties).LongitudeDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesInternal)__availableGroundStationProperties).LongitudeDegree = value ?? default(float); }

        /// <summary>Ground station provider name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        public string ProviderName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesInternal)__availableGroundStationProperties).ProviderName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesInternal)__availableGroundStationProperties).ProviderName = value ?? null; }

        /// <summary>Release Status of a ground station.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.ReleaseMode? ReleaseMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesInternal)__availableGroundStationProperties).ReleaseMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesInternal)__availableGroundStationProperties).ReleaseMode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.ReleaseMode)""); }

        /// <summary>
        /// Creates an new <see cref="AvailableGroundStationPropertiesAutoGenerated" /> instance.
        /// </summary>
        public AvailableGroundStationPropertiesAutoGenerated()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__availableGroundStationProperties), __availableGroundStationProperties);
            await eventListener.AssertObjectIsValid(nameof(__availableGroundStationProperties), __availableGroundStationProperties);
        }
    }
    /// The properties bag for this resource.
    public partial interface IAvailableGroundStationPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationProperties
    {

    }
    /// The properties bag for this resource.
    internal partial interface IAvailableGroundStationPropertiesAutoGeneratedInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IAvailableGroundStationPropertiesInternal
    {

    }
}