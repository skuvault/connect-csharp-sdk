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
    /// An employee created in the **Square Dashboard** account of a business.  Used by the Labor API.
    /// </summary>
    [DataContract]
    public partial class Employee :  IEquatable<Employee>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee" /> class.
        /// </summary>
        /// <param name="Id">UUID for this &#x60;Employee&#x60;..</param>
        /// <param name="FirstName">Given (first) name of the employee..</param>
        /// <param name="LastName">Family (last) name of the employee.</param>
        /// <param name="Email">Email of the employee.</param>
        /// <param name="PhoneNumber">Phone number of the employee in E.164 format, i.e. \&quot;+12125554250\&quot;.</param>
        /// <param name="LocationIds">A list of location IDs where this employee has access..</param>
        /// <param name="Status">Specifies the status of the employee being fetched. See [EmployeeStatus](#type-employeestatus) for possible values.</param>
        /// <param name="CreatedAt">A read-only timestamp in RFC 3339 format..</param>
        /// <param name="UpdatedAt">A read-only timestamp in RFC 3339 format..</param>
        public Employee(string Id = default(string), string FirstName = default(string), string LastName = default(string), string Email = default(string), string PhoneNumber = default(string), List<string> LocationIds = default(List<string>), string Status = default(string), string CreatedAt = default(string), string UpdatedAt = default(string))
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.LocationIds = LocationIds;
            this.Status = Status;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// UUID for this &#x60;Employee&#x60;.
        /// </summary>
        /// <value>UUID for this &#x60;Employee&#x60;.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Given (first) name of the employee.
        /// </summary>
        /// <value>Given (first) name of the employee.</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Family (last) name of the employee
        /// </summary>
        /// <value>Family (last) name of the employee</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Email of the employee
        /// </summary>
        /// <value>Email of the employee</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Phone number of the employee in E.164 format, i.e. \&quot;+12125554250\&quot;
        /// </summary>
        /// <value>Phone number of the employee in E.164 format, i.e. \&quot;+12125554250\&quot;</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// A list of location IDs where this employee has access.
        /// </summary>
        /// <value>A list of location IDs where this employee has access.</value>
        [DataMember(Name="location_ids", EmitDefaultValue=false)]
        public List<string> LocationIds { get; set; }
        /// <summary>
        /// Specifies the status of the employee being fetched. See [EmployeeStatus](#type-employeestatus) for possible values
        /// </summary>
        /// <value>Specifies the status of the employee being fetched. See [EmployeeStatus](#type-employeestatus) for possible values</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// A read-only timestamp in RFC 3339 format.
        /// </summary>
        /// <value>A read-only timestamp in RFC 3339 format.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// A read-only timestamp in RFC 3339 format.
        /// </summary>
        /// <value>A read-only timestamp in RFC 3339 format.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Employee {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  LocationIds: ").Append(LocationIds).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(obj as Employee);
        }

        /// <summary>
        /// Returns true if Employee instances are equal
        /// </summary>
        /// <param name="other">Instance of Employee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Employee other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.LocationIds == other.LocationIds ||
                    this.LocationIds != null &&
                    this.LocationIds.SequenceEqual(other.LocationIds)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.LocationIds != null)
                    hash = hash * 59 + this.LocationIds.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
