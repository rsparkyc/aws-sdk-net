/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes the instance status.</para>
    /// </summary>
    public partial class InstanceStatusDetails
    {
        
        private StatusName name;
        private StatusType status;
        private DateTime? impairedSince;


        /// <summary>
        /// The type of instance status.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>reachability</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public StatusName Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The status.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>passed, failed, insufficient-data</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public StatusType Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The time when a status check failed. For an instance that was launched and impaired, this is the time when the instance was launched.
        ///  
        /// </summary>
        public DateTime ImpairedSince
        {
            get { return this.impairedSince ?? default(DateTime); }
            set { this.impairedSince = value; }
        }

        // Check to see if ImpairedSince property is set
        internal bool IsSetImpairedSince()
        {
            return this.impairedSince.HasValue;
        }
    }
}
