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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeDeployments</code> request.
    /// </summary>
    public partial class DescribeDeploymentsResult : AmazonWebServiceResponse
    {
        private List<Deployment> _deployments = new List<Deployment>();


        /// <summary>
        /// Gets and sets the property Deployments. 
        /// <para>
        /// An array of <code>Deployment</code> objects that describe the deployments.
        /// </para>
        /// </summary>
        public List<Deployment> Deployments
        {
            get { return this._deployments; }
            set { this._deployments = value; }
        }

        // Check to see if Deployments property is set
        internal bool IsSetDeployments()
        {
            return this._deployments != null && this._deployments.Count > 0; 
        }

    }
}