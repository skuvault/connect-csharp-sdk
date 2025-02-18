/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class BatchRetrieveCatalogObjectsRequest :  IEquatable<BatchRetrieveCatalogObjectsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRetrieveCatalogObjectsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchRetrieveCatalogObjectsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRetrieveCatalogObjectsRequest" /> class.
        /// </summary>
        /// <param name="ObjectIds">The IDs of the [CatalogObject](#type-catalogobject)s to be retrieved. (required).</param>
        /// <param name="IncludeRelatedObjects">If &#x60;true&#x60;, the response will include additional objects that are related to the requested objects, as follows:  If the &#x60;objects&#x60; field of the response contains a [CatalogItem](#type-catalogitem),  its associated [CatalogCategory](#type-catalogcategory), [CatalogTax](#type-catalogtax)es, [CatalogImage](#type-catalogimage)s and [CatalogModifierList](#type-catalogmodifierlist)s will be returned in the &#x60;related_objects&#x60; field of the response. If the &#x60;objects&#x60; field of the response contains a [CatalogItemVariation](#type-catalogitemvariation), its parent [CatalogItem](#type-catalogitem) will be returned in the &#x60;related_objects&#x60; field of the response..</param>
        public BatchRetrieveCatalogObjectsRequest(List<string> ObjectIds = default(List<string>), bool? IncludeRelatedObjects = default(bool?))
        {
            // to ensure "ObjectIds" is required (not null)
            if (ObjectIds == null)
            {
                throw new InvalidDataException("ObjectIds is a required property for BatchRetrieveCatalogObjectsRequest and cannot be null");
            }
            else
            {
                this.ObjectIds = ObjectIds;
            }
            this.IncludeRelatedObjects = IncludeRelatedObjects;
        }
        
        /// <summary>
        /// The IDs of the [CatalogObject](#type-catalogobject)s to be retrieved.
        /// </summary>
        /// <value>The IDs of the [CatalogObject](#type-catalogobject)s to be retrieved.</value>
        [DataMember(Name="object_ids", EmitDefaultValue=false)]
        public List<string> ObjectIds { get; set; }
        /// <summary>
        /// If &#x60;true&#x60;, the response will include additional objects that are related to the requested objects, as follows:  If the &#x60;objects&#x60; field of the response contains a [CatalogItem](#type-catalogitem),  its associated [CatalogCategory](#type-catalogcategory), [CatalogTax](#type-catalogtax)es, [CatalogImage](#type-catalogimage)s and [CatalogModifierList](#type-catalogmodifierlist)s will be returned in the &#x60;related_objects&#x60; field of the response. If the &#x60;objects&#x60; field of the response contains a [CatalogItemVariation](#type-catalogitemvariation), its parent [CatalogItem](#type-catalogitem) will be returned in the &#x60;related_objects&#x60; field of the response.
        /// </summary>
        /// <value>If &#x60;true&#x60;, the response will include additional objects that are related to the requested objects, as follows:  If the &#x60;objects&#x60; field of the response contains a [CatalogItem](#type-catalogitem),  its associated [CatalogCategory](#type-catalogcategory), [CatalogTax](#type-catalogtax)es, [CatalogImage](#type-catalogimage)s and [CatalogModifierList](#type-catalogmodifierlist)s will be returned in the &#x60;related_objects&#x60; field of the response. If the &#x60;objects&#x60; field of the response contains a [CatalogItemVariation](#type-catalogitemvariation), its parent [CatalogItem](#type-catalogitem) will be returned in the &#x60;related_objects&#x60; field of the response.</value>
        [DataMember(Name="include_related_objects", EmitDefaultValue=false)]
        public bool? IncludeRelatedObjects { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRetrieveCatalogObjectsRequest {\n");
            sb.Append("  ObjectIds: ").Append(ObjectIds).Append("\n");
            sb.Append("  IncludeRelatedObjects: ").Append(IncludeRelatedObjects).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BatchRetrieveCatalogObjectsRequest);
        }

        /// <summary>
        /// Returns true if BatchRetrieveCatalogObjectsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchRetrieveCatalogObjectsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchRetrieveCatalogObjectsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ObjectIds == other.ObjectIds ||
                    this.ObjectIds != null &&
                    this.ObjectIds.SequenceEqual(other.ObjectIds)
                ) && 
                (
                    this.IncludeRelatedObjects == other.IncludeRelatedObjects ||
                    this.IncludeRelatedObjects != null &&
                    this.IncludeRelatedObjects.Equals(other.IncludeRelatedObjects)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ObjectIds != null)
                    hash = hash * 59 + this.ObjectIds.GetHashCode();
                if (this.IncludeRelatedObjects != null)
                    hash = hash * 59 + this.IncludeRelatedObjects.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
