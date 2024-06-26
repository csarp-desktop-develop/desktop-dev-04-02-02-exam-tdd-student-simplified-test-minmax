﻿using Kreta.Desktop.SchoolCitizens;
using System;
using System.Collections.Generic;

namespace Kreta.Desktop.Models
{
    public class SchoolClass
    {
        public SchoolClass()
        {
            Id = Guid.Empty;
            SchoolGrade = -1;
            SchoolClassType = SchoolClassType.ClassA;
            TypeOfEducationId = Guid.Empty;
            YearOfEnrolment = -1;
            IsArchived = false;
            HeadTeacherId = Guid.Empty;
        }

        public SchoolClass(Guid id, int schoolGrade, SchoolClassType schoolClassType, int yearOfEnrolment, bool isArchived, Guid typeOfEducationId, Guid headTeacherId)
        {
            Id = id;
            SchoolGrade = schoolGrade;
            SchoolClassType = schoolClassType;
            TypeOfEducationId = typeOfEducationId;
            YearOfEnrolment = yearOfEnrolment;
            IsArchived = isArchived;
            HeadTeacherId = headTeacherId;
        }

        public Guid Id { get; set; }
        public bool HasId => Id != Guid.Empty;
        public int SchoolGrade { get; set; }
        public SchoolClassType SchoolClassType { get; set; }
        public Guid? TypeOfEducationId { get; set; }
        public Guid? HeadTeacherId { get; set; }
        public int YearOfEnrolment { get; set; }
        public bool IsArchived { get; set; }
        public string SchoolClassTypeName
        {
            get
            {
                string className = string.Empty;
                switch (SchoolClassType)
                {
                    case SchoolClassType.ClassA: className = "a"; break;
                    case SchoolClassType.ClassB: className = "b"; break;
                    case SchoolClassType.ClassC: className = "c"; break;
                }
                return className;
            }
        }
        public string SchoolClassName => $"{SchoolGrade}.{SchoolClassTypeName} ({YearOfEnrolment})";
        public override string ToString()
        {
            string archived = IsArchived ? "archivált" : string.Empty;
            return $"{SchoolClassName} {archived}";
        }
    }
}
