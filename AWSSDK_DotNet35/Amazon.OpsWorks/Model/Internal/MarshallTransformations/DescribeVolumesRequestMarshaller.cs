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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Volumes Request Marshaller
    /// </summary>       
    internal class DescribeVolumesRequestMarshaller : IMarshaller<IRequest, DescribeVolumesRequest> 
    {
        

        public IRequest Marshall(DescribeVolumesRequest describeVolumesRequest) 
        {

            IRequest request = new DefaultRequest(describeVolumesRequest, "AmazonOpsWorks");
            string target = "OpsWorks_20130218.DescribeVolumes";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
            string uriResourcePath = ""; 
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (describeVolumesRequest != null && describeVolumesRequest.IsSetInstanceId()) 
                {
                    writer.WritePropertyName("InstanceId");
                    writer.Write(describeVolumesRequest.InstanceId);
                }
                if (describeVolumesRequest != null && describeVolumesRequest.IsSetStackId()) 
                {
                    writer.WritePropertyName("StackId");
                    writer.Write(describeVolumesRequest.StackId);
                }
                if (describeVolumesRequest != null && describeVolumesRequest.IsSetRaidArrayId()) 
                {
                    writer.WritePropertyName("RaidArrayId");
                    writer.Write(describeVolumesRequest.RaidArrayId);
                }

                if (describeVolumesRequest != null && describeVolumesRequest.VolumeIds != null && describeVolumesRequest.VolumeIds.Count > 0) 
                {
                    List<string> volumeIdsList = describeVolumesRequest.VolumeIds;
                    writer.WritePropertyName("VolumeIds");
                    writer.WriteArrayStart();

                    foreach (string volumeIdsListValue in volumeIdsList) 
                    { 
                        writer.Write(StringUtils.FromString(volumeIdsListValue));
                    }

                    writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
