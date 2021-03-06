// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The ExportSummary. </summary>
    public partial class ExportSummary
    {
        /// <summary> Initializes a new instance of ExportSummary. </summary>
        internal ExportSummary()
        {
        }

        /// <summary> Initializes a new instance of ExportSummary. </summary>
        /// <param name="format"> The format of exported labels, also as the discriminator. </param>
        /// <param name="exportId"> The unique identifier of completed Export Labels operation. </param>
        /// <param name="labelingJobId"> Name and identifier of the job containing exported labels. </param>
        /// <param name="exportedRowCount"> The total number of labeled datapoints exported. </param>
        /// <param name="startTimeUtc"> The time when the export was requested. </param>
        /// <param name="endTimeUtc"> The time when the export was completed. </param>
        /// <param name="state"> The state of the Export Labels operation. </param>
        internal ExportSummary(ExportFormatType format, Guid? exportId, string labelingJobId, long? exportedRowCount, DateTimeOffset? startTimeUtc, DateTimeOffset? endTimeUtc, LabelExportState? state)
        {
            Format = format;
            ExportId = exportId;
            LabelingJobId = labelingJobId;
            ExportedRowCount = exportedRowCount;
            StartTimeUtc = startTimeUtc;
            EndTimeUtc = endTimeUtc;
            State = state;
        }

        /// <summary> The format of exported labels, also as the discriminator. </summary>
        internal ExportFormatType Format { get; set; }
        /// <summary> The unique identifier of completed Export Labels operation. </summary>
        public Guid? ExportId { get; }
        /// <summary> Name and identifier of the job containing exported labels. </summary>
        public string LabelingJobId { get; }
        /// <summary> The total number of labeled datapoints exported. </summary>
        public long? ExportedRowCount { get; }
        /// <summary> The time when the export was requested. </summary>
        public DateTimeOffset? StartTimeUtc { get; }
        /// <summary> The time when the export was completed. </summary>
        public DateTimeOffset? EndTimeUtc { get; }
        /// <summary> The state of the Export Labels operation. </summary>
        public LabelExportState? State { get; }
    }
}
