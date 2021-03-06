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

/*
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// For the provided the bounding box, confidence level that the bounding box actually
    /// contains a face, and the similarity between the face in the bounding box and the face
    /// in the source image.
    /// </summary>
    public partial class CompareFacesMatch
    {
        private ComparedFace _face;
        private float? _similarity;

        /// <summary>
        /// Gets and sets the property Face. 
        /// <para>
        /// Provides face metadata (bounding box and confidence that the bounding box actually
        /// contains a face).
        /// </para>
        /// </summary>
        public ComparedFace Face
        {
            get { return this._face; }
            set { this._face = value; }
        }

        // Check to see if Face property is set
        internal bool IsSetFace()
        {
            return this._face != null;
        }

        /// <summary>
        /// Gets and sets the property Similarity. 
        /// <para>
        /// Level of confidence that the faces match.
        /// </para>
        /// </summary>
        public float Similarity
        {
            get { return this._similarity.GetValueOrDefault(); }
            set { this._similarity = value; }
        }

        // Check to see if Similarity property is set
        internal bool IsSetSimilarity()
        {
            return this._similarity.HasValue; 
        }

    }
}