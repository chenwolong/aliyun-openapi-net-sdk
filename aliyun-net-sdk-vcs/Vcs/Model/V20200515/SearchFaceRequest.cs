/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Vcs.Transform;
using Aliyun.Acs.Vcs.Transform.V20200515;

namespace Aliyun.Acs.Vcs.Model.V20200515
{
    public class SearchFaceRequest : RpcAcsRequest<SearchFaceResponse>
    {
        public SearchFaceRequest()
            : base("Vcs", "2020-05-15", "SearchFace", "vcs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string corpId;

		private string gbId;

		private long? startTimeStamp;

		private long? endTimeStamp;

		private int? pageNo;

		private int? pageSize;

		private string optionList;

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public string GbId
		{
			get
			{
				return gbId;
			}
			set	
			{
				gbId = value;
				DictionaryUtil.Add(BodyParameters, "GbId", value);
			}
		}

		public long? StartTimeStamp
		{
			get
			{
				return startTimeStamp;
			}
			set	
			{
				startTimeStamp = value;
				DictionaryUtil.Add(BodyParameters, "StartTimeStamp", value.ToString());
			}
		}

		public long? EndTimeStamp
		{
			get
			{
				return endTimeStamp;
			}
			set	
			{
				endTimeStamp = value;
				DictionaryUtil.Add(BodyParameters, "EndTimeStamp", value.ToString());
			}
		}

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(BodyParameters, "PageNo", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string OptionList
		{
			get
			{
				return optionList;
			}
			set	
			{
				optionList = value;
				DictionaryUtil.Add(BodyParameters, "OptionList", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SearchFaceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SearchFaceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
