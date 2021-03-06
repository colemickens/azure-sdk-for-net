// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A scheduling policy for a compute node.
    /// </summary>
    public partial class TaskSchedulingPolicy : ITransportObjectProvider<Models.TaskSchedulingPolicy>, IPropertyMetadata
    {
        private readonly Common.ComputeNodeFillType computeNodeFillType;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSchedulingPolicy"/> class.
        /// </summary>
        /// <param name='computeNodeFillType'>The fill type of scheduling policy.</param>
        public TaskSchedulingPolicy(
            Common.ComputeNodeFillType computeNodeFillType)
        {
            this.computeNodeFillType = computeNodeFillType;
        }

        internal TaskSchedulingPolicy(Models.TaskSchedulingPolicy protocolObject)
        {
            this.computeNodeFillType = UtilitiesInternal.MapEnum<Models.ComputeNodeFillType, Common.ComputeNodeFillType>(protocolObject.NodeFillType);
        }

        #endregion Constructors

        #region TaskSchedulingPolicy

        /// <summary>
        /// Gets the fill type of scheduling policy.
        /// </summary>
        public Common.ComputeNodeFillType ComputeNodeFillType
        {
            get { return this.computeNodeFillType; }
        }

        #endregion // TaskSchedulingPolicy

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.TaskSchedulingPolicy ITransportObjectProvider<Models.TaskSchedulingPolicy>.GetTransportObject()
        {
            Models.TaskSchedulingPolicy result = new Models.TaskSchedulingPolicy()
            {
                NodeFillType = UtilitiesInternal.MapEnum<Common.ComputeNodeFillType, Models.ComputeNodeFillType>(this.ComputeNodeFillType),
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}