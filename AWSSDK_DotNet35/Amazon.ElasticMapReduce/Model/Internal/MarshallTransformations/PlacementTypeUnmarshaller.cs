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
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// PlacementTypeUnmarshaller
      /// </summary>
      internal class PlacementTypeUnmarshaller : IUnmarshaller<PlacementType, XmlUnmarshallerContext>, IUnmarshaller<PlacementType, JsonUnmarshallerContext>
      {
        PlacementType IUnmarshaller<PlacementType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public PlacementType Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            PlacementType placementType = new PlacementType();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("AvailabilityZone", targetDepth))
              {
                placementType.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return placementType;
        }

        private static PlacementTypeUnmarshaller instance;
        public static PlacementTypeUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new PlacementTypeUnmarshaller();
            return instance;
        }
    }
}
  
