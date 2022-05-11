//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "GalleryImageDefinition", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSGalleryImage))]
    public partial class NewAzureRmGalleryImage : ComputeAutomationBaseCmdlet
    {
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ShouldProcess(this.Name, VerbsCommon.New))
                {
                    string resourceGroupName = this.ResourceGroupName;
                    string galleryName = this.GalleryName;
                    string galleryImageName = this.Name;

                    GalleryImage galleryImage = new GalleryImage();
                    galleryImage.Location = this.Location;
                    galleryImage.Identifier = new GalleryImageIdentifier(this.Publisher, this.Offer, this.Sku);
                    galleryImage.OsState = this.OsState;
                    galleryImage.OsType = this.OsType;

                    if (this.IsParameterBound(c => c.Description))
                    {
                        galleryImage.Description = this.Description;
                    }

                    if (this.IsParameterBound(c => c.Eula))
                    {
                        galleryImage.Eula = this.Eula;
                    }

                    if (this.IsParameterBound(c => c.HyperVGeneration))
                    {
                        galleryImage.HyperVGeneration = this.HyperVGeneration;
                    }

                    if (this.IsParameterBound(c => c.PrivacyStatementUri))
                    {
                        galleryImage.PrivacyStatementUri = this.PrivacyStatementUri;
                    }

                    if (this.IsParameterBound(c => c.ReleaseNoteUri))
                    {
                        galleryImage.ReleaseNoteUri = this.ReleaseNoteUri;
                    }

                    if (this.IsParameterBound(c => c.EndOfLifeDate))
                    {
                        galleryImage.EndOfLifeDate = this.EndOfLifeDate;
                    }

                    if (this.IsParameterBound(c => c.Tag))
                    {
                        galleryImage.Tags = this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value);
                    }

                    if (this.IsParameterBound(c => c.MinimumVCPU))
                    {
                        if (galleryImage.Recommended == null)
                        {
                            galleryImage.Recommended = new RecommendedMachineConfiguration();
                        }
                        if (galleryImage.Recommended.VCPUs == null)
                        {
                            galleryImage.Recommended.VCPUs = new ResourceRange();
                        }
                        galleryImage.Recommended.VCPUs.Min = this.MinimumVCPU;
                    }

                    if (this.IsParameterBound(c => c.MaximumVCPU))
                    {
                        if (galleryImage.Recommended == null)
                        {
                            galleryImage.Recommended = new RecommendedMachineConfiguration();
                        }
                        if (galleryImage.Recommended.VCPUs == null)
                        {
                            galleryImage.Recommended.VCPUs = new ResourceRange();
                        }
                        galleryImage.Recommended.VCPUs.Max = this.MaximumVCPU;
                    }

                    if (this.IsParameterBound(c => c.MinimumMemory))
                    {
                        if (galleryImage.Recommended == null)
                        {
                            galleryImage.Recommended = new RecommendedMachineConfiguration();
                        }
                        if (galleryImage.Recommended.Memory == null)
                        {
                            galleryImage.Recommended.Memory = new ResourceRange();
                        }
                        galleryImage.Recommended.Memory.Min = this.MinimumMemory;
                    }

                    if (this.IsParameterBound(c => c.MaximumMemory))
                    {
                        if (galleryImage.Recommended == null)
                        {
                            galleryImage.Recommended = new RecommendedMachineConfiguration();
                        }
                        if (galleryImage.Recommended.Memory == null)
                        {
                            galleryImage.Recommended.Memory = new ResourceRange();
                        }
                        galleryImage.Recommended.Memory.Max = this.MaximumMemory;
                    }

                    if (this.IsParameterBound(c => c.DisallowedDiskType))
                    {
                        if (galleryImage.Disallowed == null)
                        {
                            galleryImage.Disallowed = new Disallowed();
                        }
                        galleryImage.Disallowed.DiskTypes = this.DisallowedDiskType;
                    }

                    if (this.IsParameterBound(c => c.PurchasePlanName))
                    {
                        if (galleryImage.PurchasePlan == null)
                        {
                            galleryImage.PurchasePlan = new ImagePurchasePlan();
                        }
                        galleryImage.PurchasePlan.Name = this.PurchasePlanName;
                    }

                    if (this.IsParameterBound(c => c.PurchasePlanPublisher))
                    {
                        if (galleryImage.PurchasePlan == null)
                        {
                            galleryImage.PurchasePlan = new ImagePurchasePlan();
                        }
                        galleryImage.PurchasePlan.Publisher = this.PurchasePlanPublisher;
                    }

                    if (this.IsParameterBound(c => c.PurchasePlanProduct))
                    {
                        if (galleryImage.PurchasePlan == null)
                        {
                            galleryImage.PurchasePlan = new ImagePurchasePlan();
                        }
                        galleryImage.PurchasePlan.Product = this.PurchasePlanProduct;
                    }

                    if (this.IsParameterBound(c => c.Feature))
                    {
                        galleryImage.Features = this.Feature;
                    }

                    var result = GalleryImagesClient.CreateOrUpdate(resourceGroupName, galleryName, galleryImageName, galleryImage);
                    var psObject = new PSGalleryImage();
                    ComputeAutomationAutoMapperProfile.Mapper.Map<GalleryImage, PSGalleryImage>(result, psObject);
                    WriteObject(psObject);
                }
            });
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string GalleryName { get; set; }

        [Alias("GalleryImageDefinitionName")]
        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 2,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        [Parameter(
            Mandatory = true,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        [LocationCompleter("Microsoft.Compute/Galleries")]
        public string Location { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string Publisher { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string Offer { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string Sku { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public OperatingSystemStateTypes OsState { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public OperatingSystemTypes OsType { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string Description { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string[] DisallowedDiskType { get; set; } 

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public DateTime EndOfLifeDate { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string Eula { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("V1", "V2")]
        public string HyperVGeneration { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int MinimumMemory { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int MinimumVCPU { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int MaximumMemory { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int MaximumVCPU { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PrivacyStatementUri { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PurchasePlanName { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PurchasePlanProduct { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PurchasePlanPublisher { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string ReleaseNoteUri { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public GalleryImageFeature[] Feature { get; set; }
    }

    [Cmdlet(VerbsData.Update, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "GalleryImageDefinition", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSGalleryImage))]
    public partial class UpdateAzureRmGalleryImage : ComputeAutomationBaseCmdlet
    {
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ShouldProcess(this.Name, VerbsData.Update))
                {
                    string resourceGroupName;
                    string galleryName;
                    string galleryImageName;
                    switch (this.ParameterSetName)
                    {
                        case "ResourceIdParameter":
                            resourceGroupName = GetResourceGroupName(this.ResourceId);
                            galleryName = GetResourceName(this.ResourceId, "Microsoft.Compute/Galleries", "Images");
                            galleryImageName = GetInstanceId(this.ResourceId, "Microsoft.Compute/Galleries", "Images");
                            break;
                        case "ObjectParameter":
                            resourceGroupName = GetResourceGroupName(this.InputObject.Id);
                            galleryName = GetResourceName(this.InputObject.Id, "Microsoft.Compute/Galleries", "Images");
                            galleryImageName = GetInstanceId(this.InputObject.Id, "Microsoft.Compute/Galleries", "Images");
                            break;
                        default:
                            resourceGroupName = this.ResourceGroupName;
                            galleryName = this.GalleryName;
                            galleryImageName = this.Name;
                            break;
                    }

                    var galleryImage = new GalleryImage();

                    if (this.ParameterSetName == "ObjectParameter")
                    {
                        ComputeAutomationAutoMapperProfile.Mapper.Map<PSGalleryImage, GalleryImage>(this.InputObject, galleryImage);
                    }
                    else
                    {
                        galleryImage = GalleryImagesClient.Get(resourceGroupName, galleryName, galleryImageName);
                    }

                    if (this.IsParameterBound(c => c.Description))
                    {   
                        galleryImage.Description = this.Description;
                    }

                    if (this.IsParameterBound(c => c.Eula))
                    {
                        galleryImage.Eula = this.Eula;
                    }

                    if (this.IsParameterBound(c => c.PrivacyStatementUri))
                    {
                        galleryImage.PrivacyStatementUri = this.PrivacyStatementUri;
                    }

                    if (this.IsParameterBound(c => c.ReleaseNoteUri))
                    {
                        galleryImage.ReleaseNoteUri = this.ReleaseNoteUri;
                    }

                    if (this.IsParameterBound(c => c.EndOfLifeDate))
                    {
                        galleryImage.EndOfLifeDate = this.EndOfLifeDate;
                    }

                    if (this.IsParameterBound(c => c.Tag))
                    {
                        galleryImage.Tags = this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value);
                    }

                    if (this.IsParameterBound(c => c.Architecture))
                    {
                        galleryImage.Architecture = this.Architecture;
                    }

                    if (this.IsParameterBound(c => c.MinimumVCPU))
                    {
                        if (galleryImage.Recommended == null)
                        {
                            galleryImage.Recommended = new RecommendedMachineConfiguration();
                        }
                        if (galleryImage.Recommended.VCPUs == null)
                        {
                            galleryImage.Recommended.VCPUs = new ResourceRange();
                        }
                        galleryImage.Recommended.VCPUs.Min = this.MinimumVCPU;
                    }

                    if (this.IsParameterBound(c => c.MaximumVCPU))
                    {
                        if (galleryImage.Recommended == null)
                        {
                            galleryImage.Recommended = new RecommendedMachineConfiguration();
                        }
                        if (galleryImage.Recommended.VCPUs == null)
                        {
                            galleryImage.Recommended.VCPUs = new ResourceRange();
                        }
                        galleryImage.Recommended.VCPUs.Max = this.MaximumVCPU;
                    }

                    if (this.IsParameterBound(c => c.MinimumMemory))
                    {
                        if (galleryImage.Recommended == null)
                        {
                            galleryImage.Recommended = new RecommendedMachineConfiguration();
                        }
                        if (galleryImage.Recommended.Memory == null)
                        {
                            galleryImage.Recommended.Memory = new ResourceRange();
                        }
                        galleryImage.Recommended.Memory.Min = this.MinimumMemory;
                    }

                    if (this.IsParameterBound(c => c.MaximumMemory))
                    {
                        if (galleryImage.Recommended == null)
                        {
                            galleryImage.Recommended = new RecommendedMachineConfiguration();
                        }
                        if (galleryImage.Recommended.Memory == null)
                        {
                            galleryImage.Recommended.Memory = new ResourceRange();
                        }
                        galleryImage.Recommended.Memory.Max = this.MaximumMemory;
                    }

                    if (this.IsParameterBound(c => c.DisallowedDiskType))
                    {
                        if (galleryImage.Disallowed == null)
                        {
                            galleryImage.Disallowed = new Disallowed();
                        }
                        galleryImage.Disallowed.DiskTypes = this.DisallowedDiskType;
                    }

                    if (this.IsParameterBound(c => c.PurchasePlanName))
                    {
                        if (galleryImage.PurchasePlan == null)
                        {
                            galleryImage.PurchasePlan = new ImagePurchasePlan();
                        }
                        galleryImage.PurchasePlan.Name = this.PurchasePlanName;
                    }

                    if (this.IsParameterBound(c => c.PurchasePlanPublisher))
                    {
                        if (galleryImage.PurchasePlan == null)
                        {
                            galleryImage.PurchasePlan = new ImagePurchasePlan();
                        }
                        galleryImage.PurchasePlan.Publisher = this.PurchasePlanPublisher;
                    }

                    if (this.IsParameterBound(c => c.PurchasePlanProduct))
                    {
                        if (galleryImage.PurchasePlan == null)
                        {
                            galleryImage.PurchasePlan = new ImagePurchasePlan();
                        }
                        galleryImage.PurchasePlan.Product = this.PurchasePlanProduct;
                    }

                    var result = GalleryImagesClient.CreateOrUpdate(resourceGroupName, galleryName, galleryImageName, galleryImage);
                    var psObject = new PSGalleryImage();
                    ComputeAutomationAutoMapperProfile.Mapper.Map<GalleryImage, PSGalleryImage>(result, psObject);
                    WriteObject(psObject);
                }
            });
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string GalleryName { get; set; }

        [Alias("GalleryImageDefinitionName")]
        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 2,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        [Parameter(
            ParameterSetName = "ResourceIdParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string ResourceId { get; set; }

        [Alias("GalleryImageDefinition")]
        [Parameter(
            ParameterSetName = "ObjectParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true)]
        public PSGalleryImage InputObject { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string Description { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string[] DisallowedDiskType { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public DateTime EndOfLifeDate { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string Eula { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int MinimumMemory { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int MinimumVCPU { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int MaximumMemory { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int MaximumVCPU { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PrivacyStatementUri { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PurchasePlanName { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PurchasePlanProduct { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string PurchasePlanPublisher { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string ReleaseNoteUri { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "CPU architecture supported by an OS disk. Possible values are \"X64\" and \"Arm64\".")]
        [PSArgumentCompleter("X64", "Arm64")]
        public string Architecture { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }
    }
}
