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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Crm.Transform;
using Aliyun.Acs.Crm.Transform.V20150408;

namespace Aliyun.Acs.Crm.Model.V20150408
{
    public class DeleteLabelRequest : RpcAcsRequest<DeleteLabelResponse>
    {
        public DeleteLabelRequest()
            : base("Crm", "2015-04-08", "DeleteLabel", "crm", "openAPI")
        {
        }

		private string labelSeries;

		private string organization;

		private string pK;

		private string labelName;

		private string userName;

		public string LabelSeries
		{
			get
			{
				return labelSeries;
			}
			set	
			{
				labelSeries = value;
				DictionaryUtil.Add(QueryParameters, "LabelSeries", value);
			}
		}

		public string Organization
		{
			get
			{
				return organization;
			}
			set	
			{
				organization = value;
				DictionaryUtil.Add(QueryParameters, "Organization", value);
			}
		}

		public string PK
		{
			get
			{
				return pK;
			}
			set	
			{
				pK = value;
				DictionaryUtil.Add(QueryParameters, "PK", value);
			}
		}

		public string LabelName
		{
			get
			{
				return labelName;
			}
			set	
			{
				labelName = value;
				DictionaryUtil.Add(QueryParameters, "LabelName", value);
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(QueryParameters, "UserName", value);
			}
		}

        public override DeleteLabelResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteLabelResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
